using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmGrupoCurso : Form
    {

        menuPrincipal menu;
        frmAcceso frmAcceso;
        public frmGrupoCurso()
        {
            frmAcceso = new frmAcceso();
            menu = new menuPrincipal(frmAcceso);
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultarCurso consultaCurso = new frmConsultarCurso(menu);
        }
        
        private void frmGrupoCurso_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
