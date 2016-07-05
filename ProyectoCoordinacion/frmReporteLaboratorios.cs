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
using System.Collections;


namespace Vista
{
    public partial class frmReporteLaboratorios : Form
    {
        #region Atributos
        clConexion conexion;
        menuPrincipal menu;
        SqlDataReader dtrHorario;
        clHorario horario;
        clEntidadHorario entidadHorario;
        private ArrayList horas;
        #endregion

        public frmReporteLaboratorios(menuPrincipal menu)
        {
            InitializeComponent();
            horario = new clHorario();
            entidadHorario = new clEntidadHorario();
            this.menu = menu;
            conexion = new clConexion();
            horas = new ArrayList();
            llenarHoras();
        }
        //Este método inicia variables timespan, para comprarlas con las horas de los cursos y así ubicarlos es en DGV
        public void llenarHoras()
        {
            for (int i = 7; i < 23; i++)
            {
                horas.Add(new TimeSpan(0, i, 0, 0));
            }
        }


        //Este método coloca los cursos en el DGV, dependiendo de su hora y día
        public void mHorarioLaboratorio()
        {
            dtrHorario = horario.mConsultarHorarioLaboratorio(conexion, entidadHorario, cbLaboratorio.Text);
            if (dtrHorario != null)
                while (dtrHorario.Read())
                {
                    int reglon = 0;
                    for (int i = Convert.ToInt32(dtrHorario.GetTimeSpan(3).Subtract(dtrHorario.GetTimeSpan(2)).Hours); i > 0; i--)
                    {
                        if (dtrHorario.GetTimeSpan(2) == (TimeSpan)horas[1])
                        {
                            reglon++;
                            dgvLaboratorio.Rows[reglon].Cells[dtrHorario.GetString(1)].Value = dtrHorario.GetString(0);
                        }
                        
                        if (dtrHorario.GetTimeSpan(2) == (TimeSpan)horas[6])
                        {
                            reglon += 6;
                            dgvLaboratorio.Rows[reglon].Cells[dtrHorario.GetString(1)].Value = dtrHorario.GetString(0);
                            reglon -= 5;
                        }                        
                        if (dtrHorario.GetTimeSpan(2) == (TimeSpan)horas[10])
                        {
                            reglon += 10;
                            dgvLaboratorio.Rows[reglon].Cells[dtrHorario.GetString(1)].Value = dtrHorario.GetString(0);
                            reglon -= 9;
                        }

                    }

                }
            else
            {
                MessageBox.Show("No hay horarios", "NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
         
        private void frmReporteLaboratorios_Load(object sender, EventArgs e)
        {
            mLlenarHorasDgv();
        }
        //Este método coloca las horas en el DGV, para posteriormente ubicar los cursos en su respectiva hora
        public void mLlenarHorasDgv()
        {
            int posicionGrid = 0;
            for (int i = 7; i < 23; i++)
            {
                posicionGrid = dgvLaboratorio.Rows.Add();
                dgvLaboratorio.Rows[posicionGrid].Cells["Hora"].Value = i + ":00";

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }

        private void cbLaboratorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvLaboratorio.Rows.Clear();
            mLlenarHorasDgv();
            mHorarioLaboratorio();
        }
    }
}
