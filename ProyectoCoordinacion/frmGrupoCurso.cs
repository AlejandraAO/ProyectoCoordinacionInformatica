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
using System.Collections;


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
        clHorario clHorario;
        clConexion conexion;
        private ArrayList dia;
        private ArrayList horas;
        Object objeto;
        private String stHorario;
        frmConsultarCurso consultarCurso;


        public frmGrupoCurso()
        {
            clGrupoCurso = new clGrupoCurso();
            clEntidadGrupoCurso = new clEntidadGrupoCurso();
            clEntidadHorario = new clEntidadHorario();
            conexion = new clConexion();
            clHorario = new clHorario();
            consultarCurso = new frmConsultarCurso(objeto);
            frmAcceso = new frmAcceso();
            horas = new ArrayList();
            menu = new menuPrincipal(frmAcceso);
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultarCurso consultaCurso = new frmConsultarCurso(menu);
            consultaCurso.Show();

            if (consultaCurso.mIdCurso() != "")
            {
                clEntidadGrupoCurso.getSetIdCurso = Convert.ToInt32(consultaCurso.mIdCurso());
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
            llenarHorasFinal();
            llenarHorasInicio();
            llenarDia();
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
            numCupoActual.Value = 0;
            numCupoMaximo.Value = 0;
            numCupoMinimo.Value = 0;
            cboDia.Text = "ninguno";
            cboHoraFinal.Text = "00:00";
            cboHoraFinal.Text = "00:00";
            txtIdHorario.Text = "";

        }

        public Boolean mVerificarDatosHorario()
        {
            if ((cboDia.Text != "") & (cboHoraFinal.Text != "") & (cboHoraFinal.Text != ""))
            {
                return true;
            }
            return false;
        }



        public Boolean mVerificarDatosGrupo()
        {
            if ((txtNumeroGrupo.Text != "")  & (numCupoMaximo.Text != "") & (numCupoMinimo.Text != "") & (numCupoActual.Text != ""))
            {
                return true;
            }
            return false;
        }

        
        public void llenarHorasInicio()
        {
            for (int i = 7; i < 19; i++)
            {

                cboHoraInicio.Items.Add(i + ":00");

            }
           
        }

        public void llenarHorasFinal()
        {
            for (int i = 9; i < 21; i++)
            {
                cboHoraFinal.Items.Add(i + ":00");

            }
            
        }

        public void llenarDia()
        {
            cboDia.Items.Add("L");
            cboDia.Items.Add("K");
            cboDia.Items.Add("M");
            cboDia.Items.Add("J");
            cboDia.Items.Add("V");
            cboDia.Items.Add("S");
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

     
 

        private void btnAgregar_Click_2(object sender, EventArgs e)
        {
            mAgregarGrupo();
            btnModifcarHorario.Enabled = true;
            mAgregarHorario();
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

                clEntidadHorario.mDia = cboDia.Text;
                clEntidadHorario.mHoraInicio = cboHoraInicio.Text;
                clEntidadHorario.mHoraSalida = cboHoraFinal.Text;

                if (cboDia.Text != clEntidadHorario.mDia && cboHoraInicio.Text != clEntidadHorario.mHoraInicio && cboHoraFinal.Text != clEntidadHorario.mHoraSalida)
                {
                    if (clGrupoCurso.mInsertarGrupo(conexion, clEntidadGrupoCurso) == true)
                    {

                        MessageBox.Show("Se ha insertado el horario", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mLimpiarCampos();

                    }
                }
                else
                {
                    MessageBox.Show("Ya existe un curso con ese horario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else
            {
                MessageBox.Show("No pudo insertar el grupo", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }



        public void mModificarHorario()
        {


            if (mVerificarDatosHorario() == true)
            {
                for (int i = 0; i < lvHorarios.Items.Count; i++)

                    if (lvHorarios.Items[i].Selected)

                conexion.codigo = "123";
                conexion.clave = "123";

                clEntidadHorario.mDia = cboDia.Text;
                clEntidadHorario.mHoraInicio = cboHoraInicio.Text;
                clEntidadHorario.mHoraSalida = cboHoraFinal.Text;

                if (clHorario.mModificarHorario(conexion, clEntidadHorario))
                {
                    MessageBox.Show("Se ha modificado el horario", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se ha podido modificar el horario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Favor llenar todos los campos", "Datos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }



        }

        private void btnModifcarHorario_Click(object sender, EventArgs e)
        {
            mModificarHorario();
        }

        private void btnAgregarTabla_Click(object sender, EventArgs e)
        {
            mAgregarDatosLista();
        }

     


        public void mAgregarDatosLista()
        {

            strSentencia = clHorario.mConsultarHorarios(conexion, clEntidadHorario);

            if (mVerificarDatosHorario() == true)
            {
                int posicion = lvHorarios.Items.Count;

                ListViewItem item = new ListViewItem();
                item.SubItems.Add(txtIdHorario.Text);
                item.SubItems.Add(cboDia.Text);
                item.SubItems.Add(cboHoraInicio.Text);
                item.SubItems.Add(cboHoraFinal.Text);
                lvHorarios.Items.Add(item);



            }

        }

   
       



        private void btnConsultar_Click_2(object sender, EventArgs e)
        { 
            frmConsultarCurso consultarCurso = new frmConsultarCurso(this);
            consultarCurso.Show();

         //   if (consultarCurso.seleccionCurso() == true)
           // {

                if (consultarCurso.mIdCurso() != "")
                {
                    clEntidadGrupoCurso.getSetIdCurso = Convert.ToInt32(consultarCurso.mIdCurso());
                    txtIdGrupo.Text = consultarCurso.mIdCurso();
                    mConsultaCodigo();
                }
            //}
        }

        private void lvHorarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lvHorarios.Items.Count; i++)
            {
                if (lvHorarios.Items[i].Selected)
                {

                    stHorario = lvHorarios.Items[i].Text;
                }



            }
            txtIdHorario.Text = Convert.ToString(clEntidadHorario.mIdHorario);
            cboDia.Text = clEntidadHorario.mDia;
            cboHoraInicio.Text = clEntidadHorario.mHoraInicio;
            cboHoraInicio.Text = clEntidadHorario.mHoraSalida;

            btnModifcarHorario.Enabled = true;
        }

        public String getIdHorario()
        {
            return stHorario;
        }

    }
}
