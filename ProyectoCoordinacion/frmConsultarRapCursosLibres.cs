using AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmConsultarRapCursosLibres : Form
    {
        private SqlDataReader datos;
        private String _codigo;
        public frmConsultarRapCursosLibres(SqlDataReader datos)
        {
            InitializeComponent();
            this.datos = datos;
            this._codigo = "";
        }

        public string codigo
        {
            set { this._codigo = value; }
            get { return this._codigo; }
        }

        private void frmConsultarRapCursosLibres_Load(object sender, EventArgs e)
        {
            this.cargarListView();
        }

        public void cargarListView()
        {
            if (datos != null)
            {
                while (datos.Read())
                {
                    ListViewItem items = new ListViewItem(Convert.ToString(datos.GetInt32(0)));
                    items.SubItems.Add(datos.GetString(1));
                    lvEstandar.Items.Add(items);
                }
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvEstandar_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lvEstandar.Items.Count; i++)
            {
                if (lvEstandar.Items[i].Selected)
                {
                    this.codigo = lvEstandar.Items[i].Text;

                }
            }
        }//Fin del metodo 

        private void lvEstandar_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
