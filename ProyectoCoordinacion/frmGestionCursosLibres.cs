using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmGestionCursosLibres : Form
    {
        private menuPrincipal menu;
        public frmGestionCursosLibres(menuPrincipal menu)
        {
            InitializeComponent();
            this.menu = menu;
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
    }
}
