using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LogicaNegocios;
using Entidades;
using AccesoDatos;
using System.Data.SqlClient;

namespace Vista
{
    public partial class frmReporteProfesores : Form
    {
        #region Atributos
        clConexion conexion;
        menuPrincipal menu;
        SqlDataReader dtrHorarioProfesor;
        SqlDataReader dtrProfesor;
        #endregion


        public frmReporteProfesores( )
        {
            
            InitializeComponent();
            this.conexion = new clConexion();
        }

        private void dgvReporteProfesor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmReporteProfesores_Load(object sender, EventArgs e)
        {
            //dtrProfesor=
        }
    }
}
