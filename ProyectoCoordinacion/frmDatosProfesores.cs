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

namespace ProyectoCoordinacion
{
    public partial class frmDatosProfesores : Form
    {
        #region Atributos
        private SqlDataReader dtrProfesor;
        private clConexion conexion;
        private clHorario clHorario;
        #endregion


        public frmDatosProfesores()
        {
            conexion = new clConexion();
            clHorario = new clHorario();

            InitializeComponent();
            llenarDataGridProfesores();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void llenarDataGridProfesores()
        {
            dtrProfesor = clHorario.mConsultarProfesores(conexion);
            if (dtrProfesor != null)
            {
                if (dtrProfesor.Read())
                {
                    int renglon = dgvProfesor.Rows.Add();
                    dgvProfesor.Rows[renglon].Cells["idProfesor"].Value = Convert.ToString(dtrProfesor.GetInt32(0));
                    dgvProfesor.Rows[renglon].Cells["nombre"].Value = dtrProfesor.GetString(1);
                    dgvProfesor.Rows[renglon].Cells["apellido1"].Value = dtrProfesor.GetString(2);
                    dgvProfesor.Rows[renglon].Cells["apellido2"].Value = dtrProfesor.GetString(3);
                }//fin del read
            }
        }//fin de llenarData

    }
}
