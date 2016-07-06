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
    public partial class frmConsultaTelefono : Form
    {

        #region Atributos
        SqlDataReader strTelefono;
        clConexion conexion;
        clEntidadEstudiante telefono;
        clEstudiante clTelefono;
        string stCarnet;
        int numTelefono;
        #endregion

        public frmConsultaTelefono(clConexion conexion, string carnet)
        {
            this.conexion = conexion;
            telefono = new clEntidadEstudiante();
            clTelefono = new clEstudiante();
            stCarnet = carnet;
            InitializeComponent();
        }

        private void frmConsultaTelefono_Load(object sender, EventArgs e)
        {
            int idEstudiante;
            try { 

            strTelefono = clTelefono.mConsultarIdEstudiante(conexion,stCarnet);

            if (strTelefono.Read()) {

                idEstudiante = strTelefono.GetInt32(0);

                
                    strTelefono = clTelefono.mConsultarTelefono(conexion, idEstudiante);

                    while (strTelefono.Read())
                    {
                        ListViewItem lista;
                        lista = lvTelefonos.Items.Add(strTelefono.GetString(2));
                        lista.SubItems.Add(strTelefono.GetString(1));
                    }//fin while
                }
                
            }
            catch { }
        }

        private void lvTelefonos_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lvTelefonos.Items.Count; i++)
            {
                if (lvTelefonos.Items[i].Selected)
                {
                    numTelefono = Convert.ToInt32(lvTelefonos.Items[i].Text);
                }
            }//fin del for
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lvTelefonos_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        public int getNumTelefono()
        {
            return this.numTelefono;
        }
    }
}
