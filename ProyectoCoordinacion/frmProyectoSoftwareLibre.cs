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
            frmConsultarProyectos consultaUsuario = new frmConsultarProyectos(conexion);
            consultaUsuario.ShowDialog();

            if (consultaUsuario.getCodigo() != "")
            {
                //entidadProyecto.mIdProyecto=Convert.ToInt32(consultaUsuario.getCodigo());
                this.txtIdentificador.Text = consultaUsuario.getCodigo();
                mConsultarProyectos();
            }

        }

        public void mConsultarProyectos()
        {
            
                entidadProyecto.mIdProyecto = Convert.ToInt32(txtIdentificador.Text);
                dtrProyecto = proyecto.mConsultarProyectos(conexion, entidadProyecto);

                if (dtrProyecto != null)
                {
                    if (dtrProyecto.Read())
                    {
                        txtNombre.Text = dtrProyecto.GetString(1);
                        rtDescripcion.Text = dtrProyecto.GetString(2);
                        cbTipo.Text = dtrProyecto.GetString(3);
                        cbEstado.Text = dtrProyecto.GetString(4);
                        lbInformacion.Text = dtrProyecto.GetString(6);
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (mVerificarDatosNecesarios())
            {
                //conexion.codigo = "123";
                //conexion.clave = "123";

                //Se asignan los valores a la entidad curso
                //entidadProyecto.mIdProyecto = Convert.ToInt32(txtIdentificador.Text);
                entidadProyecto.mNombre = txtNombre.Text;
                entidadProyecto.mDescripcion = rtDescripcion.Text;
                entidadProyecto.mEstado = cbEstado.Text;
                entidadProyecto.mTipo = cbTipo.Text;
                entidadProyecto.mInformacioProyecto = archivoSeleccionado.FileName;
                entidadProyecto.mNombreDocumento = archivoSeleccionado.SafeFileName;
                
                //Se verifica que se haya insertado correctamente
                if (proyecto.mInsertarProyecto(conexion, entidadProyecto))
                {
                    MessageBox.Show("Se ha insertado el Proyecto", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mLimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No pudo insertar el Proyecto", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Datos insuficientes para agregar un Proyecto", "Favor completar campos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (mVerificarDatosNecesarios())
            {
               // conexion.codigo = "123";
                //conexion.clave = "123";

                //Se asignan los valores a la entidad proyecto


                entidadProyecto.mIdProyecto = Convert.ToInt32(txtIdentificador.Text);
                entidadProyecto.mNombre = txtNombre.Text;
                entidadProyecto.mDescripcion = rtDescripcion.Text;
                entidadProyecto.mEstado = cbEstado.Text;
                entidadProyecto.mTipo = cbTipo.Text;
                entidadProyecto.mInformacioProyecto = archivoSeleccionado.FileName;
              //Mae le comenté esto xq daba error y no dejaba ejecutar

                if (proyecto.mModificarProyecto(conexion, entidadProyecto))
                {
                    MessageBox.Show("Se ha modificado el Proyecto", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se ha podido modificar el Proyecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Favor llenar todos los campos", "Datos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        

    }

        public Boolean mVerificarDatosNecesarios()
        {
            if ((txtNombre.Text != "")   & (rtDescripcion.Text != "") & (cbEstado.Text != "") & (cbTipo.Text != "") & (lbInformacion.Text != ""))
            {
                return true;
            }
            return false;
        }

        public void mLimpiarCampos()
        {
            txtIdentificador.Text = "";
            txtNombre.Text = "";
            cbEstado.Text = "";
            cbTipo.Text = "";
            rtDescripcion.Text = "";
            lbInformacion.Text = "";
        }
    }
}
