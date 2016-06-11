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
    public partial class frmHorarioCurso : Form
    {
        private menuPrincipal menu;

        public frmHorarioCurso(menuPrincipal menuPrincipal)
        {
           this. menu =  menuPrincipal;
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }



       /*  if (mVerificarDatosNecesarios())
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
    if ((.Text != "") & (txtNombre.Text != "") & (txtLugar.Text != "") & (txtCiclo.Text != "") & (txtCreditos.Text != "") & (cbEstado.Text != "") & (txtTotalHoras.Text != "") & (txtModalidad.Text != "") & (lbNombrePrograma.Text != ""))
    {
        return true;
    }
    return false;
}

    public void mLimpiarCampos()
    {
        txtCupoMinimo.Text = "";
        txtNombre.Text = "";
        txtLugar.Text = "";
        txtCiclo.Text = "";
        txtCreditos.Text = "";
        cbEstado.Text = "";
        txtTotalHoras.Text = "";
        txtModalidad.Text = "";
        lbNombrePrograma.Text = "";
    }*/

    }
}
