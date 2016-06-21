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
using System.Collections;

namespace Vista
{
    public partial class frmConsultarCurso : Form
    {
        #region Atributos
        private Form menu;
        private frmCursos frmCurso;
        private SqlDataReader strCurso;
        private clConexion conexion;
        private clEntidadCurso pEntidadCurso;
        private clCurso clCurso;
        private ListViewItem lvItem;
        private ArrayList  idCursosSeleccionados;
        private String curso;
        public int tipoDataGrid;
        #endregion

        public frmConsultarCurso(Object objeto )
        {
            if(objeto is menuPrincipal)
            {
                menuPrincipal menuP = (menuPrincipal)objeto;
                this.menu = menuP;                 
                
            }
            else
            {
                if (objeto is frmCursos)
                {
                    frmCursos menuP = (frmCursos)objeto;
                    this.menu = menuP;
                    this.frmCurso = menuP;
                }
            }
            
            this.conexion =new clConexion();
            pEntidadCurso = new clEntidadCurso();
            clCurso = new clCurso();

            InitializeComponent();
            idCursosSeleccionados = new ArrayList();
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
            dgvDetalleCursos.Rows[reglon].Cells["idCurso"].Value =Convert.ToString( strCurso.GetInt32(0));
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
            if (menu is menuPrincipal){
                btnAgregarALista.Enabled = false;
            }
            else{
                if (menu is frmCursos)
                {
                    btnAgregarALista.Enabled = true;
                }
            }
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

        private void dgvDetalleCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalleCursos.CurrentCell.ColumnIndex == 8)
            {
                FolderBrowserDialog carpetaSeleccionada = new FolderBrowserDialog();
                carpetaSeleccionada.Description = "Seleccione la ruta donde guardará el programa";
                DialogResult result = carpetaSeleccionada.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string ruta = carpetaSeleccionada.SelectedPath + "/" + dgvDetalleCursos.CurrentCell.Value;
                    pEntidadCurso.mSiglaCurso = Convert.ToString(dgvDetalleCursos.Rows[dgvDetalleCursos.CurrentCell.RowIndex].Cells[0].Value);
                    strCurso = clCurso.mConsultaEspecifica(conexion, pEntidadCurso, "Sigla");
                    if (strCurso != null)
                        if (strCurso.Read())
                        {
                            pEntidadCurso.mIdCurso = strCurso.GetInt32(0);
                            clCurso.mDescargarProgramaCurso(conexion, ruta, pEntidadCurso);

                        }
                }
            }
            else
            {
                for (int i = 0; i < dgvDetalleCursos.RowCount; i++)
                {
                    if (dgvDetalleCursos.Rows[i].Selected)
                    {
                        
                        curso = Convert.ToString(dgvDetalleCursos.CurrentRow.Cells["idCurso"].Value);
                    }
                }
            }
            
        }


        public String mIdCurso()
        {
            return curso;
        }


        private void btnAgregarALista_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgv in dgvDetalleCursos.SelectedRows)
            {
                idCursosSeleccionados.Add(dgv.Cells["idCurso"].Value);
                           
            }
            if (tipoDataGrid == 0) {
                frmCurso.AgregarRequisito(idCursosSeleccionados);
            }
            else {
                if (tipoDataGrid == 1){
                    frmCurso.AgregarCoRequisito(idCursosSeleccionados);
                }
            }
            
            this.Hide();
            frmCurso.Show();
        }
        public ArrayList retornarICursosdSeleccion()
        {
            return idCursosSeleccionados;
        }

        public int mTipoDataGrid
        {
            get { return this.tipoDataGrid; }
            set { this.tipoDataGrid = value; }
        }

      
    }
}
