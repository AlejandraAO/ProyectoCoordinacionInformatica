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
        private clMiembros miembros;
        private SqlDataReader dtrMiembro;
        #endregion
        public frmGestionMiembros()
        {
            conexion = new clConexion();
            pEntidadMiembro = new clEntidadMiembro();
            miembros = new clMiembros();
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
                pEntidadMiembro.getSetNombreMiembro = txtNombre.Text;
                pEntidadMiembro.getSetApellido1Miembro = txtApellido1.Text;
                pEntidadMiembro.getSetApellido2Miembro = txtApellido2.Text;
                pEntidadMiembro.getSetTipo = txtTipo.Text;
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
        }
        public Boolean mVerificarCampos()
        {
            if((txtNombre.Text!="") && (txtApellido1.Text!="") && (txtApellido2.Text!="") && (txtCarrera.Text!="") && (txtTipo.Text != ""))
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
            txtTipo.Text = "";
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
    }
}
