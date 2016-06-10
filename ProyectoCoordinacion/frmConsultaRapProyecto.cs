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
    public partial class frmConsultaRapProyecto : Form
    {

        #region Atributos
        private SqlDataReader dataReaderProyecto;
        private clConexion conexion;
        private clProyecto proyecto;
        private int codigoProyecto;
        #endregion

        public frmConsultaRapProyecto(clConexion conexion)
        {

            this.conexion= conexion;
            proyecto = new clProyecto();
            InitializeComponent();
        }

        private void lvEstudiante_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lvProyecto.Items.Count; i++)
            {
                if (lvProyecto.Items[i].Selected)
                {
                    codigoProyecto = Convert.ToInt32(lvProyecto.Items[i].Text);
                }
            }
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

        public void mCargarlistViewproyecto()
        {
            dataReaderProyecto = proyecto.mConsultaGeneralProyectos(conexion);
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

        private void frmConsultaRapProyecto_Load(object sender, EventArgs e)
        {
            mCargarlistViewproyecto();
        }

        private void lvProyecto_DoubleClick(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
