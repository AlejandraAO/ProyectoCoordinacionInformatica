using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocios;
using Entidades;
using AccesoDatos;
using System.Data.SqlClient;

namespace Vista
{
    public partial class frmGrupoCurso : Form
    {

        menuPrincipal menu;
        frmAcceso frmAcceso;
        SqlDataReader strSentencia;
        clGrupoCurso clGrupoCurso;
        clEntidadGrupoCurso clEntidadGrupoCurso;
        clConexion conexion;
        Object objeto;

        public frmGrupoCurso()
        {
            clGrupoCurso = new clGrupoCurso();
            clEntidadGrupoCurso = new clEntidadGrupoCurso();
            conexion = new clConexion();
            frmAcceso = new frmAcceso();
            menu = new menuPrincipal(frmAcceso);
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultarCurso consultaCurso = new frmConsultarCurso(menu);
            consultaCurso.Show();

           /* if (consultaCurso.get() != "")
            {
                usuario.setCodigo(consulta.getCodigo());
                txtCodigo.Text = consulta.getCodigo();
                mConsultaCodigo();
            }*/

        }
        
        private void frmGrupoCurso_Load(object sender, EventArgs e)
        {
            txtIdGrupo.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            mAgregarGrupo();
        }
        public void mLimpiarCampos()
        {
            txtIdGrupo.Text = "";
            txtNumeroGrupo.Text = "";
            txtCupoMaximo.Text = "";
            txtCupoMinimo.Text = "";
            txtCupoActual.Text = "";
        }

        public Boolean mVerificarDatos()
        {
            if ((txtNumeroGrupo.Text != "") & (txtIdGrupo.Text != "") & (txtCupoMinimo.Text != "") & (txtCupoMaximo.Text != "") & (txtCupoActual.Text != ""))
            {
                return true;
            }
            return false;
        }


      

        public void mModificarGrupo()
        {


            if (mVerificarDatos() == true)
            {

                conexion.codigo = "123";
                conexion.clave = "123";
                clEntidadGrupoCurso.getsetIdGrupo = Convert.ToInt32(txtIdGrupo.Text);
                clEntidadGrupoCurso.getSetNumeroGrup = Convert.ToInt32(txtNumeroGrupo.Text);
                clEntidadGrupoCurso.getSetCupoMaximo = Convert.ToInt32(txtCupoMaximo.Text);
                clEntidadGrupoCurso.getSetCupoMinimo = Convert.ToInt32(txtCupoMinimo.Text);
                clEntidadGrupoCurso.getSetCupoActual = Convert.ToInt32(txtCupoActual.Text);

                if (clGrupoCurso.mModificarGrupoCurso(conexion, clEntidadGrupoCurso))
                {
                    MessageBox.Show("Se ha modificado el grupo", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se ha podido modificar el grupo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Favor llenar todos los campos", "Datos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }



        }


      
              public void mAgregarGrupo()
        {
            if (mVerificarDatos() == true)
            {

                conexion.codigo = "123";
                conexion.clave = "123";

                clEntidadGrupoCurso.getSetIdCurso = Convert.ToInt32(txtIdGrupo.Text);
                clEntidadGrupoCurso.getSetNumeroGrup = Convert.ToInt32(txtNumeroGrupo.Text);
                clEntidadGrupoCurso.getSetCupoMaximo = Convert.ToInt32(txtCupoMaximo.Text);
                clEntidadGrupoCurso.getSetCupoMinimo = Convert.ToInt32(txtCupoMinimo.Text);
                clEntidadGrupoCurso.getSetCupoActual = Convert.ToInt32(txtCupoActual.Text);


                if (clGrupoCurso.mInsertarGrupo(conexion, clEntidadGrupoCurso) == true)
                {

                    MessageBox.Show("Se ha insertado el grupo", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mLimpiarCampos();
                }

            }
            else
            {
                MessageBox.Show("No pudo insertar el grupo", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            mAgregarGrupo();
            btnModificar.Enabled = true;
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            mModificarGrupo();  
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            frmConsultarCurso consultarCurso = new frmConsultarCurso(objeto);
            consultarCurso.Show();


            if (consultarCurso.mIdCurso() != "")
            {
                clEntidadGrupoCurso.getSetIdCurso=Convert.ToInt32(consultarCurso.mIdCurso());
                txtIdGrupo.Text = consultarCurso.mIdCurso();
                mConsultaCodigo();
            }

        }

        public void mConsultaCodigo()
        {
            strSentencia = clGrupoCurso.mConsultaCodigo(conexion, clEntidadGrupoCurso);
            if (strSentencia != null)
            {
                if (strSentencia.Read())//si existe
                {
                    this.txtIdGrupo.Text = strSentencia.GetString(1);
                }//Fin del if si existe

            }//Fin del if dtrEstudiante!=null
        }
    }
}
