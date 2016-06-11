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
        private menuPrincipal menu;
        private SqlDataReader strCurso;
        private clConexion conexion;
        private clEntidadCurso pEntidadCurso;
        private clCurso clCurso;
        private ListViewItem lvItem;
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
            strCurso = clCurso.mConsultaGeneral(conexion);
           
            lvItem = new ListViewItem();
            if(strCurso!=null)
            while (strCurso.Read())
            {
                    mBusquedaCursos();
                                  
            }//fin del read
        }

        public void mLlenarDataGridCursos()
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

        public void mBusquedaCursos()
        {
            //LLenar el data aquí
            mLlenarDataGridCursos();
            
        }    
        private void frmConsultarCurso_Load(object sender, EventArgs e)
        {            
            mConsultaGenetal();
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
                   
                    ListViewItem lvItem = new ListViewItem();
                    strCurso = clCurso.mConsultaEspecifica(conexion, pEntidadCurso, cbConsultarPor.Text);
                    while (strCurso.Read())
                    {

                        mLlenarDataGridCursos();
                        
                    }
                 }//fin del read                

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
