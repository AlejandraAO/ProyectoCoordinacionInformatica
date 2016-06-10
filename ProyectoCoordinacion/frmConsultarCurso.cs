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
using AccesoDatos;
using Entidades;
using System.Data.SqlClient;

namespace Vista
{
    public partial class frmConsultarCurso : Form
    {
        #region Atributos
        menuPrincipal menu;
        SqlDataReader strCurso;
        clConexion conexion;
        clEntidadCurso pEntidadCurso;
        clCurso clCurso;
        ListViewItem lvItem;
        #endregion

        public frmConsultarCurso(menuPrincipal menu)
        {

            this.menu = menu;
            this.conexion =new clConexion();
            pEntidadCurso = new clEntidadCurso();
            clCurso = new clCurso();

            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
            menu.Show();
        }

        public void mConsultaGenetal()
        {
            int posicion = 0;
            strCurso = clCurso.mConsultaGeneral(conexion);

           
             lvItem = new ListViewItem();
            
            while (strCurso.Read())
            {

                
                if (mVerificarCursoEnLista(strCurso.GetString(1),"Sigla") == false)
                {
                     busquedaPorSigla(posicion);
                     posicion++;

                }
                else
                {
                    if (mVerificarCursoEnLista(strCurso.GetString(2), "Nombre") == false)
                    {
                        busquedaPorSigla(posicion);
                        posicion++;
                        
                    }
                    else
                    {
                        if (mVerificarCursoEnLista(strCurso.GetString(4), "Ciclo") == true)
                        {
                            mLimpiarLista();
                            busquedaPorSigla(posicion);
                            posicion++;

                        }
                    }
                }



            }//fin del read
        }

        public void llenarDataGridCursos()
        {
            int reglon = dgvDetalleCursos.Rows.Add();
            dgvDetalleCursos.Rows[reglon].Cells["Sigla"].Value = strCurso.GetString(1);
            dgvDetalleCursos.Rows[reglon].Cells["Nombre"].Value = strCurso.GetString(2);
            dgvDetalleCursos.Rows[reglon].Cells["Lugar"].Value = strCurso.GetString(3);
            dgvDetalleCursos.Rows[reglon].Cells["Ciclo"].Value = strCurso.GetString(4);
            dgvDetalleCursos.Rows[reglon].Cells["Créditos"].Value = strCurso.GetInt32(5);
            dgvDetalleCursos.Rows[reglon].Cells["Estado"].Value = strCurso.GetString(7);
            dgvDetalleCursos.Rows[reglon].Cells["TotalHoras"].Value = strCurso.GetInt32(8);
            dgvDetalleCursos.Rows[reglon].Cells["Modalidad"].Value = strCurso.GetString(9);
            dgvDetalleCursos.Rows[reglon].Cells["Programa"].Value = strCurso.GetString(10);
        }

        public void busquedaPorSigla(int posicion)
        {
            //LLenar el data aquí
            llenarDataGridCursos();
            
        }

      



        private void frmConsultarCurso_Load(object sender, EventArgs e)
        {            
            mConsultaGenetal();
        }

        public Boolean mVerificarCursoEnLista(string tipoConsulta, string tipo)
        {
            int posicion = 0;
            if (tipo == "Sigla")
            {
                posicion = 0;
            }
            else
            {
                if (tipo == "Nombre")
                {
                    posicion = 1;
                }
                else
                {
                    if (tipo == "Ciclo")
                    {
                        posicion = 3;
                    }

                }
            }
            
            return false;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            mLimpiarLista();            
                pEntidadCurso.mNombreCurso = txtDatoConsulta.Text.Trim();
                pEntidadCurso.mSiglaCurso = txtDatoConsulta.Text.Trim();
                pEntidadCurso.mCicloCurso = txtDatoConsulta.Text.Trim();
                strCurso = clCurso.mConsultaEspecifica(conexion, pEntidadCurso, cbConsultarPor.Text);
                if (strCurso.Read())
                {
                    if (mVerificarCursoEnLista(strCurso.GetString(1), cbConsultarPor.Text)==false)
                    {
                        ListViewItem lvItem = new ListViewItem();
                        strCurso = clCurso.mConsultaEspecifica(conexion, pEntidadCurso, cbConsultarPor.Text);
                        while (strCurso.Read())
                        {

                        llenarDataGridCursos();
                        
                    }//fin del read
                }                
                 }                 
        }

        private void cbConsultarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDatoConsulta.Enabled = true;
            btnConsultar.Enabled = true;
        }

        public void mLimpiarLista()
        {
            dgvDetalleCursos.Rows.Clear();
        }

        private void txtDatoConsulta_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtDatoConsulta.Text == "")
            {
                mLimpiarLista();
                mConsultaGenetal();
            }
        }       
    }
}
