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
using AccesoDatos;
using Entidades;
using LogicaNegocios;

namespace Vista
{
    public partial class frmReporteMiembros : Form
    {

        #region Atributos

        SqlDataReader dtrMiembro, dtrProyecto;
        clConexion conexion;
        clEntidadMiembro pEntidadMiembro;
        clMiembros miembro;
        menuPrincipal menu;
        int idProyecto;

        clProyecto clProyect;

        #endregion


        public frmReporteMiembros(menuPrincipal menu)
        {
            InitializeComponent();

            this.menu = menu;
            this.conexion = new clConexion();
            pEntidadMiembro = new clEntidadMiembro();

            miembro = new clMiembros();
            clProyect = new clProyecto();

        }


        public void llenarDataGridCursos()
        {
            int reglon = dgvMiembros.Rows.Add();
            dgvMiembros.Rows[reglon].Cells["Carnet"].Value = dtrMiembro.GetString(1);
            dgvMiembros.Rows[reglon].Cells["Nombre"].Value = dtrMiembro.GetString(2);
            dgvMiembros.Rows[reglon].Cells["apellidoUno"].Value = dtrMiembro.GetString(3);
            dgvMiembros.Rows[reglon].Cells["apellidoDos"].Value = dtrMiembro.GetString(4);
            dgvMiembros.Rows[reglon].Cells["carrera"].Value = dtrMiembro.GetString(5);
            dgvMiembros.Rows[reglon].Cells["tipo"].Value = dtrMiembro.GetString(6);
        }

        public void mConsultaGeneralMiembro() {

            dtrMiembro = miembro.mConsultarMiembros(conexion);


            if (dtrMiembro != null)
            {

                while (dtrMiembro.Read())
                {
                    llenarDataGridCursos();


                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
            menu.Show();
        }

        private void frmReporteMiembros_Load(object sender, EventArgs e)
        {
            mConsultaGeneralMiembro();
            mCargarlistViewproyecto();
        }


        //metodos del listView

        private void lvProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < lvProyecto.Items.Count; i++)
            {
                if (lvProyecto.Items[i].Selected)
                {
                    idProyecto =Convert.ToInt32( lvProyecto.Items[i].Text);

                    MessageBox.Show("");

                }


            }
        }

  
        public void mCargarlistViewproyecto()
        {
            dtrProyecto = clProyect.mConsultaGeneralProyectos(conexion);
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
    }
}
