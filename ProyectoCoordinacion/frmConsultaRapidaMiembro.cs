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
using Entidades;
using AccesoDatos;
using LogicaNegocios;

namespace Vista
{
    public partial class frmConsultaRapidaMiembro : Form
    {
        #region Atributos
        SqlDataReader strMiembro;
        clConexion conexion;
        clEntidadMiembro miembro;
        clMiembros clMiembros;
        public string stCodigo;
        #endregion
        public frmConsultaRapidaMiembro(clConexion conexion)
        {
            this.conexion = conexion;
            miembro = new clEntidadMiembro();
            clMiembros = new clMiembros();
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmConsultaRapidaMiembro_Load(object sender, EventArgs e)
        {
            strMiembro = clMiembros.mConsultarMiembros(conexion);
            if (strMiembro != null)
            {
                while (strMiembro.Read())
                {
                    ListViewItem lista;
                    lista = new ListViewItem(Convert.ToString(strMiembro.GetString(1)));
                    lista.SubItems.Add(strMiembro.GetString(2));
                    lvConsultaMiembro.Items.Add(lista);
                }
            }
            else
            {
                MessageBox.Show("No hay disponibles Proyectos ", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void lvConsultaMiembro_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvConsultaMiembro_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lvConsultaMiembro.Items.Count; i++)
            {
                if (lvConsultaMiembro.Items[i].Selected)
                {
                    stCodigo = lvConsultaMiembro.Items[i].Text;
                }
            }
        }
        public string getCodigo()
        {
            return (stCodigo);
        }
    }
}
