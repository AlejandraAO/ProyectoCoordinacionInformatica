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
using LogicaNegocios;
using System.Data.SqlClient;

namespace Vista
{ 
    public partial class frmConsultarMiembro : Form
    {
        public frmConsultarMiembro()
        {
            InitializeComponent();
        }

        private void frmConsultarMiembro_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
