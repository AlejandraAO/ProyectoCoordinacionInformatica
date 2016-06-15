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
        #region variables globales / atributos
        private SqlDataReader dtrCursoLibre;
        private clConexion conexion;
        private menuPrincipal menu;
        private clCursoLibre clCursoLibre;
        private clEntidadCursoLibre eCursoLibre;
        private ListViewItem listViewItem;
        #endregion

        public frmReportesCursosLibres( menuPrincipal menu )
        {
            InitializeComponent();

            this.menu = menu;
            this.conexion = new clConexion();
            this.clCursoLibre = new clCursoLibre();
            this.conexion.codigo = "sa";
            this.conexion.clave = "123";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
            menu.Show();
        }

        public void mConsultaGenetal()
        {
            dtrCursoLibre = clCursoLibre.mConsultaGeneral(conexion);

            listViewItem = new ListViewItem();
            if (dtrCursoLibre != null)
                while (dtrCursoLibre.Read())
                {
                    mPoblarListaCursosLibres();

                }//fin del read
        }



        public void mPoblarListaCursosLibres()
        {
            int reglon = dgvCursosLibres.Rows.Add();
            dgvCursosLibres.Rows[reglon].Cells["Profesor"].Value = dtrCursoLibre.GetString(0);
            dgvCursosLibres.Rows[reglon].Cells["Nombre"].Value = dtrCursoLibre.GetString(1);
            dgvCursosLibres.Rows[reglon].Cells["Descripcion"].Value = dtrCursoLibre.GetString(2); // implementar emergernte
            dgvCursosLibres.Rows[reglon].Cells["estado"].Value = dtrCursoLibre.GetString(3);
            dgvCursosLibres.Rows[reglon].Cells["lugar"].Value = dtrCursoLibre.GetString(4);
            dgvCursosLibres.Rows[reglon].Cells["cupo"].Value = dtrCursoLibre.GetInt32(5);
            //dgvCursosLibres.Rows[reglon].Cells["programa"].Value = dtrCursoLibre.GetString(7);
            //dgvProyecto.Rows[reglon].Cells["informacion"].Value = dtrProyecto.GetString(5);
            //  dgvProyecto.Rows[reglon].Cells["TotalHoras"].Value = dtrProyecto.GetString(6);

        }

        private void frmReportesCursosLibres_Load(object sender, EventArgs e)
        {
            mConsultaGenetal();
        }
    }


}
