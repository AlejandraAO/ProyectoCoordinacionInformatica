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
            this.conexion.codigo = "123";
            this.conexion.clave = "123";
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

        private void limpiar()
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
            this.limpiar();
        }


        //metodo que selecciona los archivos que se subiran a la base de datos
        private void btnExaminar_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            //OpenFileDialog archivoSeleccionado = new OpenFileDialog();

            archivoSeleccionado.InitialDirectory = "c:\\";
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(mVerificarTextBox(this)&& !cbEstado.SelectedItem.ToString().Equals("")&&!rtDescripcion.Text.Equals(""))
            {
                if ( !lbNombrePrograma.Text.Equals("Nombre del archivo"))
                {
                    if(cursoLibre.mInsertarCursoLibre(this.conexion,this.entidadCursoLibre))
                    {

                    }
                    else
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Debe de Seleccionar Un programa", "Programa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe de Completar los espacios Solicitados", "Datos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbNombrePrograma_Click(object sender, EventArgs e)
        {

        }
        public void cargarEntidadCurso()
        {
            entidadCursoLibre.Cupo = Int32.Parse( numCupo.Value.ToString());
            entidadCursoLibre.Nombre = this.txtNombre.Text;
            entidadCursoLibre.Estado = cbEstado.SelectedItem.ToString();
            entidadCursoLibre.Lugar = this.txtLugar.Text;
            entidadCursoLibre.Descripcion = rtDescripcion.Text;
            entidadCursoLibre.IdProfesor = Int32.Parse(txtProfesor.Text);
            entidadCursoLibre.Programa = archivoSeleccionado.FileName; 
                  
        }
    }
}
