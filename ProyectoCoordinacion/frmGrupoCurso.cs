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
        clEntidadHorario clEntidadHorario;
        clConexion conexion;
        Object objeto;
        frmConsultarCurso consultarCurso;
        

        public frmGrupoCurso()
        {
            clGrupoCurso = new clGrupoCurso();
            clEntidadGrupoCurso = new clEntidadGrupoCurso();
            clEntidadHorario = new clEntidadHorario();
            conexion = new clConexion();
            consultarCurso = new frmConsultarCurso(objeto);
            frmAcceso = new frmAcceso();
            menu = new menuPrincipal(frmAcceso);
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultarCurso consultaCurso = new frmConsultarCurso(menu);
            consultaCurso.Show();
            
          if (consultaCurso.mIdCurso() != "")
            {
                clEntidadGrupoCurso.getSetIdCurso= Convert.ToInt32(consultaCurso.mIdCurso());
                txtIdGrupo.Text = consultaCurso.mIdCurso();
                mConsultaCodigo();
            }

        }

        private void mConsultarCodigo()
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
            numCupoActual.Value =0;
            numCupoMaximo.Value = 0;
            numCupoMinimo.Value = 0;
            
        }

        public Boolean mVerificarDatosHorario()
        {
            if ((txtDia.Text != "") & (txtHoraInicio.Text != "") & (txtHoraFinal.Text != ""))
            {
                return true;
            }
            return false;
        }



        public Boolean mVerificarDatosGrupo()
        {
          if ((txtNumeroGrupo.Text != "") & (txtIdGrupo.Text != "") & (numCupoMaximo.Text != "") & (numCupoMinimo.Text != "") & (numCupoActual.Text != ""))
            {
                return true;
            }
            return false;
        }


      

        public void mModificarGrupo()
        {


            if (mVerificarDatosGrupo() == true)
            {

                conexion.codigo = "123";
                conexion.clave = "123";
                clEntidadGrupoCurso.getsetIdGrupo = Convert.ToInt32(txtIdGrupo.Text);
                clEntidadGrupoCurso.getSetNumeroGrup = Convert.ToInt32(txtNumeroGrupo.Text);
                clEntidadGrupoCurso.getSetCupoMaximo = Convert.ToInt32(numCupoMaximo.Text);
                clEntidadGrupoCurso.getSetCupoMinimo = Convert.ToInt32(numCupoMinimo.Text);
                clEntidadGrupoCurso.getSetCupoActual = Convert.ToInt32(numCupoActual.Text);

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
            if (mVerificarDatosGrupo() == true)
            {

                conexion.codigo = "123";
                conexion.clave = "123";

                clEntidadGrupoCurso.getSetIdCurso = 1;
                clEntidadGrupoCurso.getSetNumeroGrup = Convert.ToInt32(txtNumeroGrupo.Text);
                clEntidadGrupoCurso.getSetCupoMaximo = Convert.ToInt32(numCupoMaximo.Text);
                clEntidadGrupoCurso.getSetCupoMinimo = Convert.ToInt32(numCupoMinimo.Text);
                clEntidadGrupoCurso.getSetCupoActual = Convert.ToInt32(numCupoActual.Text);


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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click_2(object sender, EventArgs e)
        {

            //frmConsultarCurso consultarCurso = new frmConsultarCurso(objeto);
            consultarCurso.ShowDialog();
            mConsultaCodigo();

            if (consultarCurso.seleccionCurso() == true)
            {

                if (consultarCurso.mIdCurso() != "")
                {
                    clEntidadGrupoCurso.getSetIdCurso = Convert.ToInt32(consultarCurso.mIdCurso());
                    txtIdGrupo.Text = consultarCurso.mIdCurso();
                    mConsultaCodigo();
                }
            }
        }

        private void btnAgregar_Click_2(object sender, EventArgs e)
        {
            mAgregarGrupo();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            mModificarGrupo();
        }

        //Retorna el rol o pantalla seleccionada de un listview
        public int itemSeleccion(DataGridView data) //Usar solo 1 método
        {
            for (int i = 0; i < data.RowCount; i++)
            {
                if (data.Rows[i].Selected)
                {
                    return data.Rows[i].Index;
                }
            }
            return -1;
        }


        public void mAgregarHorario()
        {
            if (mVerificarDatosHorario() == true)
            {

                conexion.codigo = "123";
                conexion.clave = "123";

                clEntidadHorario.mDia = txtDia.Text;
                clEntidadHorario.mHoraInicio = txtHoraInicio.Text;
                clEntidadHorario.mHoraSalida = txtHoraFinal.Text;


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



        private void btnAgregarHorario_Click(object sender, EventArgs e)
        {

        }
    }
}
