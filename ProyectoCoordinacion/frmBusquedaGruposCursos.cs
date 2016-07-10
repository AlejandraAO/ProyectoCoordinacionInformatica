using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LogicaNegocios;
using AccesoDatos;

namespace Vista
{
    public partial class frmBusquedaGruposCursos : Form
    {
        clConexion conexion;
        clProfesoresGrupoCurso profesorGrupoCurso;
        SqlDataReader dtrProfesor;
        clProfesor logicaProfesor;

        DataTable dataTable;

        public frmBusquedaGruposCursos()
        {
            InitializeComponent();
            conexion = new clConexion();
            profesorGrupoCurso = new clProfesoresGrupoCurso();
            logicaProfesor = new clProfesor();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.cbIndentificacion.Text == "")
            {
                this.mensajeAdvertencia("Dede Seleccionar la Identificación");
            }
            else if (rbCursos.Checked == false && rbGrupos.Checked == false && rbCursosLibres.Checked == false)
            {
                this.mensajeAdvertencia("Dede Seleccionar el Filtro");
            }
            else
            {
                if (rbCursos.Checked == true)
                {
                    this.llenarCursos();
                }
                else if (rbGrupos.Checked == true)
                {
                    this.llenarGrupos();
                }
                else 
                {
                    this.llenarCursosLibres();
                }

            }
        }//FIN DEL EVENTO DEL BTNBUSCAR

        public void llenarCursos()
        {
            SqlDataAdapter adapter = profesorGrupoCurso.adaptarDataCurso(this.conexion, this.cbIndentificacion.Text.Trim());
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgCursos.DataSource = dataTable;
        }

        public void llenarGrupos()
        {
            SqlDataAdapter adapter = profesorGrupoCurso.adaptarDataGrupo(this.conexion, this.cbIndentificacion.Text.Trim());
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgCursos.DataSource = dataTable;
        }

        public void llenarCursosLibres()
        {
            SqlDataAdapter adapter = profesorGrupoCurso.adaptarDataCursoLlibre(this.conexion, this.cbIndentificacion.Text.Trim());
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgCursos.DataSource = dataTable;
        }

        public void cargarCombo()
        {
            dtrProfesor = logicaProfesor.mLlenarCombo(this.conexion);
            if (dtrProfesor != null)
            {
                while (dtrProfesor.Read())
                {
                    String indentificacion = dtrProfesor.GetString(0).Trim();
                    cbIndentificacion.Items.Add(indentificacion);
                }
            }
        }

        public void limpiar()
        {
            this.dgCursos.DataSource = null;
            this.rbCursos.Checked = false;
            this.rbCursosLibres.Checked = false;
            this.rbGrupos.Checked = false;
        }
        
        public void mensajeAdvertencia(String mensaje)
        {
            MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }// fin del metodo de peligro
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.limpiar();
            this.Hide();
        }

        //private void Proyectos_Enter(object sender, EventArgs e)
        

        private void frmBusquedaGruposCursos_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            this.cargarCombo();
        }
    }
}
