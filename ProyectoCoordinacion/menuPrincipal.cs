using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AccesoDatos;
using Entidades;

namespace Vista
{
    public partial class menuPrincipal : Form
    {
        private frmAcceso ventanaAcceso;

        public menuPrincipal(frmAcceso ventanaAcceso)
        {
            InitializeComponent();
            this.ventanaAcceso = ventanaAcceso;
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
           // this.SetVisibleCore(false);
            Application.Exit();
            //ventanaAcceso.limpiar();
            //ventanaAcceso.Show();
        }

        private void menuPrincipal_Load(object sender, EventArgs e)
        {

        }

       

        private void reportesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void gestiónDeProyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProyectoSoftwareLibre ventanaSoftwareLibre = new frmProyectoSoftwareLibre(this);
            ventanaSoftwareLibre.Show();
        }

        private void gestiónDeMiembrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionMiembros ventanaMiembros = new frmGestionMiembros();
            ventanaMiembros.Show();
        }

        private void gestiónCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCursos frmCurso = new frmCursos(this);
            this.Hide();            
            frmCurso.Show();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarCurso frmConsultarCurso = new frmConsultarCurso(this);
            this.Hide();
            frmConsultarCurso.Show();
        }

        private void miembrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteMiembros frmConsultarCurso = new frmReporteMiembros(this);
            this.Hide();
            frmConsultarCurso.Show();
        }

        private void gestionCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionCursosLibres frmCursosLibres = new frmGestionCursosLibres(this);
            this.Hide();
            frmCursosLibres.Show();
        }
    }
}
