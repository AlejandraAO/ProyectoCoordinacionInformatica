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
        private string codigoProyecto;
        private Boolean selecionarProyecto;
        
        #endregion

        public frmConsultaRapProyecto(clConexion conexion)
        {
            selecionarProyecto = false;
            this.conexion= conexion;
            proyecto = new clProyecto();
            InitializeComponent();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {

        
            this.Hide();
        }

        public string mIdProyecto
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
                    lvProyectosGeneral.Items.Add(item);
                }
            }
        }

        private void frmConsultaRapProyecto_Load(object sender, EventArgs e)
        {

            if (!selecionarProyecto) {

                mCargarlistViewproyecto();
                selecionarProyecto =true;
            }
           
        }

        private void lvProyecto_DoubleClick(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvProyectosGeneral.Items.Count; i++)
             {
                 if (lvProyectosGeneral.Items[i].Selected)
                 {

                    ListViewItem itm = new ListViewItem(lvProyectosGeneral.Items[i].Text);
                    itm.SubItems.Add(lvProyectosGeneral.Items[i].SubItems[1].Text);
                    lvProyectosAsignados.Items.Add(itm);

                    lvProyectosGeneral.Items[i].Remove();
                    this.btnAsignarProyecto.Enabled = false;
                }


             }
          
        }




        private void btnRetitarProyecto_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < lvProyectosAsignados.Items.Count; i++)
            {
                if (lvProyectosAsignados.Items[i].Selected)
                {
                    
                    ListViewItem itm = new ListViewItem(lvProyectosAsignados.Items[i].Text);
                    itm.SubItems.Add(lvProyectosAsignados.Items[i].SubItems[1].Text);
                    lvProyectosGeneral.Items.Add(itm);

                    lvProyectosAsignados.Items[i].Remove();
                    this.btnRetitarProyecto.Enabled = false;
                }


            }
        }


        private void lvProyectosGeneral_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnAsignarProyecto.Enabled = true;
        }

        private void lvProyectosAsignados_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnRetitarProyecto.Enabled = true;
        }

        public string getIdsProyecto()
        {

            if (lvProyectosAsignados.Items.Count != 0)
            {

                string idProyecto = lvProyectosAsignados.Items[0].Text;
                lvProyectosAsignados.Items[0].Remove();
                return idProyecto;
            }

            return null;
        }

        public int getCantidadProyectosAsignados()
        {
          
                return  this.lvProyectosAsignados.Items.Count;

           
        }

        public Boolean verificarListViewVacio()
        {
            if (this.lvProyectosAsignados.Items.Count==0)
            {
                return false;

            }
            return true;
        }

        public void limpiarLVProyAsignados()
        {

            this.lvProyectosAsignados.Items.Clear();
            this.lvProyectosGeneral.Items.Clear();
            this.selecionarProyecto = false;
        }

        public void listaProyectoAsignadosCarnet(int idMiembro)
        {
            dataReaderProyecto = proyecto.mSelecccionarMiembroProyecto(conexion, idMiembro);
            if (dataReaderProyecto!=null)
            {
                if (dataReaderProyecto.Read())
                {
                    ListViewItem lista = new ListViewItem();
                    lista.SubItems.Add(Convert.ToString(dataReaderProyecto.GetInt32(0)));
                    lista.SubItems.Add(Convert.ToString(dataReaderProyecto.GetInt32(1)));
                    lvProyectosAsignados.Items.Add(lista);
                }
            }
        }

    }
}
