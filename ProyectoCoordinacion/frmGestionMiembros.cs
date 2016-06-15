using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Entidades;
using LogicaNegocios;
using AccesoDatos;
using System.Transactions;

namespace Vista
{
    public partial class frmGestionMiembros : Form
    {
        #region Atributos
        private clConexion conexion;
        private clEntidadMiembro pEntidadMiembro;
        private clEntidadMiembroProyecto pEntidadMiembroProyecto;
        private clMiembros miembros;
        private clMiembroProyecto miembroProyecto;
        private SqlDataReader dtrMiembro;

        private frmConsultaRapProyecto frmConsultaProyecto;

        #endregion
        public frmGestionMiembros()
        {
            conexion = new clConexion();
            pEntidadMiembro = new clEntidadMiembro();
            pEntidadMiembroProyecto = new clEntidadMiembroProyecto();

            miembros = new clMiembros();
            miembroProyecto = new clMiembroProyecto();

            InitializeComponent();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (mVerificarCampos())
            {

                conexion.codigo = "123";
                conexion.clave = "123";
                pEntidadMiembro.getSetCarnetMiembro = txtCarnet.Text;
                pEntidadMiembro.getSetNombreMiembro = txtNombre.Text;
                pEntidadMiembro.getSetApellido1Miembro = txtApellido1.Text;
                pEntidadMiembro.getSetApellido2Miembro = txtApellido2.Text;
                pEntidadMiembro.getSetTipo = txtTip.Text;
                pEntidadMiembro.getSetCarreraMiembro = txtCarrera.Text;





                if (miembros.mInsertarMiembro(conexion, pEntidadMiembro))
                {

                    dtrMiembro = miembros.mConsultarIdMiembro(conexion);

                    if (dtrMiembro != null)
                    {
                        if (dtrMiembro.Read())
                        {
                            pEntidadMiembroProyecto.mIdMiembro = Convert.ToInt32(dtrMiembro.GetDecimal(0));
                            pEntidadMiembroProyecto.mIdProyecto = Convert.ToInt32(txtProyecto.Text);

                            miembroProyecto.mInsertarMiembroProyecto(conexion, pEntidadMiembroProyecto);

                            MessageBox.Show("Exito al ingresar el nuevo miembro");
                            mLimpiarCampos();
                        }

                    }


                }
                else
                {
                    MessageBox.Show("Error. Miembro no ingresado");
                    mLimpiarCampos();
                }


                /* try
                 {
                     using (TransactionScope rootScope = new TransactionScope())
                     {
                         if (miembros.mInsertarMiembro(conexion, pEntidadMiembro) && miembroProyecto.mInsertarMiembroProyecto(conexion2, pEntidadMiembroProyecto)) {

                             rootScope.Complete();
                         }

                         else { rootScope.Dispose(); }


                     }
                 }
                 catch (Exception tae)
                 {
                     MessageBox.Show("Transaction Exception Occured");
                 }
                 */


            }
            else
            {
                MessageBox.Show("Datos insuficientes para agregar un Miembro", "Favor completar campos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




        }
        public Boolean mVerificarCampos()
        {
            if ((txtNombre.Text != "") && (txtApellido1.Text != "") && (txtApellido2.Text != "") && (txtCarrera.Text != "") && (txtCarnet.Text != "")
                && (txtProyecto.Text != "") && (txtTip.Text != ""))
            {
                return true;
            }
            return false;
        }
        public void mLimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido1.Text = "";
            txtApellido2.Text = "";
            txtCarnet.Text = "";
            txtCarrera.Text = "";
            txtProyecto.Text = "";
            txtTip.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos insuficientes para agregar un Miembro", "Favor completar campos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBuscarProyecto_Click(object sender, EventArgs e)
        {
            frmConsultaProyecto= new frmConsultaRapProyecto(conexion);
            frmConsultaProyecto.ShowDialog();

            if (frmConsultaProyecto.mIdProyecto!= "")
            {
                this.txtProyecto.Text = frmConsultaProyecto.mIdProyecto;
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
