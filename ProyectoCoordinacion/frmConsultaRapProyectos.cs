using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LogicaNegocios;
using Entidades;
using AccesoDatos;

namespace Vista
{
    public partial class frmConsultaRapProyectos : Form
    {
        #region Atrbutos
        private clConexion conexion;
        private SqlDataReader dataReaderProyecto;
        private clProyecto miembros;
        private int codigoProyecto;
        #endregion
        public frmConsultaRapProyectos(clConexion conexion)
        {
            this.conexion = conexion;
            miembros = new clProyecto();
            InitializeComponent();
        }

        private void frmConsultaRapProyectos_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int mIdProyecto
        {
            get { return codigoProyecto; }
            set { codigoProyecto = value; }
        }

        private void lvProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lvProyecto.Items.Count; i++)
            {
                if (lvProyecto.Items[i].Selected)
                {
                    codigoProyecto = Convert.ToInt32(lvProyecto.Items[i].Text);
                }
            }
        }

        private void lvProyecto_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
        public void mCargarlistViewproyecto()
        {
            dataReaderProyecto = miembros.mConsultaGeneralProyectos(conexion);
            if (dataReaderProyecto != null)
            {
                while (dataReaderProyecto.Read())
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(dataReaderProyecto.GetInt32(0)));
                    item.SubItems.Add(dataReaderProyecto.GetString(1));
                    lvProyecto.Items.Add(item);
                }
            }
        }
    }
}
