using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using LogicaNegocios;
using AccesoDatos;
using System.Data.SqlClient;

namespace Vista
{
    public partial class frmConsultarProyectos : Form
    {
        #region Atributos
        SqlDataReader strProyecto;
        clConexion conexion;
        clEntidadProyecto proyecto;
        clProyecto clProyecto;
        public string stCodigo;
        #endregion
        public frmConsultarProyectos(clConexion conexion)
        {
            this.conexion = conexion;
            proyecto = new clEntidadProyecto();
            clProyecto = new clProyecto();
            InitializeComponent();
        }

        public string getCodigo()
        {
            return (stCodigo);
        }

        private void frmConsultarProyectos_Load(object sender, EventArgs e)
        {
            strProyecto = clProyecto.mConsultaGeneralProyectos(conexion);
            if (strProyecto != null)
            {
                while (strProyecto.Read())
                {
                    ListViewItem lista;
                    lista = lvProyectos.Items.Add(strProyecto.GetString(0));
                }
            }
            else
            {
                MessageBox.Show("No hay disponibles Proyectos ", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       

        private void lvProyectos_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lvProyectos.Items.Count; i++)
            {
                if (lvProyectos.Items[i].Selected)
                {
                    stCodigo = lvProyectos.Items[i].Text;
                }
            }
        }

        private void lvProyectos_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
