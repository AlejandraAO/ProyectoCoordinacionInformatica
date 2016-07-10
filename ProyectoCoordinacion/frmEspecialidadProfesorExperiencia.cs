using AccesoDatos;
using Entidades;
using LogicaNegocios;
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

namespace Vista
{
    public partial class frmEspecialidadProfesorExperiencia : Form
    {
        clEntidadEspecialidadesPorExperiencia especialidadPorExperiencia;
        clEspecialidadesPorExperiencia clEspecialidadesPorExperiencia;
        clEspecialidadExperienciaProfesor clEspecialidadExperienciaProfesor;
        clConexion clsConexion;
        clEntidadEspecialidadProfesor especialidadProfesor;
        clProfesor clProfesor;
        SqlDataReader dtrProfesor;
        SqlDataReader dtrCodigoProfesor;
        SqlDataReader dtrExperienciaProfesores;

        public frmEspecialidadProfesorExperiencia(clConexion conexion)
        {
            clsConexion = conexion;
            especialidadPorExperiencia = new clEntidadEspecialidadesPorExperiencia();
            clEspecialidadesPorExperiencia = new clEspecialidadesPorExperiencia();
            clEspecialidadExperienciaProfesor = new clEspecialidadExperienciaProfesor();
            especialidadProfesor = new clEntidadEspecialidadProfesor();

            clProfesor = new clProfesor();

            InitializeComponent();

            cargarDataGrit();
        }

        private void frmEspecialidadProfesorExperiencia_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        #region metodos de los componentes ventana 
        private void btnEspecialidadTiempoSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAgregarEspecialidad_Click(object sender, EventArgs e)
        {
            if (verificarInformacionGroupBox())
            {
                if (verificarExistenciaProfesor(Convert.ToInt32(txtCodigoProfesor.Text.Trim())))
                {
                    especialidadProfesor.setIdProfesor(Convert.ToInt32(txtCodigoProfesor.Text.Trim()));
                    especialidadProfesor.setIdEspecialidad(consultaEspecialidadExperienciaProfesor(Convert.ToInt32(txtCodigoProfesor.Text.Trim())));

                    especialidadPorExperiencia.setIdEspecialidad(especialidadProfesor.getIdEspecialidad());
                    especialidadPorExperiencia.setNombre(txtNombreEspecialidad.Text.Trim());
                    especialidadPorExperiencia.setTiempoExpe(Convert.ToInt32(nudTiempoExperienciaProfesor.Value));
                    especialidadPorExperiencia.setArea(txtAreaEspecialidad.Text.Trim());
                    especialidadPorExperiencia.setPuesto(txtPuestoEspecialidad.Text.Trim());
                    especialidadPorExperiencia.setTipoEmpresa(txtTipoEmpresa.Text.Trim());

                    clEspecialidadesPorExperiencia.mInsertar(clsConexion, especialidadPorExperiencia);
                    clEspecialidadExperienciaProfesor.mInsertar(clsConexion, especialidadProfesor);

                    cargarDataGrit();

                    mLimpiarCampos();
                }
                else
                {
                    mensajeError("El profesor no existe ");
                }
            }
            else
            {
                mensajeError("No se puede quedar campos en blanco y el tiempo debe tener un numero");
            }
        }


        private void btnModoficarEspecialidad_Click(object sender, EventArgs e)
        {
            if (verificarInformacionGroupBox())
            {
                especialidadPorExperiencia.setNombre(txtNombreEspecialidad.Text.Trim());
                especialidadPorExperiencia.setTiempoExpe(Convert.ToInt32(nudTiempoExperienciaProfesor.Value));
                especialidadPorExperiencia.setArea(txtAreaEspecialidad.Text.Trim());
                especialidadPorExperiencia.setPuesto(txtPuestoEspecialidad.Text.Trim());
                especialidadPorExperiencia.setTipoEmpresa(txtTipoEmpresa.Text.Trim());
                if (clEspecialidadesPorExperiencia.mModificar(clsConexion, especialidadPorExperiencia))
                {
                    btnAgregarEspecialidad.Enabled = true;
                    txtCodigoProfesor.Enabled = true;
                    mLimpiarCampos();
                    cargarDataGrit();
                    mensajeAviso("La especialidad se ha modificado exitosamente");
                }
                else
                {
                    mensajePeligro("Error la especialidad no se ha podido modificar");
                }
            }
        }

