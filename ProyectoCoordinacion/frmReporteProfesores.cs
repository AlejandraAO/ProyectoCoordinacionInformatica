using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
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
        clHorario horario;
        private ArrayList horas;
        #endregion


        public frmReporteProfesores( )
        {
            
            InitializeComponent();
            this.conexion = new clConexion();
            horario = new clHorario();
            horas = new ArrayList();
        }

        private void dgvReporteProfesor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmReporteProfesores_Load(object sender, EventArgs e)
        {            
            mLlenarHorasDgv();
        }

        public void mLlenarHorasDgv()
        {
            int posicionGrid = 0;
            for (int i = 7; i < 23; i++)
            {
                posicionGrid = dgvReporteProfesor.Rows.Add();
                dgvReporteProfesor.Rows[posicionGrid].Cells["Hora"].Value = i + ":00";
                horas.Add(new TimeSpan(0, i, 0, 0));

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmDatosProfesores ventanaDatos = new frmDatosProfesores(this);
            ventanaDatos.Show();
            this.Hide();
        }

        public void mConsultaHorarioProfesor(int idProfesor)
        {
            dgvReporteProfesor.Rows.Clear();
            mLlenarHorasDgv();
            dtrHorarioProfesor = horario.mConsultarHorarioProfesor(conexion,idProfesor);
            if(dtrHorarioProfesor!=null)
                while (dtrHorarioProfesor.Read())
                {
                   
                        int reglon = 0;
                        for (int i = Convert.ToInt32(dtrHorarioProfesor.GetTimeSpan(3).Subtract(dtrHorarioProfesor.GetTimeSpan(2)).Hours); i > 0; i--)
                        {
                            if (dtrHorarioProfesor.GetTimeSpan(2) == (TimeSpan)horas[1])
                            {
                                reglon++;
                                dgvReporteProfesor.Rows[reglon].Cells[dtrHorarioProfesor.GetString(1)].Value = dtrHorarioProfesor.GetString(0);
                            }

                            if (dtrHorarioProfesor.GetTimeSpan(2) == (TimeSpan)horas[6])
                            {
                                reglon += 6;
                                dgvReporteProfesor.Rows[reglon].Cells[dtrHorarioProfesor.GetString(1)].Value = dtrHorarioProfesor.GetString(0);
                                reglon -= 5;
                            }
                            if (dtrHorarioProfesor.GetTimeSpan(2) == (TimeSpan)horas[11])
                            {
                                reglon += 11;
                                dgvReporteProfesor.Rows[reglon].Cells[dtrHorarioProfesor.GetString(1)].Value = dtrHorarioProfesor.GetString(0);
                                reglon -= 10;
                            }

                            if (dtrHorarioProfesor.GetTimeSpan(2) == (TimeSpan)horas[2])
                            {
                                reglon += 2;
                                dgvReporteProfesor.Rows[reglon].Cells[dtrHorarioProfesor.GetString(1)].Value = dtrHorarioProfesor.GetString(0);
                                reglon -= 1;
                            }

                            if (dtrHorarioProfesor.GetTimeSpan(2) == (TimeSpan)horas[3])
                            {
                                reglon += 3;
                                dgvReporteProfesor.Rows[reglon].Cells[dtrHorarioProfesor.GetString(1)].Value = dtrHorarioProfesor.GetString(0);
                                reglon -= 2;
                            }

                        if (dtrHorarioProfesor.GetTimeSpan(2) == (TimeSpan)horas[7])
                        {
                            reglon += 7;
                            dgvReporteProfesor.Rows[reglon].Cells[dtrHorarioProfesor.GetString(1)].Value = dtrHorarioProfesor.GetString(0);
                            reglon -= 6;
                        }

                        if (dtrHorarioProfesor.GetTimeSpan(2) == (TimeSpan)horas[8])
                        {
                            reglon += 8;
                            dgvReporteProfesor.Rows[reglon].Cells[dtrHorarioProfesor.GetString(1)].Value = dtrHorarioProfesor.GetString(0);
                            reglon -= 7;
                        }

                        if (dtrHorarioProfesor.GetTimeSpan(2) == (TimeSpan)horas[9])
                        {
                            reglon += 9;
                            dgvReporteProfesor.Rows[reglon].Cells[dtrHorarioProfesor.GetString(1)].Value = dtrHorarioProfesor.GetString(0);
                            reglon -= 8;
                        }

                        if (dtrHorarioProfesor.GetTimeSpan(2) == (TimeSpan)horas[10])
                        {
                            reglon += 10;
                            dgvReporteProfesor.Rows[reglon].Cells[dtrHorarioProfesor.GetString(1)].Value = dtrHorarioProfesor.GetString(0);
                            reglon -= 9;
                        }
                        if (dtrHorarioProfesor.GetTimeSpan(2) == (TimeSpan)horas[12])
                        {
                            reglon += 12;
                            dgvReporteProfesor.Rows[reglon].Cells[dtrHorarioProfesor.GetString(1)].Value = dtrHorarioProfesor.GetString(0);
                            reglon -= 11;
                        }

                        if (dtrHorarioProfesor.GetTimeSpan(2) == (TimeSpan)horas[13])
                        {
                            reglon += 13;
                            dgvReporteProfesor.Rows[reglon].Cells[dtrHorarioProfesor.GetString(1)].Value = dtrHorarioProfesor.GetString(0);
                            reglon -= 12;
                        }

                    }

                    
                }
        }
    }
}
