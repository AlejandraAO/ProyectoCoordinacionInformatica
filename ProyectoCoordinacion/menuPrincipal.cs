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
            this.SetVisibleCore(false);
            //ventanaAcceso.limpiar();
            ventanaAcceso.Show();
        }

        private void menuPrincipal_Load(object sender, EventArgs e)
        {

        }

       

        private void reportesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void gestiónDeProyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProyectoSoftwareLibre ventanaSoftwareLibre = new frmProyectoSoftwareLibre();
            ventanaSoftwareLibre.Show();
        }

        private void gestiónDeMiembrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionMiembros ventanaMiembros = new frmGestionMiembros();
            ventanaMiembros.Show();
        }
    }
}
