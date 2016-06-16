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

            frmConsultaProyecto = new frmConsultaRapProyecto(conexion);

            InitializeComponent();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string idProyecto;

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

                            do
                            {
                                idProyecto = frmConsultaProyecto.getIdsProyecto();

                                if (idProyecto != null)
                                {
                                    pEntidadMiembroProyecto.mIdProyecto = Convert.ToInt32(idProyecto);

                                    miembroProyecto.mInsertarMiembroProyecto(conexion, pEntidadMiembroProyecto);
                                }
                           


                            } while (idProyecto != null);


                            mLimpiarCampos();
                            MessageBox.Show("Exito. Miembro ingresado");
                        }

                    }


                }
                else
                {
                    MessageBox.Show("Error. Miembro no ingresado");
                    mLimpiarCampos();
                }


            }
            else
            {
                MessageBox.Show("Datos insuficientes para agregar un Miembro", "Favor completar campos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




        }
        public Boolean mVerificarCampos()
        {
            if ((txtNombre.Text != "") && (txtApellido1.Text != "") && (txtApellido2.Text != "") && (txtCarrera.Text != "") && (txtCarnet.Text != "")
                && (txtTip.Text != "") && (frmConsultaProyecto. verificarListViewVacio()==true))
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
            txtTip.Text = "";
            lblNumProyAsignados.Text = "";
            frmConsultaProyecto.limpiarLVProyAsignados();
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
           
                frmConsultaProyecto.ShowDialog();

            if (frmConsultaProyecto.getCantidadProyectosAsignados()==1)
                this.lblNumProyAsignados.Text = frmConsultaProyecto.getCantidadProyectosAsignados() + "  Proyecto Asignado";

            else
            this.lblNumProyAsignados.Text =  frmConsultaProyecto.getCantidadProyectosAsignados() + "  Proyectos Asignados";
        }


    }
}
