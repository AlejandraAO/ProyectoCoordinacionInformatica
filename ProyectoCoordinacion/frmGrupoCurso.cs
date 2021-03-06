﻿using System;
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
        SqlDataReader strSentencia2;
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
            btnAgregarHorario.Enabled = true;


         
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
            cboDia.Items.Clear();
            cboHoraFinal.Items.Clear();
            cboHoraInicio.Items.Clear();
            lvHorarios.Items.Clear();
            mLlenarHorasFinal();
            mLlenarHorasInicio();
            mLlenarDia();
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
            cboDia.Items.Add("Lunes");
            cboDia.Items.Add("Martes");
            cboDia.Items.Add("Miércoles");
            cboDia.Items.Add("Jueves");
            cboDia.Items.Add("Viernes");
            cboDia.Items.Add("Sábado");
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

            if (mVerificarDatosGrupo() == true && mVerificarDatosHorario() == true)
            {    

                    clEntidadGrupoCurso.getSetIdCurso = Convert.ToInt32(txtIdCurso.Text);
                    clEntidadGrupoCurso.getSetNumeroGrup = Convert.ToInt32(cboNumeroGrupo.Text);
                    clEntidadGrupoCurso.getSetCupoMaximo = Convert.ToInt32(numCupoMaximo.Text);
                    clEntidadGrupoCurso.getSetCupoMinimo = Convert.ToInt32(numCupoMinimo.Text);
                    clEntidadGrupoCurso.getSetCupoActual = Convert.ToInt32(numCupoActual.Text);

                    strSentencia = clGrupoCurso.mConsultaNumeroGrupo(conexion, clEntidadGrupoCurso);
                    while (strSentencia != null && strSentencia.Read())
                    {
                        if (cboNumeroGrupo.Text == Convert.ToString(strSentencia.GetInt32(0)))
                        {
                            estadoCbo = true;
                        }                       
                    }
                if (estadoCbo == true)
                {
                    if (txtIdCurso.Text == Convert.ToString(clEntidadGrupoCurso.getSetIdCurso))
                    {
                        if (clGrupoCurso.mInsertarGrupo(conexion, clEntidadGrupoCurso) == true) {

                            foreach (ListViewItem I in lvHorarios.Items)
                             {                              
                                agregarHorario(I);                                                            
                                if (clHorario.mInsertarHorario(conexion, clEntidadHorario) == true)
                                {
                                    MessageBox.Show("Se ha insertado", Convert.ToString(clEntidadHorario.mIdHorario), MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    strSentencia = clGrupoCurso.mConsultaUltimoGrupo(conexion);
                                    strSentencia2 = clHorario.mConsultarIdHorarioFiltro(conexion, clEntidadHorario);

                                    if (strSentencia != null && strSentencia.Read())
                                    {
                                        if (strSentencia2 != null && strSentencia2.Read())
                                        {

                                            clEntidadGrupoCurso.getsetIdGrupo = strSentencia.GetInt32(0);
                                            clEntidadHorario.mIdHorario = strSentencia2.GetInt32(0);
                                            clGrupoCurso.mInsertHorarioGruposCurs(conexion, clEntidadHorario, clEntidadGrupoCurso);

                                            MessageBox.Show("Se ha insertado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            mLimpiarCampos();
                                            estadoGrupo = true;
                                        }
                                    }
                                }
                            }//Cierro for
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
                MessageBox.Show("Favor llenar todos los campos ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        public void agregarHorario(ListViewItem I)
        {                         
            clEntidadHorario.mDia = I.SubItems[0].Text;
            clEntidadHorario.mHoraInicio = I.SubItems[1].Text;
            clEntidadHorario.mHoraSalida = I.SubItems[2].Text;            
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

            //strSentencia = clHorario.mConsultarHorario(conexion);

            if (mVerificarDatosHorario() == true)
            {
                int posicion = lvHorarios.Items.Count;

                ListViewItem item = new ListViewItem();
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
            consultarCurso.mTipoEvento = 1;
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
            if (mVerificarDatosHorario())
            {
                strSentencia = clHorario.mConsultarHorario(conexion);
                if (strSentencia.Read()){
                    TimeSpan inicio = new TimeSpan(0,cboHoraInicio.SelectedIndex+7,0,0);
                    TimeSpan final = new TimeSpan(0, cboHoraFinal.SelectedIndex + 9, 0, 0);                    
                    if ((cboDia.Text == (strSentencia.GetString(1))) && (inicio == (strSentencia.GetTimeSpan(2))) &&   (final == (strSentencia.GetTimeSpan(3))))
                    {
                        ListViewItem item = new ListViewItem(strSentencia.GetString(1));
                        item.SubItems.Add(Convert.ToString(strSentencia.GetTimeSpan(2)));
                        item.SubItems.Add(Convert.ToString(strSentencia.GetTimeSpan(3)));
                        lvHorarios.Items.Add(item);
                        btnModifcarHorario.Enabled = true;
                    }                    
                                                          
                }
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


        public Boolean mValidarPermisos(ListView lista)
        {
            if (lista.Items.Count > 0)
            {
                return true;
            }

            return false;
        }

        private void btnAgregarHorario_Click(object sender, EventArgs e)
        {
            if (mVerificarDatosHorario() == true)
            {
                ListViewItem item = new ListViewItem(cboDia.Text);
                item.SubItems.Add(cboHoraInicio.Text);
                item.SubItems.Add(cboHoraFinal.Text);

                lvHorarios.Items.Add(item);
            }
        }


        /*   if (cboDia.Text != "" && cboHoraFinal.Text!="" && cboHoraInicio.Text != "")
           {

               ListViewItem item = new ListViewItem(cboDia.Text);
               item.SubItems.Add(cboHoraInicio.Text);
               item.SubItems.Add(cboHoraFinal.Text);
               lvHorarios.Items.Add(item);

               lvHorarios.Items.Add(item);
           }
           else
           {
               MessageBox.Show("Seleccione un horario válido", "Horario no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }

   */
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
