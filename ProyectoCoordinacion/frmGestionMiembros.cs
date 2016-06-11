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

            //Agregar Miembro
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
                    MessageBox.Show("Se ha insertado el Miembro", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mLimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo insertar el Miembro", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    mLimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Datos insuficientes para agregar un Miembro", "Favor completar campos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Agregar Relacion Entre Miembro y Proyecto

            int idMiembro=0;
            dtrMiembro = miembros.mConsultarIdMiembro(conexion, pEntidadMiembro);

            if (dtrMiembro!=null)
            {
                if (dtrMiembro.Read())
                {
                    idMiembro = dtrMiembro.GetInt32(0);
                }

            }

            pEntidadMiembroProyecto.mIdProyecto = Convert.ToInt32(this.txtProyecto.Text);
            pEntidadMiembroProyecto.mIdMiembro =idMiembro;

            if (miembroProyecto.mInsertarMiembroProyecto(conexion, pEntidadMiembroProyecto))
            {
                MessageBox.Show("Insert en la tabla tbMiembrosProy ", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mLimpiarCampos();
            }
       


        }
        public Boolean mVerificarCampos()
        {
            if((txtNombre.Text!="") && (txtApellido1.Text!="") && (txtApellido2.Text!="") && (txtCarrera.Text!="") && (lbTipo.Text != ""))
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
            lbTipo.Text = "";
            txtCarrera.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos insuficientes para agregar un Miembro", "Favor completar campos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmConsultarMiembro miembro = new frmConsultarMiembro();
            miembro.Show();
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
