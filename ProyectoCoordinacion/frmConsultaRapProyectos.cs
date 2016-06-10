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
using LogicaNegocios;
using System.Data.SqlClient;

namespace Vista
{
    public partial class frmConsultaRapProyectos : Form
    {
        #region Atributos
        private SqlDataReader dtrProyecto;
        private clConexion conexion;
        private clProyecto proyecto;
        private int codigoProyecto;
        #endregion

        public frmConsultaRapProyectos( clConexion conexion)
        {
            InitializeComponent();

            this.conexion =conexion;
            proyecto = new clProyecto();
           

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int getIdProyecto()
        {
            return (codigoProyecto);
        }

        private void lvProyectos_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lvProyecto.Items.Count; i++)
            {
                if (lvProyecto.Items[i].Selected)
                {
                    codigoProyecto = Convert.ToInt32(lvProyecto.Items[i].Text);
                }
            }
        }


        public void mCargarlistViewproyecto()
        {
            dtrProyecto = proyecto.mConsultaGeneralProyectos(conexion);
            if (dtrProyecto != null)
            {
                while (dtrProyecto.Read())
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(dtrProyecto.GetInt32(0)));
                    item.SubItems.Add(dtrProyecto.GetString(1));
                    lvProyecto.Items.Add(item);
                }
            }
        }

        private void frmConsultaRapProyectos_Load(object sender, EventArgs e)
        {
            mCargarlistViewproyecto();
        }
    }
}
