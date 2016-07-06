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
        int numero;
        Boolean estadoGrupo=true, estadoCbo=true;
       
        private ArrayList horas;
        Object objeto;
        private String stHorario;
        frmConsultarCurso consultarCurso;


        public frmGrupoCurso()
        {
            clGrupoCurso = new clGrupoCurso();
            clEntidadGrupoCurso = new clEntidadGrupoCurso();
            clEntidadHorario = new clEntidadHorario();
           // numero = Convert.ToInt32(clGrupoCurso.mCantidadNumeroGrupo(conexion,clEntidadGrupoCurso));
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
                txtIdCurso.Text = consultaCurso.mIdCurso();
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
                    this.txtIdCurso.Text = strSentencia.GetString(1);

                }//Fin del if si existe

            }//Fin del if dtrEstudiante!=null

        }




        private void frmGrupoCurso_Load(object sender, EventArgs e)
        {
            txtIdCurso.Enabled = false;

            mLlenarHorasFinal();
            mLlenarHorasInicio();
            mLlenarDia();
            mLlenarNumeroGrupo();


            strSentencia = clHorario.mConsultarHorario(conexion);
            lvHorarios.Items.Clear();
            while (strSentencia.Read())
            {
                ListViewItem item = new ListViewItem(Convert.ToString(strSentencia.GetSqlInt32(0)));
                item.SubItems.Add(strSentencia.GetString(1));
                item.SubItems.Add(Convert.ToString(strSentencia.GetTimeSpan(2)));
                item.SubItems.Add(Convert.ToString(strSentencia.GetTimeSpan(3)));


                lvHorarios.Items.Add(item);
            }


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
            txtIdCurso.Text = "";
            cboNumeroGrupo.Text = "00";
            numCupoActual.Value = 0;
            numCupoMaximo.Value = 0;
            numCupoMinimo.Value = 0;
            cboDia.Text = "ninguno";
            cboHoraFinal.Text = "00:00";
            cboHoraInicio.Text = "00:00";


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
            if ((cboNumeroGrupo.Text != "") & (numCupoMaximo.Text != "0") & (numCupoMinimo.Text != "0") & (numCupoActual.Text != "0"))
            {
                return true;
            }
            return false;
        }


        public void mLlenarHorasInicio()
        {
            for (int i = 7; i < 19; i++)
            {

                cboHoraInicio.Items.Add(i + ":00");

            }

        }

        public void mLlenarNumeroGrupo()
        {
            for (int i = 0; i < 6; i++)
            {

                cboNumeroGrupo.Items.Add("0" + i);

            }

        }

        public void mLlenarHorasFinal()
        {
            for (int i = 9; i < 21; i++)
            {
                cboHoraFinal.Items.Add(i + ":00");

            }

        }

        public void mLlenarDia()
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
                clEntidadGrupoCurso.getsetIdGrupo = Convert.ToInt32(txtIdCurso.Text);
                clEntidadGrupoCurso.getSetNumeroGrup = Convert.ToInt32(cboNumeroGrupo.Text);
                clEntidadGrupoCurso.getSetCupoMaximo = Convert.ToInt32(numCupoMaximo.Text);
                clEntidadGrupoCurso.getSetCupoMinimo = Convert.ToInt32(numCupoMinimo.Text);
                clEntidadGrupoCurso.getSetCupoActual = Convert.ToInt32(numCupoActual.Text);

                if (clGrupoCurso.mModificarGrupoCurso(conexion, clEntidadGrupoCurso))
                {
                    MessageBox.Show("Se ha modificado el grupo", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estadoGrupo = true;

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
                if (mVerificarDatosHorario() == true)
                {
                 

                    clEntidadGrupoCurso.getSetIdCurso = Convert.ToInt32(txtIdCurso.Text);
                    clEntidadGrupoCurso.getSetNumeroGrup = Convert.ToInt32(cboNumeroGrupo.Text);
                    clEntidadGrupoCurso.getSetCupoMaximo = Convert.ToInt32(numCupoMaximo.Text);
                    clEntidadGrupoCurso.getSetCupoMinimo = Convert.ToInt32(numCupoMinimo.Text);
                    clEntidadGrupoCurso.getSetCupoActual = Convert.ToInt32(numCupoActual.Text);

                    strSentencia = clGrupoCurso.mConsultaNumeroGrupo(conexion, clEntidadGrupoCurso);
                    while (strSentencia != null && strSentencia.Read())
                    {
                        if (cboNumeroGrupo.Text != Convert.ToString(strSentencia.GetInt32(0)))
                        {
                            estadoCbo = false;
                        }
                    }
                    if (estadoCbo == true)
                    {
                        if (txtIdCurso.Text == Convert.ToString(clEntidadGrupoCurso.getSetIdCurso))
                        {


                            clEntidadHorario.mDia = cboDia.Text;
                            if (cboHoraInicio.Text != cboHoraFinal.Text)
                            {


                                clEntidadHorario.mHoraInicio = cboHoraInicio.Text;
                                clEntidadHorario.mHoraSalida = cboHoraFinal.Text;
                            }





                            if (clGrupoCurso.mInsertarGrupo(conexion, clEntidadGrupoCurso) == true)
                                if (clHorario.mInsertarHorario(conexion, clEntidadHorario) == true )
                                {
                                   strSentencia= clGrupoCurso.mConsultaGeneral(conexion, clEntidadGrupoCurso);


                                    if (strSentencia != null && strSentencia.Read())
                                    {
                                        clEntidadGrupoCurso.getsetIdGrupo = strSentencia.GetInt32(0);
                                        clGrupoCurso.mInsertHorarioGruposCurs(conexion, clEntidadHorario, clEntidadGrupoCurso);
                                    }
                                    

                                    MessageBox.Show("Se ha insertado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    mLimpiarCampos();
                                    estadoGrupo = true;


                                }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Ya existe un grupo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Favor llenar los campos de Horario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    this.txtIdCurso.Text = strSentencia.GetString(1);
                }//Fin del if si existe

            }//Fin del if dtrEstudiante!=null
        }




        private void btnAgregar_Click_2(object sender, EventArgs e)
        {
            mAgregarGrupo();
            btnConsultarHorarios.Enabled = true;
            btnConsultaGeneral.Enabled = true;
            btnConsultar.Enabled = true;
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

        }



        public void mModificarHorario()
        {


            if (mVerificarDatosHorario() == true)
            {


                conexion.codigo = "123";
                conexion.clave = "123";

                clEntidadHorario.mDia = cboDia.Text;
                clEntidadHorario.mHoraInicio = cboHoraInicio.Text;
                clEntidadHorario.mHoraSalida = cboHoraFinal.Text;
            }
            else
            {
                MessageBox.Show("Favor llenar todos los campos", "Datos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }



            if (clHorario.mModificarHorario(conexion, clEntidadHorario))
            {
                MessageBox.Show("Se ha modificado el horario", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // lvHorarios.Clear();
                strSentencia = clHorario.mConsultarHorario(conexion);
                lvHorarios.Items.Clear();
                while (strSentencia.Read())
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(strSentencia.GetSqlInt32(0)));
                    item.SubItems.Add(strSentencia.GetString(1));
                    item.SubItems.Add(Convert.ToString(strSentencia.GetTimeSpan(2)));
                    item.SubItems.Add(Convert.ToString(strSentencia.GetTimeSpan(3)));


                    lvHorarios.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("No se ha podido modificar el horario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnModifcarHorario_Click(object sender, EventArgs e)
        {
            mModificarHorario();
            mLimpiarCampos();


        }

        private void btnAgregarTabla_Click(object sender, EventArgs e)
        {
            mAgregarDatosLista();
        }




        public void mAgregarDatosLista()
        {

            strSentencia = clHorario.mConsultarHorario(conexion);

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
            estadoGrupo = true;

            frmConsultarCurso consultarCurso = new frmConsultarCurso(this);
            consultarCurso.ShowDialog();

            if (consultarCurso.mIdCurso() != "")
            {
                clEntidadGrupoCurso.getSetIdCurso = Convert.ToInt32(consultarCurso.mIdCurso());
                txtIdCurso.Text = consultarCurso.mIdCurso();
                mConsultaCodigo();
            }

        }

        private void lvHorarios_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void btnConsultarHorarios_Click(object sender, EventArgs e)
        {
            if (itemSeleccion(lvHorarios) != -1)
            {
                strSentencia = clHorario.mConsultarHorario(conexion);
                if (strSentencia.Read())

                    txtIdHorario.Text = Convert.ToString(strSentencia.GetInt32(0));
                cboDia.Text = (strSentencia.GetString(1));
                cboHoraInicio.Text = Convert.ToString(strSentencia.GetTimeSpan(2));
                cboHoraFinal.Text = Convert.ToString(strSentencia.GetTimeSpan(3));

                btnModifcarHorario.Enabled = true;
            }


        }

        private void btnConsultaGeneral_Click(object sender, EventArgs e)
        {
            estadoGrupo = false;
            frmConsultarCurso consultarCurso = new frmConsultarCurso(this);
            consultarCurso.ShowDialog();

            if (consultarCurso.mIdCurso() != "")
            {
                clEntidadGrupoCurso.getSetIdCurso = Convert.ToInt32(consultarCurso.mIdCurso());
                txtIdCurso.Text = consultarCurso.mIdCurso();
                mConsultaCodigo();
            }

            if (mVerificarDatosGrupo() == false)
                cboNumeroGrupo.Items.Clear();
            {
                strSentencia = clGrupoCurso.mConsultaNumeroGrupo(conexion, clEntidadGrupoCurso);
                if (strSentencia != null)
                    while (strSentencia.Read())
                    {
                        cboNumeroGrupo.Items.Add("0" +strSentencia.GetInt32(0));
                    }

      
               

            }
            
        }
        private void bntLimpiar_Click(object sender, EventArgs e)
        {
            mLimpiarCampos();
        }

        public int itemSeleccion(ListView lista) //Usar solo 1 método
        {
            for (int i = 0; i < lista.Items.Count; i++)
            {
                if (lista.Items[i].Selected)
                {
                    return lista.Items[i].Index;
                }
            }
            return -1;
        }


        /*

        private void lvHorarios_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            strSentencia = clHorario.mConsultarHorario(conexion);
            if (strSentencia.Read())

              txtIdHorario.Text =Convert.ToString(strSentencia.GetInt32(0));
                cboDia.Text = (strSentencia.GetString(1));
            cboHoraInicio.Text = Convert.ToString(strSentencia.GetTimeSpan(2));
            numCupoMinimo.Text = Convert.ToString(strSentencia.GetTimeSpan(3));

            btnModifcarHorario.Enabled = true;

        }
        */
    
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cboNumeroGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (estadoGrupo == false)
            {
                if (txtIdCurso.Text == Convert.ToString(clEntidadGrupoCurso.getSetIdCurso))

                {


                    if (cboNumeroGrupo.SelectedIndex.ToString() == Convert.ToString(clEntidadGrupoCurso.getSetNumeroGrup))


                        strSentencia = clGrupoCurso.mConsultaGeneral(conexion, clEntidadGrupoCurso);
                    if (strSentencia.Read())
                    {
                        numCupoMaximo.Text = Convert.ToString(strSentencia.GetInt32(1));
                        numCupoMinimo.Text = Convert.ToString(strSentencia.GetInt32(2));
                        numCupoActual.Text = Convert.ToString(strSentencia.GetInt32(3));
                    }

                    btnModificar.Enabled = true;

                }
            }

        }
    }
}
