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
using System.IO;

namespace Vista
{
    public partial class frmProyectoSoftwareLibre : Form
    {
        private menuPrincipal menu;
        private clConexion conexion;
        private clEntidadProyecto entidadProyecto;
        private clProyecto proyecto;
        private OpenFileDialog archivoSeleccionado;
        SqlDataReader dtrProyecto;

        public frmProyectoSoftwareLibre(menuPrincipal menu)
        {
            this.menu = menu;
            conexion = new clConexion();
            entidadProyecto = new clEntidadProyecto();
            proyecto = new clProyecto();
            archivoSeleccionado = new OpenFileDialog();
            InitializeComponent();
        }

        private void frmProyectoSoftwareLibre_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            // abre un cuadro de dialogo donde se selecionara el documento pdf o odt
            Stream myStream = null;
           
            archivoSeleccionado.InitialDirectory = "c:\\";
            archivoSeleccionado.Filter = "Pdf files (*.pdf)|*.pdf|Odt files (*.odt)|*.odt";
            archivoSeleccionado.FilterIndex = 2;
            archivoSeleccionado.RestoreDirectory = true;

            if (archivoSeleccionado.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = archivoSeleccionado.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            lbInformacion.Text = archivoSeleccionado.SafeFileName;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtIdentificador.Text != "")
            {
                entidadProyecto.mIdProyecto = Convert.ToInt32(txtIdentificador.Text);
                dtrProyecto = proyecto.mConsultarProyectos(conexion, entidadProyecto);

                if (dtrProyecto != null)
                {
                    if (dtrProyecto.Read())
                    {
                        txtNombre.Text = dtrProyecto.GetString(2);
                        rtDescripcion.Text = dtrProyecto.GetString(3);
                        cbTipo.Text = dtrProyecto.GetString(4);
                        cbEstado.Text = dtrProyecto.GetString(5);
                        //falta mostrar informacion

                        //txtIdentificador.ReadOnly = true;
                        //txtNombre.ReadOnly = true;
                        btnModificar.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("El proyecto solicitado no existe", "Proyacto no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No se ha encontrado el proyecto solicitado", "Proyecto no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ingrese una identificador de Proyecto", "Datos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
