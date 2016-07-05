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
    public partial class frmDatosProfesores : Form
    {
        #region Atributos
        private SqlDataReader dtrProfesor;
        private clConexion conexion;
        private clHorario clHorario;
        private int enviarIdProfesor;
        private frmReporteProfesores reporteProfesores;
        #endregion


        public frmDatosProfesores(frmReporteProfesores reporte)
        {
            conexion = new clConexion();
            clHorario = new clHorario();
            this.reporteProfesores = reporte;
            InitializeComponent();
            llenarDataGridProfesores();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void llenarDataGridProfesores()
        {
            dtrProfesor = clHorario.mConsultarProfesores(conexion);
            if (dtrProfesor != null)
            {
                while (dtrProfesor.Read())
                {
                    int renglon = dgvProfesor.Rows.Add();
                    dgvProfesor.Rows[renglon].Cells["idProfesor"].Value = Convert.ToString(dtrProfesor.GetInt32(0));
                    dgvProfesor.Rows[renglon].Cells["nombre"].Value = dtrProfesor.GetString(1);
                    dgvProfesor.Rows[renglon].Cells["apellido1"].Value = dtrProfesor.GetString(2);
                    dgvProfesor.Rows[renglon].Cells["apellido2"].Value = dtrProfesor.GetString(3);
                }//fin del read
            }
        }//fin de llenarData

        private void frmDatosProfesores_Load(object sender, EventArgs e)
        {

        }

        public int mEnviarIdProfesor
        {
            set { this.enviarIdProfesor = value; }
            get { return this.enviarIdProfesor; }
        }

        private void dgvProfesor_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            mEnviarIdProfesor = Convert.ToInt32( dgvProfesor.SelectedRows[0].Cells["idProfesor"].Value);
            reporteProfesores.mEstablecerNombreProfBusqueda(Convert.ToString(dgvProfesor.SelectedRows[0].Cells["nombre"].Value)+ Convert.ToString(dgvProfesor.SelectedRows[0].Cells["apellido1"].Value));
            this.Hide();
            reporteProfesores.mConsultaHorarioProfesor(mEnviarIdProfesor);
            reporteProfesores.Show();
        }
    }
}
