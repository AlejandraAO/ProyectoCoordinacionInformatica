using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Entidades;
using LogicaNegocios;
using System.Data.SqlClient;

namespace Vista
{
    public partial class frmGestionCursosLibres : Form
    {
        private menuPrincipal menu;
        private OpenFileDialog archivoSeleccionado;
        private clEntidadCursoLibre entidadCursoLibre;
        private clConexion conexion;
        private clCursoLibre cursoLibre;
        public frmGestionCursosLibres(menuPrincipal menu)
        {
            InitializeComponent();
            this.menu = menu;
            conexion = new clConexion();
            this.archivoSeleccionado = new OpenFileDialog();
            this.cursoLibre = new clCursoLibre();
            this.entidadCursoLibre = new clEntidadCursoLibre();
            this.conexion.codigo = "sa";
            this.conexion.clave = "123";
            this.conexion.baseDatos = "BDPortafolioUCR";
        }

        private void groupBox_Enter(object sender, EventArgs e)
        {

        }
        // Este metodo se encargara de verificar que los TextBox no esten vacios en el momento de ingresar un Curso Libre
        #region Metodo verifica Espacios

        public Boolean mVerificarTextBox(Form interfaz)
        {
            Boolean exitoso = true;
            foreach (Control componente in interfaz.Controls)
            {
                // Verica el componente  es un TextBox, si es uno , entonces comprueba si esta vacio y si se cumple returna false
                if (componente is TextBox && componente.Text.Trim().Equals(""))
                {

                    return false;
                }// fin del if
                 // Verifa si es un Group Box y lo recorre
                else if (componente is GroupBox)
                {
                    // Verica si el subComponente es un TextBox, si es uno , entonces comprueba si esta vacio y si se cumple returna false
                    foreach (Control subComponente in componente.Controls)
                    {
                        if (subComponente is TextBox && subComponente.Text.Trim().Equals(""))
                        {
                            return false;
                        }
                    }// fin del foreach
                }    //fin del else        
            }// fin del foreach que recorre la ventana
            return exitoso;

        }
        #endregion

        private void frmGestionCursosLibres_Load(object sender, EventArgs e)
        {
            
        }

        private void mlimpiar()
        {
            this.txtNombre.Text = "";
            this.txtLugar.Text = "";
            this.txtProfesor.Text = "";
            this.cbEstado.Text = "";
            this.lbNombrePrograma.Text = "Nombre del Archivo";
            this.rtDescripcion.Text = "";
            this.numCupo.Value = 0;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.mlimpiar();
        }


        //metodo que selecciona los archivos que se subiran a la base de datos
        private void btnExaminar_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            //OpenFileDialog archivoSeleccionado = new OpenFileDialog();

            //La busqueda inicia a partir del direccion c:\\
            archivoSeleccionado.InitialDirectory = "c:\\";
            //Tipos de archivos permitidos
            archivoSeleccionado.Filter = "Pdf files (*.pdf)|*.pdf|Odt files (*.odt)|*.odt";
            archivoSeleccionado.FilterIndex = 2;
            archivoSeleccionado.RestoreDirectory = true;

            if (archivoSeleccionado.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = archivoSeleccionado.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            lbNombrePrograma.Text = archivoSeleccionado.SafeFileName;
                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }//Fin del metodo del boton exminar

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.menu.Visible = true;
            this.Hide();
        }

        #region Agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Verifica que los txt que tiene la ventana y la descripcion tengan datos 
            if (mVerificarTextBox(this) && !cbEstado.SelectedItem.ToString().Equals("") && !rtDescripcion.Text.Equals(""))
            {
                //Verifica que se haya elejido un programa para el curso
                if (!lbNombrePrograma.Text.Equals("Nombre del archivo"))
                {
                    //Carga la entidad con los datos 
                    cargarEntidadCurso();
                    // Llama al metodo insertar e ingresa un nuevo Curso 
                    if (cursoLibre.mInsertarCursoLibre(this.conexion, this.entidadCursoLibre))
                    {
                        // Despues de que inserta llama al metodo limpiar
                        mlimpiar();
                        MessageBox.Show("Curso Agregado con Exíto", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }//Fin del if del insertar
                    else
                    {
                        MessageBox.Show("Surgio un Error al agregar el Curso", "Falló", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }// fin del else de insertar

                }//fin del if , que verifica que se selccionara un programa
                else
                {
                    MessageBox.Show("Debe de Seleccionar Un programa", "Programa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }//fin del else que verifica que se selccionara un programa
            }// fin del if que verifica los txt y las areas de texto
            else
            {
                MessageBox.Show("Debe de Completar los espacios Solicitados", "Datos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }// Fin del else que verifica los txt
        }// fin del agregar
        #endregion
        private void lbNombrePrograma_Click(object sender, EventArgs e)
        {

        }
        #region Metodo Carga la entidad
        public void cargarEntidadCurso()
        {
            entidadCursoLibre.Cupo = Int32.Parse( numCupo.Value.ToString());
            entidadCursoLibre.Nombre = this.txtNombre.Text;
            entidadCursoLibre.Estado = cbEstado.SelectedItem.ToString();
            entidadCursoLibre.Lugar = this.txtLugar.Text;
            entidadCursoLibre.Descripcion = rtDescripcion.Text;
            entidadCursoLibre.IdProfesor = Int32.Parse(txtProfesor.Text);
            entidadCursoLibre.Programa = archivoSeleccionado.FileName;
            entidadCursoLibre.Nombre_Programa = archivoSeleccionado.SafeFileName;

        }
        #endregion
        private void btnBuscarCurso_Click(object sender, EventArgs e)
        {
            SqlDataReader datos = cursoLibre.mConsultadeCursos(conexion);
            frmConsultarRapCursosLibres lvCursosLibres = new frmConsultarRapCursosLibres(datos);
            lvCursosLibres.ShowDialog();
            if (string.IsNullOrEmpty(lvCursosLibres.codigo))
            {

            }
            else
            {
                entidadCursoLibre.IdCursoLibre = Convert.ToInt32(lvCursosLibres.codigo);
                datos = cursoLibre.mConsultaPorID(conexion, entidadCursoLibre);
                while (datos.Read())
                {
                    this.txtNombre.Text = datos.GetString(1);
                    this.txtProfesor.Text = Convert.ToString(datos.GetInt32(0));
                    this.numCupo.Value = datos.GetInt32(5);
                    this.cbEstado.Text = datos.GetString(3);
                    this.rtDescripcion.Text = datos.GetString(2);
                    this.txtLugar.Text = datos.GetString(4);
                    this.lbNombrePrograma.Text = datos.GetString(6);
                }
            }
            
        }

        private void btnBuscarProfesores_Click(object sender, EventArgs e)
        {
            SqlDataReader datos = cursoLibre.mConsultadeProfesores(conexion);
            frmConsultarRapCursosLibres lvCursosLibres = new frmConsultarRapCursosLibres(datos);
            lvCursosLibres.ShowDialog();
            this.txtProfesor.Text=lvCursosLibres.codigo;
        }
    }
}
