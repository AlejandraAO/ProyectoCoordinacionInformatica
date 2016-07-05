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
        private SqlDataReader dtrMiembro2;

        private frmAsignarMiembroAProyecto frmAsignarProyecto;

        #endregion
        public frmGestionMiembros()
        {
            conexion = new clConexion();
            pEntidadMiembro = new clEntidadMiembro();
            pEntidadMiembroProyecto = new clEntidadMiembroProyecto();

            miembros = new clMiembros();
            miembroProyecto = new clMiembroProyecto();

            frmAsignarProyecto = new frmAsignarMiembroAProyecto(conexion);

            InitializeComponent();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string idProyecto;

            if (mVerificarCampos() && mConsultarPorCarnetExiste()== false)
            {

                conexion.codigo = "123";
                conexion.clave = "123";
                pEntidadMiembro.getSetCarnetMiembro = txtCarnet.Text;
                pEntidadMiembro.getSetNombreMiembro = txtNombre.Text;
                pEntidadMiembro.getSetApellido1Miembro = txtApellido1.Text;
                pEntidadMiembro.getSetApellido2Miembro = txtApellido2.Text;
                pEntidadMiembro.getSetTipo = txtTipo.Text;
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
                                idProyecto = frmAsignarProyecto.getIdsProyecto();

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
                && (txtTipo.Text != ""))
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
            txtTipo.Text = "";
            lblNumProyAsignados.Text = "";
            frmAsignarProyecto.limpiarLVProyAsignados();
        }

        public int buscarIdPorCarnet(String carnet)
        {
            dtrMiembro = miembros.mConsultarMiembroId(conexion, pEntidadMiembro);
            if (dtrMiembro != null)
            {
                if (dtrMiembro.Read())
                {
                    return dtrMiembro.GetInt32(0);
                }
            }

            return 0;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (mVerificarCampos())
            {            

                pEntidadMiembro.getSetCarnetMiembro = txtCarnet.Text;
                pEntidadMiembro.getSetNombreMiembro = txtNombre.Text;
                pEntidadMiembro.getSetApellido1Miembro = txtApellido1.Text;
                pEntidadMiembro.getSetApellido2Miembro = txtApellido2.Text;
                pEntidadMiembro.getSetTipo = txtTipo.Text;
                pEntidadMiembro.getSetCarreraMiembro = txtCarrera.Text;

                if (miembros.mModificarMiembro(conexion, pEntidadMiembro))
                {

                    //int idMiembro = buscarIdPorCarnet(Convert.ToInt32( txtCarnet.Text));
                    int idMiembro = buscarIdPorCarnet(txtCarnet.Text);
                    frmAsignarProyecto.modificarProyectosAsignados(idMiembro);
                    
                        MessageBox.Show("Se ha modificado el Miembro", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //mLimpiarCampos();

                  
                }
                else
                {
                    MessageBox.Show("No se ha podido modificar el Miembro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Favor llenar todos los campos", "Datos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            mConsultarPorCarnet();
        }

        private void btnBuscarProyecto_Click(object sender, EventArgs e)
        {
           
                frmAsignarProyecto.ShowDialog();

            if (frmAsignarProyecto.getCantidadProyectosAsignados()==1)
                this.lblNumProyAsignados.Text = frmAsignarProyecto.getCantidadProyectosAsignados() + "  Proyecto Asignado";

            else
            this.lblNumProyAsignados.Text =  frmAsignarProyecto.getCantidadProyectosAsignados() + "  Proyectos Asignados";
        }

        private void txtCarnet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                if (txtCarnet.Text != "")
                {
                    mConsultarPorCarnet();
                }
                else
                {
                    MessageBox.Show("Ingrese un Carnet", "Datos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        public Boolean mConsultarPorCarnetExiste()
        {
            pEntidadMiembro.getSetCarnetMiembro = txtCarnet.Text;

            dtrMiembro = miembros.mConsultarMiembroCarnee(conexion, pEntidadMiembro);
            if(dtrMiembro!= null && dtrMiembro.Read())
            {
                mLimpiarCampos();
                MessageBox.Show("No es posible agregar dos miembros con el mismo carné", "Miembro Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                return false;
            }

        }



        public void mConsultarPorCarnet()
        {
            pEntidadMiembro.getSetCarnetMiembro = txtCarnet.Text;
            mLimpiarCampos();


            dtrMiembro = miembros.mConsultarMiembroCarnee(conexion, pEntidadMiembro);
            

            if (dtrMiembro != null)
            {
                if (dtrMiembro.Read())
                {
                    txtCarnet.Text = dtrMiembro.GetString(1);
                    txtNombre.Text = dtrMiembro.GetString(2);
                    txtApellido1.Text = dtrMiembro.GetString(3);
                    txtApellido2.Text = dtrMiembro.GetString(4);
                    txtCarrera.Text = dtrMiembro.GetString(5);
                    txtTipo.Text = dtrMiembro.GetString(6);
          
                    frmAsignarProyecto.cargarProyectosAsignados(dtrMiembro.GetInt32(0));

                }
                else
                {
                    MessageBox.Show("El miembro solicitado no existe", "Miembro no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No se ha encontrado el miembro solicitado", "Miembro no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
