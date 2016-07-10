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
using System.Data.SqlClient;
using EntidadNegocios;


namespace Vista
{
    public partial class frmConsultaProferores : Form
    {
        SqlDataReader dtrProfesor;
        clProfesor logicaProfesor;
        private int idProfesor ;
        clConexion conexion;
        frmAdministracionProfesor frmMantenimiento;
        public frmConsultaProferores(clConexion conexion)
        {
            InitializeComponent();
            this.conexion = conexion;
            logicaProfesor = new clProfesor();
        }

        public void ventanaProfesor(frmAdministracionProfesor frmMantenimiento)
        {

            this.frmMantenimiento = frmMantenimiento;
        }

        private void frmConsultaProferores_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            this.lvProfesores.Items.Clear();
            llenarLvProfesores();

        }

        private void cbBusquedaPor_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbBusquedaPor.Text == "IDENTIFICACION")
            {
                this.lbFiltro.Text = "IDENTIFICACION";
                this.llenarComboIdentificacion();
                
            }
            if (cbBusquedaPor.Text == "GENERO")
            {
                this.lbFiltro.Text = "GENERO";
                this.llenarComboGenero();
            }
            if (cbBusquedaPor.Text == "JORNADA")
            {
                this.lbFiltro.Text = "JORNADA";
                this.llenarComboJornada();
            }
            if (cbBusquedaPor.Text == "ESTADO")
            {
                this.lbFiltro.Text = "ESTADO";
                this.llenarComboEstado();
            }
            if (cbBusquedaPor.Text == "TODOS")
            {
                this.lbFiltro.Text = "TODOS";
                this.llenarComboTodos();
            }
  
        }


        public void llenarComboIdentificacion() {
            this.limpiarComboFiltro();
            dtrProfesor = logicaProfesor.mLlenarCombo(this.conexion);
            if (dtrProfesor != null)
            {
                while (dtrProfesor.Read())
                {
                    String indentificacion = dtrProfesor.GetString(0).Trim();
                    cbFiltro.Items.Add(indentificacion);
                }
            }
        }

        public void llenarComboGenero()
        {
            this.limpiarComboFiltro();
            cbFiltro.Items.Add("MASCULINO");
            cbFiltro.Items.Add("FEMENINO");
        }

        public void llenarComboJornada()
        {
            this.limpiarComboFiltro();
            cbFiltro.Items.Add("COMPLETO");
            cbFiltro.Items.Add("1/8");
            cbFiltro.Items.Add("1/4");
            cbFiltro.Items.Add("3/8");
            cbFiltro.Items.Add("1/2");
            cbFiltro.Items.Add("5/8");
            cbFiltro.Items.Add("3/4");
            cbFiltro.Items.Add("7/8");

        }
        public void llenarComboEstado()
        {
            this.limpiarComboFiltro();
            cbFiltro.Items.Add("ACTIVO");
            cbFiltro.Items.Add("INACTIVO");
        }

        public void llenarComboTodos()
        {
            this.limpiarComboFiltro();
            cbFiltro.Items.Add("TODOS");
        }

        public void limpiarComboFiltro() {
            for (int i = 0; i < this.cbFiltro.Items.Count; i++)
            {
                cbFiltro.Items.Clear();
            }

        }

        

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lvProfesores.Items.Clear();
            dtrProfesor = logicaProfesor.mConsultarPorFiltro(conexion, cbFiltro.Text, this.lbFiltro.Text);
            if (dtrProfesor != null)
            {
                while (dtrProfesor.Read())
                {
                    ListViewItem lista;
                    lista = lvProfesores.Items.Add(dtrProfesor.GetInt32(0).ToString());
                    lista.SubItems.Add(dtrProfesor.GetString(1));
                    lista.SubItems.Add(dtrProfesor.GetString(2));
                    lista.SubItems.Add(dtrProfesor.GetString(3));
                    lista.SubItems.Add(dtrProfesor.GetString(4));
                    string fecha = string.Format(dtrProfesor.GetDateTime(5).ToString("yyyy/MM/dd"));
                    lista.SubItems.Add(fecha);
                    lista.SubItems.Add(dtrProfesor.GetString(6));
                    lista.SubItems.Add(dtrProfesor.GetString(6));
                    lista.SubItems.Add(dtrProfesor.GetString(7));
                    lista.SubItems.Add(dtrProfesor.GetString(8));
                    lista.SubItems.Add(dtrProfesor.GetString(9));
                }
            }
        }

        public void limiarFrame()
        {
            
            cbFiltro.Text = "";
            lbFiltro.Text = "";
            lvProfesores.Items.Clear();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.limiarFrame();
            this.Hide();
        }

        public void llenarLvProfesores()
        {
            dtrProfesor = logicaProfesor.mConsultaGeneral(conexion);
            if (dtrProfesor!=null)
            {
                while (dtrProfesor.Read())
                {
                    ListViewItem lista;
                    lista = lvProfesores.Items.Add(Convert.ToString(dtrProfesor.GetInt32(0)));
                    lista.SubItems.Add(dtrProfesor.GetString(1));
                    lista.SubItems.Add(dtrProfesor.GetString(2));
                    lista.SubItems.Add(dtrProfesor.GetString(3));
                    lista.SubItems.Add(dtrProfesor.GetString(4));
                    lista.SubItems.Add(Convert.ToString(dtrProfesor.GetDateTime(5)));
                    lista.SubItems.Add(dtrProfesor.GetString(6));
                    lista.SubItems.Add(dtrProfesor.GetString(7));
                    lista.SubItems.Add(dtrProfesor.GetString(8));
                    lista.SubItems.Add(dtrProfesor.GetString(9));
                }
            }
            
        }



        private void lvProfesores_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            for (int i = 0; i < lvProfesores.Items.Count; i++)
            {
                if (lvProfesores.Items[i].Selected)
                {
                    idProfesor = Convert.ToInt32(lvProfesores.Items[i].SubItems[0].Text);
                }
            }
            this.frmMantenimiento.mBuscarPorID(idProfesor);           
            this.frmMantenimiento.ShowDialog();
            

        }
        

        public int mDevolverFila()
        {
            return idProfesor;
        }

        private void lvProfesores_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lvProfesores.Items.Count; i++)
            {
                if (lvProfesores.Items[i].Selected)
                {
                    idProfesor = Convert.ToInt32(lvProfesores.Items[i].SubItems[0].Text);
                }
            }
        }
    }
}
