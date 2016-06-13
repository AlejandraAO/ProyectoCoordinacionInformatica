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

       private SqlDataReader  dtrProyecto;
       private  clConexion conexion;
       private menuPrincipal menu;
       private clProyecto proyecto;

        #endregion

        public frmReporteProyectos(menuPrincipal menu)
        {
            InitializeComponent();

            this.menu = menu;
            this.conexion = new clConexion();
            this.proyecto = new clProyecto();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
            menu.Show();
        }

        private void frmReporteProyectos_Load(object sender, EventArgs e)
        {
            dtrProyecto = proyecto.mConsultaGeneralProyectos(conexion);

            if (dtrProyecto != null)
                while (dtrProyecto.Read())
                {
                    mLlenarListaProtectos();

                }//fin del read

        }

        public void mLlenarListaProtectos()
        {
            int reglon = dgvProyecto.Rows.Add();
            dgvProyecto.Rows[reglon].Cells["Codigo"].Value = dtrProyecto.GetInt32(0);
            dgvProyecto.Rows[reglon].Cells["Nombre"].Value = dtrProyecto.GetString(1);
            dgvProyecto.Rows[reglon].Cells["Descripcion"].Value = dtrProyecto.GetString(2); // implementar emergernte
            dgvProyecto.Rows[reglon].Cells["estado"].Value = dtrProyecto.GetString(3);
            dgvProyecto.Rows[reglon].Cells["tipo"].Value = dtrProyecto.GetString(4);
            dgvProyecto.Rows[reglon].Cells["informacion"].Value = dtrProyecto.GetString(5);
          //  dgvProyecto.Rows[reglon].Cells["TotalHoras"].Value = dtrProyecto.GetString(6);

        }


    }
}
