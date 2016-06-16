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
using AccesoDatos;
using Entidades;
using LogicaNegocios;

namespace Vista
{
    public partial class frmReporteProyectos : Form
    {

        #region Atributos

        private SqlDataReader dtrProyecto;
        private clConexion conexion;
        private menuPrincipal menu;
        private clProyecto proyecto;
        private clEntidadProyecto pEntidadProyecto;


        #endregion

        public frmReporteProyectos(menuPrincipal menu)
        {
            InitializeComponent();

            this.menu = menu;
            this.conexion = new clConexion();
            this.proyecto = new clProyecto();
            this.pEntidadProyecto = new clEntidadProyecto();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
            menu.Show();
        }

        private void frmReporteProyectos_Load(object sender, EventArgs e)
        {
            mConsultaGeneralProyecto();

        }

        public void mLlenarListaProyectos()
        {
            int reglon = dgvProyecto.Rows.Add();
            dgvProyecto.Rows[reglon].Cells["Codigo"].Value = dtrProyecto.GetInt32(0);
            dgvProyecto.Rows[reglon].Cells["Nombre"].Value = dtrProyecto.GetString(1);
            dgvProyecto.Rows[reglon].Cells["Descripcion"].Value = dtrProyecto.GetString(2); // implementar emergernte
            dgvProyecto.Rows[reglon].Cells["estado"].Value = dtrProyecto.GetString(3);
            dgvProyecto.Rows[reglon].Cells["tipo"].Value = dtrProyecto.GetString(4);
            dgvProyecto.Rows[reglon].Cells["informacion"].Value = dtrProyecto.GetString(6);
  

        }

        public void mConsultaGeneralProyecto()
        {

            dtrProyecto = proyecto.mConsultaGeneralProyectos(conexion);


            if (dtrProyecto != null)
            {

                while (dtrProyecto.Read())
                {
                    mLlenarListaProyectos();


                }
            }
        }

        private void dgvProyecto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProyecto.CurrentCell.ColumnIndex == 5)
            {
                FolderBrowserDialog carpetaSeleccionada = new FolderBrowserDialog();
                carpetaSeleccionada.Description = "Seleccione la ruta donde guardará el programa";
                DialogResult result = carpetaSeleccionada.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string ruta = carpetaSeleccionada.SelectedPath + "/" + dgvProyecto.CurrentCell.Value;

                    pEntidadProyecto.mIdProyecto = Convert.ToInt32(dgvProyecto.Rows[dgvProyecto.CurrentCell.RowIndex].Cells[0].Value);
                    proyecto.mDescargarDocumentoProyecto(conexion, ruta, pEntidadProyecto);

                    
                }
            }
        }


        //se cargan los datos del colaborador/cordinador  en el lv
        private void cbConsultarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Convert.ToString( this.cbConsultarPor)) {

                case "Coordinador": break;

                case "Colaborador": break;

            }

        }

        //se consuta un proyecto especifico por nombre
        private void btnConsultar_Click_1(object sender, EventArgs e)
        {

            pEntidadProyecto.mNombre = txtDatoConsulta.Text;
            dtrProyecto = proyecto.mConsultarPorNombre(conexion, pEntidadProyecto);


            if (dtrProyecto != null)
            {

                while (dtrProyecto.Read())
                {
                    mLimpiarLista();
                    mLlenarListaProyectos();


                }
            }


        }
        public void mLimpiarLista()
        {
            dgvProyecto.Rows.Clear();
        }

        private void txtDatoConsulta_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtDatoConsulta.Text == "")
            {
                mLimpiarLista();
                mConsultaGeneralProyecto();
            }
        }
    }
}
