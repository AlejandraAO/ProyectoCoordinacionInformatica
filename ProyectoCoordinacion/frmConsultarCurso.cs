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

        private void frmConsultarCurso_Load(object sender, EventArgs e)
        {
            strCurso = clCurso.mConsultaGeneral(conexion);
            ListViewItem lvItem = new ListViewItem();

            while (strCurso.Read())
            {
                lvItem = lvDetalleCursos.Items.Add(strCurso.GetString(1));
                lvItem.SubItems.Add(strCurso.GetString(2));
                lvItem.SubItems.Add(strCurso.GetString(3));
                lvItem.SubItems.Add(strCurso.GetString(4));
                lvItem.SubItems.Add(Convert.ToString(strCurso.GetInt32(5)));
                lvItem.SubItems.Add(strCurso.GetString(7));
                lvItem.SubItems.Add(Convert.ToString(strCurso.GetInt32(8)));
                lvItem.SubItems.Add(strCurso.GetString(9));
            }//fin del read
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cbConsultarPor.SelectedItem.ToString().Trim() == "Nombre")
            {
                pEntidadCurso.mNombreCurso = txtDatoConsulta.Text.Trim();
                strCurso = clCurso.mConsultarPorNombre(conexion, pEntidadCurso);
                ListViewItem lvItem = new ListViewItem();

                while (strCurso.Read())
                {
                    lvItem = lvDetalleCursos.Items.Add(strCurso.GetString(1));
                    lvItem.SubItems.Add(strCurso.GetString(2));
                    lvItem.SubItems.Add(strCurso.GetString(3));
                    lvItem.SubItems.Add(strCurso.GetString(4));
                    lvItem.SubItems.Add(Convert.ToString(strCurso.GetInt32(5)));
                    lvItem.SubItems.Add(strCurso.GetString(7));
                    lvItem.SubItems.Add(Convert.ToString(strCurso.GetInt32(8)));
                    lvItem.SubItems.Add(strCurso.GetString(9));
                }//fin del read
            }//fin de la consulta por nombre

            if (cbConsultarPor.SelectedItem.ToString().Trim() == "Sigla")
            {
                pEntidadCurso.mSiglaCurso = txtDatoConsulta.Text.Trim();
                strCurso = clCurso.mConsultaPorSigla(conexion, pEntidadCurso);
                ListViewItem lvItem = new ListViewItem();

                while (strCurso.Read())
                {
                    lvItem = lvDetalleCursos.Items.Add(strCurso.GetString(1));
                    lvItem.SubItems.Add(strCurso.GetString(2));
                    lvItem.SubItems.Add(strCurso.GetString(3));
                    lvItem.SubItems.Add(strCurso.GetString(4));
                    lvItem.SubItems.Add(Convert.ToString(strCurso.GetInt32(5)));
                    lvItem.SubItems.Add(strCurso.GetString(7));
                    lvItem.SubItems.Add(Convert.ToString(strCurso.GetInt32(8)));
                    lvItem.SubItems.Add(strCurso.GetString(9));
                }//fin del read
            }//fin de la consulta por siglas 

            if (cbConsultarPor.SelectedItem.ToString().Trim() == "Ciclo")
            {
                pEntidadCurso.mCicloCurso = txtDatoConsulta.Text.Trim();
                strCurso = clCurso.mConsultarPorCiclo(conexion, pEntidadCurso);
                ListViewItem lvItem = new ListViewItem();

                while (strCurso.Read())
                {
                    lvItem = lvDetalleCursos.Items.Add(strCurso.GetString(1));
                    lvItem.SubItems.Add(strCurso.GetString(2));
                    lvItem.SubItems.Add(strCurso.GetString(3));
                    lvItem.SubItems.Add(strCurso.GetString(4));
                    lvItem.SubItems.Add(Convert.ToString(strCurso.GetInt32(5)));
                    lvItem.SubItems.Add(strCurso.GetString(7));
                    lvItem.SubItems.Add(Convert.ToString(strCurso.GetInt32(8)));
                    lvItem.SubItems.Add(strCurso.GetString(9));
                }//fin del read
            }//fin de la consulta por ciclo
        }

        private void cbConsultarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDatoConsulta.Enabled = true;
            btnConsultar.Enabled = true;
        }

    }
}
