﻿using AccesoDatos;
using Entidades;
using LogicaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista;

namespace Vista
{

    public partial class frmReportesCursosLibres : Form
    {

        #region Load
        private void frmReportesCursosLibres_Load(object sender, EventArgs e)
        {
            mConsultaGeneral();
            cbConsultarPor.SelectedIndex = 0;
        }

        #endregion
        #region Constructor
        public frmReportesCursosLibres( menuPrincipal menu )
        {
            InitializeComponent();

            this.menu = menu;
            this.conexion = new clConexion();
            this.clCursoLibre = new clCursoLibre();
            this.entidadCursoLibre = new clEntidadCursoLibre();
        }
        #endregion
        #region Boton Salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
            menu.Show();
        }

        #endregion
        #region dgvCursosLibres
        private void dgvCursosLibres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCursosLibres.CurrentCell.ColumnIndex == 7)
            {
                FolderBrowserDialog carpetaSeleccionada = new FolderBrowserDialog();
                carpetaSeleccionada.Description = "Seleccione la ruta donde guardará el programa del curso";
                DialogResult result = carpetaSeleccionada.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string ruta = carpetaSeleccionada.SelectedPath + "/" + dgvCursosLibres.CurrentCell.Value;
                    entidadCursoLibre.mIdCursoLibre = Convert.ToInt32(dgvCursosLibres.Rows[dgvCursosLibres.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    clCursoLibre.mDescargarProgramaCurso(conexion, ruta, entidadCursoLibre);

                }
            }
        }
        #endregion
        #region Consulta General
        public void mConsultaGeneral()
        {
            dtrCursoLibre = clCursoLibre.mConsultaGeneral(conexion);

            listViewItem = new ListViewItem();
            if (dtrCursoLibre != null)
                while (dtrCursoLibre.Read())
                {
                    mPoblarListaCursosLibres();
                }//fin del read
        }
        #endregion
        #region Consulta Especifica
        public void mConsultarEspecifica(String tipoConsulta, String busqueda)
        {

            dtrCursoLibre = clCursoLibre.mConsultaEspecifica(conexion, tipoConsulta, busqueda);
            if (dtrCursoLibre != null)
                while (dtrCursoLibre.Read())
                {
                    mPoblarListaCursosLibres();
                }
        }
        #endregion
        #region Poblar Cursos Libres
        public void mPoblarListaCursosLibres()
        {
            int reglon = dgvCursosLibres.Rows.Add();
            dgvCursosLibres.Rows[reglon].Cells["IdCurso"].Value = dtrCursoLibre.GetInt32(0);
            dgvCursosLibres.Rows[reglon].Cells["Profesor"].Value = dtrCursoLibre.GetString(1);
            dgvCursosLibres.Rows[reglon].Cells["Nombre"].Value = dtrCursoLibre.GetString(2);
            dgvCursosLibres.Rows[reglon].Cells["Descripcion"].Value = dtrCursoLibre.GetString(3);
            dgvCursosLibres.Rows[reglon].Cells["estado"].Value = dtrCursoLibre.GetString(4);
            dgvCursosLibres.Rows[reglon].Cells["lugar"].Value = dtrCursoLibre.GetString(5);
            dgvCursosLibres.Rows[reglon].Cells["cupo"].Value = dtrCursoLibre.GetInt32(6);
            dgvCursosLibres.Rows[reglon].Cells["programa"].Value = dtrCursoLibre.GetString(7);
        }
        #endregion
        #region Consultar Por Nombre
        public void mConsultarPorNombre(String nombre)
        {

            dtrCursoLibre = clCursoLibre.mConsultaFiltrada(conexion, nombre);
            if (dtrCursoLibre != null)
                while (dtrCursoLibre.Read())
                {
                    mPoblarListaCursosLibres();
                }
        }
        #endregion
        #region variables globales / atributos
        private SqlDataReader dtrCursoLibre;
        private clConexion conexion;
        private menuPrincipal menu;
        private clCursoLibre clCursoLibre;
        private clEntidadCursoLibre entidadCursoLibre;
        private ListViewItem listViewItem;
        #endregion
        #region Ingresar texto en el txt Dato Consulta
        private void txtDatoConsulta_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox tb_nombre = (TextBox)sender;


            if (tb_nombre.Text.Trim().Length > 0)
            {
                dgvCursosLibres.Rows.Clear();
                //mConsultarPorNombre(tb_nombre.Text.Trim().ToUpper());

                if (cbConsultarPor.SelectedIndex == 0)
                    mConsultarEspecifica(clCursoLibre.CONSULTA_NOMBRE, tb_nombre.Text.Trim().ToUpper());
                else if (cbConsultarPor.SelectedIndex == 1)
                    mConsultarEspecifica(clCursoLibre.COSULTA_PROFESOR, tb_nombre.Text.Trim().ToUpper());
                else
                    mConsultarEspecifica(clCursoLibre.CONSULTA_LUGAR, tb_nombre.Text.Trim().ToUpper());

            }
            else
            {
                dgvCursosLibres.Rows.Clear();
                mConsultaGeneral();
            }
        }
        #endregion
       
    }


}
