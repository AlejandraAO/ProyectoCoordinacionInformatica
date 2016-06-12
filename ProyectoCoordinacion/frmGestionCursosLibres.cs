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

namespace Vista
{
    public partial class frmGestionCursosLibres : Form
    {
        private menuPrincipal menu;
        private OpenFileDialog archivoSeleccionado;
        public frmGestionCursosLibres(menuPrincipal menu)
        {
            InitializeComponent();
            this.menu = menu;
            this.archivoSeleccionado = new OpenFileDialog();
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
            this.cbProfesor.Text = "";
            this.cbEstado.Text = "";
            this.lbNombrePrograma.Text = "Nombre del Archivo";
            this.rtDescripcion.Text = "";
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
    }
}
