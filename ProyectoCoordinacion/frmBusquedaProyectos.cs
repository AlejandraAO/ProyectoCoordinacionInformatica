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
    public partial class frmBusquedaProyectos: Form
    {
        clConexion conexion;
        SqlDataReader dtrProfesor;
        SqlDataReader dtrProyectos;
        clProfesor logicaProfesor;
        clProyectosGeneral logicaProyecto;
        public frmBusquedaProyectos(clConexion conexion)
        {
            InitializeComponent();
            this.conexion = conexion;
            logicaProfesor = new clProfesor();
            this.logicaProyecto = new clProyectosGeneral();
        }

        private void frmBusquedaProyectos_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            this.cargarCombo();
        }

        public void cargarCombo() {
            dtrProfesor = logicaProfesor.mLlenarCombo(this.conexion);           
            if (dtrProfesor != null)
            {
                while (dtrProfesor.Read())
                {
                    String indentificacion = dtrProfesor.GetString(0).Trim();
                    cbIndentifica.Items.Add(indentificacion);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.limpiarFrame();
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.lvProyecto.Items.Clear();
            if (cbIndentifica.Text == "")
            {
                this.mensajeAdvertencia("Dede Seleccionar la Identificación");
            }
            else if (rbCoordinador.Checked == false && rbResponsable.Checked == false && rbGestionEstudiante.Checked == false && rbTrabajador.Checked == false)
            {
                this.mensajeAdvertencia("Dede Seleccionar el Filtro");
            }
            else
            {
                if (rbCoordinador.Checked == true)
                {
                    this.llenarLvCoordina();
                }
                else if (rbResponsable.Checked == true)
                {
                    this.llenarLvResponsable();
                }
                else if (rbGestionEstudiante.Checked == true)
                {
                    this.llenarLvGestionEstudiante();
                }
                else
                {
                    this.llenarLvTrabaja();
                }
            }// fin del else.
        }// fin del evento del boton buscar.


        public void llenarLvCoordina()
        {
            dtrProyectos = logicaProyecto.getProyectosCoordinador(conexion, this.cbIndentifica.Text.Trim());
            if (dtrProyectos != null) {
                while (dtrProyectos.Read())
                {
                    ListViewItem lista;
                    lista = lvProyecto.Items.Add(dtrProyectos.GetString(0));
                    lista.SubItems.Add(dtrProyectos.GetString(1));
                    lista.SubItems.Add(dtrProyectos.GetString(2));
                    lista.SubItems.Add(dtrProyectos.GetString(3));
                    lista.SubItems.Add("NULL");
                }
            }
            
        }//fin del metodo.

        public void llenarLvResponsable()
        {
            dtrProyectos = logicaProyecto.getProyectosResponsable(conexion, this.cbIndentifica.Text.Trim());
            if (dtrProyectos != null)
            {
                while (dtrProyectos.Read())
                {
                    ListViewItem lista;
                    lista = lvProyecto.Items.Add(dtrProyectos.GetString(0));
                    lista.SubItems.Add(dtrProyectos.GetString(1));
                    lista.SubItems.Add(dtrProyectos.GetString(2));
                    lista.SubItems.Add(dtrProyectos.GetString(3));
                    lista.SubItems.Add("NULL");
                }
            }
            
        
        }//fin del metodo.

        public void llenarLvGestionEstudiante()
        {
            dtrProyectos = logicaProyecto.getProyectosConEstudiantes(conexion, this.cbIndentifica.Text.Trim());
            if (dtrProyectos != null)
            {
                while (dtrProyectos.Read())
                {
                    ListViewItem lista;
                    lista = lvProyecto.Items.Add(dtrProyectos.GetString(0));
                    lista.SubItems.Add(dtrProyectos.GetString(1));
                    lista.SubItems.Add(dtrProyectos.GetString(2));
                    lista.SubItems.Add(dtrProyectos.GetString(3));
                    lista.SubItems.Add(Convert.ToString(dtrProyectos.GetInt32(4)));
                    
                }
            }
           

        }//fin del metodo.

        public void llenarLvTrabaja()
        {
            dtrProyectos = logicaProyecto.getProyectosComoTrabajador(conexion, this.cbIndentifica.Text.Trim());
            if (dtrProyectos != null)
            {
                while (dtrProyectos.Read())
                {
                    ListViewItem lista;
                    lista = lvProyecto.Items.Add(dtrProyectos.GetString(0));
                    lista.SubItems.Add(dtrProyectos.GetString(1));
                    lista.SubItems.Add(dtrProyectos.GetString(2));
                    lista.SubItems.Add(dtrProyectos.GetString(3));
                    lista.SubItems.Add(Convert.ToString(dtrProyectos.GetInt32(4)));
                }
            }
            

        }//fin del metodo.


        public void limpiarFrame()
        {
            
            this.rbCoordinador.Checked = false;
            this.rbGestionEstudiante.Checked = false;
            this.rbResponsable.Checked = false;
            this.rbTrabajador.Checked = false;
            this.lvProyecto.Items.Clear();
        }

        public void mensajeAdvertencia(String mensaje)
        {
            MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }// fin del metodo de peligro

        
    }
}
