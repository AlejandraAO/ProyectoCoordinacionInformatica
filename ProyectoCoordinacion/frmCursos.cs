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
using System.Data.SqlClient;

namespace Vista
{
    public partial class frmCursos : Form
    {
        private menuPrincipal menu;
        private clConexion conexion;
        private clEntidadCurso entidadCurso;
        private clCurso curso;
        private OpenFileDialog archivoSeleccionado;
        SqlDataReader dtrCurso;

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
                entidadCurso.mNombrePrograma = archivoSeleccionado.SafeFileName;
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

        private void txtSigla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(Char)Keys.Enter)
            {
                if (txtSigla.Text != "")
                {
                    mConsultarPorSigla();
                }
                else
                {
                    MessageBox.Show("Ingrese una sigla", "Datos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
           
        }

        public void mConsultarPorSigla()
        {
            entidadCurso.mSiglaCurso = txtSigla.Text;
            dtrCurso = curso.mConsultaPorSigla(conexion,entidadCurso);

            if (dtrCurso!=null)
            {
                if (dtrCurso.Read())
                {
                    txtNombre.Text = dtrCurso.GetString(2);
                    txtLugar.Text = dtrCurso.GetString(3);
                    txtCiclo.Text = dtrCurso.GetString(4);
                    txtCreditos.Text = Convert.ToString(dtrCurso.GetInt32(5));

                    cbEstado.Text = dtrCurso.GetString(7);
                    txtTotalHoras.Text =Convert.ToString(dtrCurso.GetInt32(8));
                    txtModalidad.Text = dtrCurso.GetString(9);

                    txtSigla.ReadOnly = true;
                    txtNombre.ReadOnly = true;
                    btnModificar.Enabled = true;

                }
                else
                {
                    MessageBox.Show("El curso solicitado no existe", "Curso no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No se ha encontrado el curso solicitado", "Curso no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (mVerificarDatosNecesarios())
            {
                conexion.codigo = "123";
                conexion.clave = "123";

                //Se asignan los valores a la entidad curso
                //entidadCurso.mIdCurso = dtrCurso.GetInt32(0);                

                entidadCurso.mSiglaCurso = txtSigla.Text;
                entidadCurso.mNombreCurso = txtNombre.Text;
                entidadCurso.mLugarCurso = txtLugar.Text;
                entidadCurso.mCicloCurso = txtCiclo.Text;
                entidadCurso.mCreditosCurso = Convert.ToInt32(txtCreditos.Text);
                entidadCurso.mProgramaCurso = archivoSeleccionado.FileName;
                entidadCurso.mEstadoCurso = cbEstado.Text;
                entidadCurso.mTotalDeHorasCurso = Convert.ToInt32(txtTotalHoras.Text);
                entidadCurso.mModalidadCurso = txtModalidad.Text;

                
                if(curso.mModificarCurso(conexion, entidadCurso))
                {
                    MessageBox.Show("Se ha modificado el curso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se ha podido modificar el curso", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Favor llenar todos los campos", "Datos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
