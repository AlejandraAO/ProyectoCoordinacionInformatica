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
using EntidadNegocios;
using LogicaNegocios;
using System.Data.SqlClient;

namespace Vista
{
    public partial class frmConsultaEstudiante : Form
    {

        #region Atributos
        SqlDataReader strEstudiante;
        clConexion conexion;
        clEntidadEstudiante estudiante;
        clEstudiante clEstudiante;
        string stCarnet;
        #endregion

        public frmConsultaEstudiante(clConexion conexion)
        {
            this.conexion = conexion;
            estudiante = new clEntidadEstudiante();
            clEstudiante = new clEstudiante();
            InitializeComponent();
        }

        public string getCarnet()
        {
            return stCarnet;
        }



        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmConRapEstud_Load(object sender, EventArgs e)
        {
            try { 
                strEstudiante = clEstudiante.mConsultaGeneral(conexion);
                while (strEstudiante.Read())
                {
                    ListViewItem lista;
                    lista = lvEstudiantes.Items.Add(strEstudiante.GetString(1));
                    lista.SubItems.Add(strEstudiante.GetString(2));
                }//fin while
            }catch { }
        }

        private void lvEstudiantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lvEstudiantes.Items.Count; i++)
            {
                if (lvEstudiantes.Items[i].Selected)
                {
                    stCarnet = lvEstudiantes.Items[i].Text;
                }
            }//fin del for
        }

        private void lvEstudiantes_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
