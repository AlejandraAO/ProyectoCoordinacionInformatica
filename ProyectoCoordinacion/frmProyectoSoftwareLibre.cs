﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocios;
using Entidades;

namespace Vista
{
    public partial class frmProyectoSoftwareLibre : Form
    {
        public frmProyectoSoftwareLibre()
        {
            InitializeComponent();
        }

        private void frmProyectoSoftwareLibre_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}