        private void dgListaExperienciaProfesor_DoubleClick(object sender, EventArgs e)
        {
            dtrCodigoProfesor = clEspecialidadesPorExperiencia.consultaProfesorExperiencia(clsConexion, Convert.ToInt32(dgListaExperienciaProfesor.CurrentRow.Cells["idEspecialidad"].Value.ToString()));
            if (dtrCodigoProfesor != null)
            {
                while (dtrCodigoProfesor.Read())
                {
                    txtCodigoProfesor.Text = Convert.ToString(dtrCodigoProfesor.GetInt32(0));
                }
            }
            especialidadPorExperiencia.setIdEspecialidad(Convert.ToInt32(dgListaExperienciaProfesor.CurrentRow.Cells["idEspecialidad"].Value.ToString()));
            txtNombreEspecialidad.Text = dgListaExperienciaProfesor.CurrentRow.Cells["nombre"].Value.ToString();
            nudTiempoExperienciaProfesor.Value = Convert.ToInt32(dgListaExperienciaProfesor.CurrentRow.Cells["tiempoExpe"].Value.ToString());
            txtAreaEspecialidad.Text = dgListaExperienciaProfesor.CurrentRow.Cells["area"].Value.ToString();
            txtPuestoEspecialidad.Text = dgListaExperienciaProfesor.CurrentRow.Cells["puesto"].Value.ToString();
            txtTipoEmpresa.Text = dgListaExperienciaProfesor.CurrentRow.Cells["tipoEmpresa"].Value.ToString();
            btnAgregarEspecialidad.Enabled = false;
            txtCodigoProfesor.Enabled = false;
        }
  
        #endregion

        #region otros metodos 
        public int consultaEspecialidadExperienciaProfesor(int codigo)
        {
            int idEspecialidad = 0;
            dtrCodigoProfesor = clEspecialidadesPorExperiencia.consultaEspecialidadExperienciaProfesor(clsConexion, codigo);
            if (dtrCodigoProfesor != null)
            {
                while (dtrCodigoProfesor.Read())
                {
                    idEspecialidad = dtrCodigoProfesor.GetInt32(0);
                }
            }
            return idEspecialidad;
        }

        private Boolean verificarExistenciaProfesor(int codigo)
        {
            Boolean veri = false;
            dtrProfesor = clProfesor.mConsultaPorCodigo(clsConexion, codigo);
            if (dtrProfesor != null)
            {
                while (dtrProfesor.Read())
                {
                    if (dtrProfesor.GetInt32(0) == codigo)
                    {
                        veri = true;
                    }
                }
            }
            return veri;
        }


        // verifica la informacion en el groupBox
        public Boolean verificarInformacionGroupBox()
        {
            foreach (Control control in gbInformacion.Controls)
            {
                if (control.GetType().Equals(typeof(TextBox)) || (control.GetType().Equals(typeof(NumericUpDown))))
                {
                    if (control.Text.Equals("") || (control.Text.Equals("0")))
                    {
                        return false;
                    }//fin del if control.Text
                }//fin del if control.getType
            }//fin foreach
            return true;
        }//fin del metodo verifica informacion

        private void mLimpiarCampos()
        {
            this.txtCodigoProfesor.Text = "";
            this.txtNombreEspecialidad.Text = "";
            this.nudTiempoExperienciaProfesor.Text = "0";
            this.txtAreaEspecialidad.Text = "";
            this.txtPuestoEspecialidad.Text = "";
            this.txtTipoEmpresa.Text = "";
        }


        private void cargarDataGrit()
        {
            dgListaExperienciaProfesor.DefaultCellStyle.ForeColor = Color.Black;
            dgListaExperienciaProfesor.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            dtrExperienciaProfesores = clEspecialidadesPorExperiencia.mConsultarGeneral(clsConexion);

            if (dtrExperienciaProfesores != null)
            {
                DataTable miTabla = new DataTable();
                miTabla.Load(dtrExperienciaProfesores);
                dgListaExperienciaProfesor.DataSource = miTabla;
            }
        }


        #endregion

        #region Mensajes

        public void mensajePeligro(String mensaje)
        {
            MessageBox.Show(mensaje, "Peligro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }// fin del metodo de peligro
        public void mensajeError(String mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }// fin del metodo de error

        public void mensajeAviso(String mensaje)
        {
            MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK);
        }//fin del metodo de peligro
        #endregion



    }
}
