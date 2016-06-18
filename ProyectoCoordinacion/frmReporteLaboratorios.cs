using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AccesoDatos;
using Entidades;
using LogicaNegocios;
using System.Data.SqlClient;

namespace Vista
{
    public partial class frmReporteLaboratorios : Form
    {
        #region Atributos
        clConexion conexion;
        menuPrincipal menu;
        SqlDataReader dtrHorario;
        #endregion

        public frmReporteLaboratorios()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
