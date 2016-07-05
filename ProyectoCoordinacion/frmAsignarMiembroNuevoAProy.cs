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
using Entidades;
using System.Data.SqlClient;


namespace Vista
{
    public partial class frmAsignarMiembroAProyecto : Form
    {

        #region Atributos
        private SqlDataReader dataReaderProyecto;
        private clConexion conexion;

        private clProyecto proyecto;

        private clMiembroProyecto miembroProyecto;
        private clEntidadMiembroProyecto pEntidadMiembroProyecto;

        private string codigoProyecto;
        private Boolean selecionarProyecto;

        #endregion

        public frmAsignarMiembroAProyecto(clConexion conexion)
        {
            selecionarProyecto = false;
            this.conexion= conexion;
            proyecto = new clProyecto();

            miembroProyecto = new clMiembroProyecto();
            pEntidadMiembroProyecto = new clEntidadMiembroProyecto();

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
                    bool proyAsignado = false;
                   

                    for (int i = 0; i < lvProyectosAsignados.Items.Count; i++)
                    {
                        if (dataReaderProyecto.GetInt32(0) == Convert.ToInt32(lvProyectosAsignados.Items[i].Text))
                        {
                            proyAsignado = true;
                            break;
                           
                        }
                    }

                    if (!proyAsignado)
                    {
                        ListViewItem item = new ListViewItem(Convert.ToString(dataReaderProyecto.GetInt32(0)));
                        item.SubItems.Add(dataReaderProyecto.GetString(1));
                        lvProyectosGeneral.Items.Add(item);

                    }


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

        public void cargarProyectosAsignados(int idMiembro)
        {
            pEntidadMiembroProyecto.mIdMiembro = idMiembro;

            dataReaderProyecto = miembroProyecto.mSeleccionarProyAsigAMiemb(conexion, pEntidadMiembroProyecto);

            if (dataReaderProyecto != null)
            {
                while (dataReaderProyecto.Read())
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(dataReaderProyecto.GetInt32(0)));
                    item.SubItems.Add(dataReaderProyecto.GetString(1));
                    lvProyectosAsignados.Items.Add(item);

                  
                        

                }
            }
        }
        public void DescartarProyectos(int idMiembro)
        {
            
            //Extraemos los proy asignados antes de la modificacion para
            //compararlos con los que se encuentran actualmente en el lv
            bool proyElim=true;
            pEntidadMiembroProyecto.mIdMiembro = idMiembro;

            dataReaderProyecto = miembroProyecto.mSeleccionarProyAsigAMiemb(conexion, pEntidadMiembroProyecto);

            if (dataReaderProyecto != null)
            {

                while (dataReaderProyecto.Read())
                {
                    proyElim = true;

                    for (int i = 0; i < lvProyectosAsignados.Items.Count; i++)
                    {

                        if (Convert.ToInt32(lvProyectosAsignados.Items[i].Text) == dataReaderProyecto.GetInt32(0))
                        {
                            proyElim = false;
                            break;
                        }
                    }

                    if (proyElim)
                    {
                     pEntidadMiembroProyecto.mIdProyecto = dataReaderProyecto.GetInt32(0);
                     miembroProyecto.mEliminar(conexion, pEntidadMiembroProyecto);



                    }
                }
            }

        }

        public void asignarNuevosProyectos(int idMiembro)
        {
           
            pEntidadMiembroProyecto.mIdMiembro = idMiembro;

            for (int i = 0; i < lvProyectosAsignados.Items.Count; i++)
            {

                bool asignarProy = true;

                dataReaderProyecto = miembroProyecto.mSeleccionarProyAsigAMiemb(conexion, pEntidadMiembroProyecto);

                if (dataReaderProyecto != null)
                {

                    while (dataReaderProyecto.Read())
                    {
                        if (Convert.ToInt32(lvProyectosAsignados.Items[i].Text) == dataReaderProyecto.GetInt32(0))
                        {
                            asignarProy = false;
                            break;
                        }
                    }

                    if (asignarProy)
                    {
                        pEntidadMiembroProyecto.mIdProyecto = Convert.ToInt32(lvProyectosAsignados.Items[i].Text);

                        miembroProyecto.mInsertarMiembroProyecto(conexion, pEntidadMiembroProyecto);

                        break;
                    }
                }

               
            }
        }

        public void modificarProyectosAsignados(int idMiembro)
        {
            //Descartar proyectos
            DescartarProyectos( idMiembro);

            //Asignar Proyecto
            asignarNuevosProyectos(idMiembro);





        }

    }
}
