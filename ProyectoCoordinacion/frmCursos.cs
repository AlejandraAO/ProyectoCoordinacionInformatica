using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AccesoDatos;
using Entidades;
using LogicaNegocios;

namespace Vista
{
    public partial class frmCursos : Form
    {
        private menuPrincipal menu;
        private clConexion conexion;
        private clEntidadCurso entidadCurso;
        private clCurso curso;
        private OpenFileDialog archivoSeleccionado;

        public frmCursos(menuPrincipal menuPrincipal)
        {
            InitializeComponent();
            this.menu = menuPrincipal;
            conexion = new clConexion();
            entidadCurso = new clEntidadCurso();
            curso = new clCurso();
            archivoSeleccionado = new OpenFileDialog();
        }

        private void frmCursos_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
            menu.Show();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            //OpenFileDialog archivoSeleccionado = new OpenFileDialog();

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
                            lbNombrePrograma.Text = archivoSeleccionado.SafeFileName;                                                                                                                                        
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (mVerificarDatosNecesarios())
            {
                conexion.codigo = "123";
                conexion.clave = "123";

                //Se asignan los valores a la entidad curso
                entidadCurso.mSiglaCurso = txtSigla.Text;
                entidadCurso.mNombreCurso = txtNombre.Text;
                entidadCurso.mLugarCurso = txtLugar.Text;
                entidadCurso.mCicloCurso = txtCiclo.Text;
                entidadCurso.mCreditosCurso = Convert.ToInt32(txtCreditos.Text);
                entidadCurso.mProgramaCurso = archivoSeleccionado.FileName;
                entidadCurso.mEstadoCurso = cbEstado.Text;
                entidadCurso.mTotalDeHorasCurso = Convert.ToInt32(txtTotalHoras.Text);
                entidadCurso.mModalidadCurso = txtModalidad.Text;

                //Se verifica que se haya insertado correctamente
                if (curso.mInsertarCurso(conexion, entidadCurso))
                {
                    MessageBox.Show("Se ha insertado el curso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mLimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No pudo insertar el curso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Datos insuficientes para agregar un curso","Favor completar campos",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        public Boolean mVerificarDatosNecesarios()
        {
            if((txtSigla.Text!="") & (txtNombre.Text!="")& (txtLugar.Text!="")& (txtCiclo.Text!="")&(txtCreditos.Text!="")& (cbEstado.Text != "") & (txtTotalHoras.Text != "")& (txtModalidad.Text != "") & (lbNombrePrograma.Text != ""))
            {
                return true;
            }
            return false;
        }

        public void mLimpiarCampos()
        {
            txtSigla.Text = "";
            txtNombre.Text = "";
            txtLugar.Text = "";
            txtCiclo.Text = "";
            txtCreditos.Text = "";
            cbEstado.Text = "";
            txtTotalHoras.Text = "";
            txtModalidad.Text = "";
            lbNombrePrograma.Text = "";
        }
    }
}
