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
        SqlDataReader strCurso;
        clConexion conexion;
        clEntidadCurso pEntidadCurso;
        clCurso clCurso;
        #endregion

        public frmConsultarCurso(clConexion conexion)
        {
            this.conexion = conexion;
            pEntidadCurso = new clEntidadCurso();
            clCurso = new clCurso();

            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void frmConsultarCurso_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cbConsultarPor.SelectedItem.ToString().Trim()=="Sigla")
            {
                strCurso = clCurso.mConsultaPorSigla(conexion, pEntidadCurso);
                ListViewItem lvItem = new ListViewItem();

                while (strCurso.Read())
                {
                    lvItem.SubItems.Add(strCurso.GetString(1));
                    lvItem.SubItems.Add(strCurso.GetString(2));
                    lvItem.SubItems.Add(strCurso.GetString(3));
                    lvItem.SubItems.Add(strCurso.GetString(4));
                    lvItem.SubItems.Add(strCurso.GetString(5));
                    lvItem.SubItems.Add(strCurso.GetString(7));
                    lvItem.SubItems.Add(strCurso.GetString(8));
                    lvItem.SubItems.Add(strCurso.GetString(9));

                    lvDetalleCursos.Items.Add(lvItem);
                }//fin del read
            }//fin del if
        }
    }
}
