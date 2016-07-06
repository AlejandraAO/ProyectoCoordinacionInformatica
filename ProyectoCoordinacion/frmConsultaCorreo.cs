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
    public partial class frmConsultaCorreo : Form
    {

        #region Atributos
        SqlDataReader strCorreo;
        clConexion conexion;
        clEntidadEstudiante correo;
        clEstudiante clCorreo;
        string stCarnet;
        int email;
        #endregion

        public frmConsultaCorreo(clConexion conexion,string carnet)
        {
            this.conexion = conexion;
            correo = new clEntidadEstudiante();
            clCorreo = new clEstudiante();
            stCarnet = carnet;
            InitializeComponent();
        }

        private void lvCorreos_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lvCorreos_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lvCorreos.Items.Count; i++)
            {
                if (lvCorreos.Items[i].Selected)
                {
                    email = Convert.ToInt32(lvCorreos.Items[i].Text);
                }
            }//fin del for
        }

        public int getEmail()
        {
            return this.email;
        }

        private void frmConsultaCorreo_Load(object sender, EventArgs e)
        {
            int idEstudiante;
            try
            {

                strCorreo = clCorreo.mConsultarIdEstudiante(conexion, stCarnet);

                if (strCorreo.Read())
                {

                    idEstudiante = strCorreo.GetInt32(0);


                    strCorreo = clCorreo.mConsultarCorreo(conexion, idEstudiante);

                    while (strCorreo.Read())
                    {
                        ListViewItem lista;
                        lista = lvCorreos.Items.Add(strCorreo.GetString(2));
                        lista.SubItems.Add(strCorreo.GetString(1));
                    }//fin while
                }

            }
            catch { }
        }
    }
}
