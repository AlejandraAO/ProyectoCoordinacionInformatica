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
using Entidades;
using LogicaNegocios;
using AccesoDatos;

namespace Vista
{
    public partial class frmEspecialidaProfesorTitulo : Form
    {
        clEntidadEspecialidadesTitulos entidadEspTitulo;
        clEntidadEspecialidadProfesor entidadEspcialidad;

        clEspecialidadesTitulos logicaEspecialidadTituloProfe;
        clProfesor datosProfe;

        clEspecialidadTituloProfesor logicaEspecialidad;
        clConexion conexion;
        SqlDataReader datosEsp;
        public frmEspecialidaProfesorTitulo(clConexion conexion, clProfesor datosProfe, clEspecialidadTituloProfesor logicaEspecialidad)
        {
            this.conexion = conexion;
            InitializeComponent();
            this.datosProfe = datosProfe;
            logicaEspecialidadTituloProfe = new clEspecialidadesTitulos();
            this.logicaEspecialidad = logicaEspecialidad;
            cargarCodigo();
            cargarDataGrit();

        }


        #region metodos botones

        private void btnAgregarEsp_Click(object sender, EventArgs e)
        {
            int codProfe = 0;
            int codEsp = 0;
            if (verificarBlancos() == true)
            {
                if (verifarExistenciaidTitulo(Convert.ToInt32(txtCodEsp.Text.Trim())) == false)
                {
                    if (verifarExistenciaProfesor(txtCodigoProfesor.Text.Trim()) == true)
                    {
                        
                        
                        if (comparacionDatos(Convert.ToInt32(txtCodigoProfesor.Text.Trim()), codEsp) == false)
                        {
                           
                            entidadEspTitulo = new clEntidadEspecialidadesTitulos(Convert.ToInt32(txtCodEsp.Text.Trim()) ,txtNombre.Text.Trim(), txtDescripcion.Text.Trim(), txtInstitucion.Text.Trim());

                            if (logicaEspecialidadTituloProfe.mInsertarObjeto(conexion, entidadEspTitulo))
                            {
                                codProfe = buscarCodigoProfesor(txtCodigoProfesor.Text.Trim());
                                entidadEspcialidad = new clEntidadEspecialidadProfesor(codProfe, Convert.ToInt32(txtCodEsp.Text.Trim()));
                                if (logicaEspecialidad.mInsertar(conexion, entidadEspcialidad))
                                {
                                    MessageBox.Show("Titulo " + codEsp + "  Agregado");
                                    limpiarGeneral();
                                }
                                else {
                                    MessageBox.Show("Error al ingresar datos");
                                    limpiarGeneral();
                                }
                            }
                            else {
                                MessageBox.Show("Error al ingresar datos");
                                limpiarGeneral();
                            }
                        }
                        else
                        {
                            MessageBox.Show("ya existe se ha asignado esta especialidad al profesor");
                            limpiarGeneral();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Los datos del profesor no existen");
                        limpiarGeneral();
                    }

                }
                else
                {
                    MessageBox.Show("La especialidad ya existe");
                    limpiarGeneral();
                }
            }
        }

        private void btnEliminarEsp_Click(object sender, EventArgs e)
        {
            int codProfe = 0;
            if (verificarBlancos() == true)
            {

                if (verifarExistenciaProfesor(txtCodigoProfesor.Text.Trim()) == true)
                {
                    if (comparacionDatos(Convert.ToInt32(txtCodigoProfesor.Text.Trim()), Convert.ToInt32(txtCodEsp.Text.Trim())) == false)
                    {
                        codProfe = buscarCodigoProfesor(txtCodigoProfesor.Text.Trim());
                        if (verifarExistenciaidTitulo(codProfe) == true)
                        {
                           
                            entidadEspcialidad = new clEntidadEspecialidadProfesor(codProfe, Convert.ToInt32(txtCodEsp.Text.Trim()));
                            if (logicaEspecialidad.mInsertar(conexion, entidadEspcialidad))
                            {
                                MessageBox.Show("Titulo " + Convert.ToInt32(txtCodEsp.Text.Trim()) + "  Agregado");
                                limpiarGeneral();
                                cargarDataGrit();
                                cargarCodigo();
                                    
                            }
                        }
                        else {
                            MessageBox.Show("El titulo de la especialidad no existe ");
                            limpiarGeneral();
                            cargarDataGrit();
                            cargarCodigo();

                        }
                    }
                    else
                    {
                        MessageBox.Show("ya existe se ha asignado esta especialidad al profesor");
                        limpiarGeneral();
                        cargarDataGrit();
                        cargarCodigo();

                    }
                }
                else
                {
                    MessageBox.Show("Los datos del profesor no existen");
                    limpiarGeneral();
                    cargarDataGrit();
                    cargarCodigo();

                }
            }

        }

        private void btnSalirEspecialidaTitulo_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void btnModificarEsp_Click(object sender, EventArgs e)
        {
            if (verificarModificar() == true)
            {
                if (verifarExistenciaidTitulo(Convert.ToInt32(txtCodEsp.Text.Trim())) == true)
                {
                    entidadEspTitulo = new clEntidadEspecialidadesTitulos(Convert.ToInt32(txtCodEsp.Text.Trim()), txtNombre.Text.Trim(), txtDescripcion.Text.Trim(), txtInstitucion.Text.Trim());

                    if (logicaEspecialidadTituloProfe.mModificar(conexion, entidadEspTitulo))
                    {
                        MessageBox.Show("La especialidad se ha modificado");
                        limpiarGeneral();
                    }
                    MessageBox.Show("Error al modificar los datos intente de nuevo");
                    limpiarGeneral();
                }
                else {

                    MessageBox.Show("La especialidad no existe");
                    limpiarGeneral();
                }
            }
            else {
                MessageBox.Show("El Codigo de Profesor no existe");
                limpiarGeneral();
            }
        }
        #endregion



        #region metodos funcionales
        public Boolean verificarBlancos()
        {
            Boolean veri = true;


            if (txtCodEsp.Text.Trim() == "")
            {

                errorProvider1.SetError(txtCodEsp, "Debe ingresar el codigo de la especialidad por titulo");
                MessageBox.Show("Debe ingresar el codigo de la especialidad por titulo");
                veri = false;
            }
            else if (txtCodigoProfesor.Text.Trim() == "")
            {
                veri = false;
                errorProvider1.SetError(txtNombre, "Debe ingresar el codigo de la especialidad por titulo");
                MessageBox.Show("Debe ingresar el codigo de la especialidad por titulo");
                veri = false;
            }
            else if (txtNombre.Text.Trim() == "")
            {
                veri = false;
                errorProvider1.SetError(txtNombre, "Debe ingresar Nombre de la especialidad por titulo");
                MessageBox.Show("Debe ingresar Nombre de la especialidad por titulo");
                veri = false;
            }
            else if (txtDescripcion.Text.Trim() == "")
            {
                errorProvider1.SetError(txtDescripcion, "Debe ingresar la descripcion de la especialidad por titulo");
                MessageBox.Show("Debe ingresar la descripcion de la especialidad por titulo");
                veri = false;
            }
            else if (txtInstitucion.Text.Trim() == "")
            {
                errorProvider1.SetError(txtInstitucion, "Debe ingresar la institucion de la especialidad por titulo");
                MessageBox.Show("Debe ingresar la institucion de la especialidad por titulo");
                veri = false;

            }
            return veri;
        }

        public Boolean verificarModificar() {
            Boolean veri = true;
            if (txtCodEsp.Text.Trim() == "")
            {

                errorProvider1.SetError(txtCodEsp, "Debe ingresar el  codigo de la especialidad por titulo");
                MessageBox.Show("Debe ingresar el  codigo de la especialidad por titulo");
                veri = false;
            }
            else if (txtNombre.Text.Trim() == "")
            {
                veri = false;
                errorProvider1.SetError(txtNombre, "Debe ingresar el nombre de la especialidad por titulo");
                MessageBox.Show("Debe ingresar el nombre de la especialidad por titulo");
                veri = false;
            }
            else if (txtDescripcion.Text.Trim() == "")
            {
                errorProvider1.SetError(txtDescripcion, "Debe ingresar la descripcion de la especialidad por titulo");
                MessageBox.Show("Debe ingresar la descripcion de la especialidad por titulo");
                veri = false;
            }
            else if (txtInstitucion.Text.Trim() == "")
            {
                errorProvider1.SetError(txtInstitucion, "Debe ingresar la institucion de la especialidad por titulo");
                MessageBox.Show("Debe ingresar la institucion de la especialidad por titulo");
                veri = false;

            }
            return veri;

        }

        private void cargarDataGrit()
        {
            dgEspecialidadTitulo.DefaultCellStyle.ForeColor = Color.Black;
            dgEspecialidadTitulo.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            datosEsp = logicaEspecialidadTituloProfe.mConsultarGeneral(conexion);

            if (datosEsp != null)
            {
                DataTable miTabla = new DataTable();
                miTabla.Load(datosEsp);
                dgEspecialidadTitulo.DataSource = miTabla;
            }
        }

        public void cargarCodigo()
        {
            int num = 0;
            num = logicaEspecialidadTituloProfe.idConsecutivo(conexion);
            txtCodEsp.Text = Convert.ToString(num);

        }
        public void limpiarGeneral()
        {
            cargarCodigo();
            txtCodigoProfesor.Text = "";
            txtDescripcion.Text = "";
            txtInstitucion.Text = "";
            txtNombre.Text = "";


        }

        private void txtCodigoProfesor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;

            }
        }
        private Boolean verifarExistenciaidTitulo(int codigo)
        {
            Boolean veri = false;
            datosEsp = logicaEspecialidadTituloProfe.mConsultarGeneral(conexion);
            if (datosEsp != null)
            {
                while (datosEsp.Read())
                {
                    if (datosEsp.GetInt32(0) == codigo)
                    {
                        veri = true;
                    }
                }
            }

            return veri;
        }
        private Boolean verifarExistenciaProfesor(string codigo)
        {
            Boolean veri = false;
            datosEsp = datosProfe.mConsultaGeneral(conexion);
            if (datosEsp != null)
            {
                while (datosEsp.Read())
                {
                    if (datosEsp.GetString(8).Equals(codigo))
                    {

                        veri = true;
                    }
                }
            }

            return veri;
        }

        private int buscarCodigoProfesor(string codigo)
        {
           int codProfe = 0;
            datosEsp = datosProfe.mConsultaGeneral(conexion);
            if (datosEsp != null)
            {
                while (datosEsp.Read())
                {
                    if (datosEsp.GetString(8).Equals( codigo))
                    {
                        codProfe = datosEsp.GetInt32(0);
                    }
                }
            }

            return codProfe;
        }
        public Boolean comparacionDatos(int codProfe, int codTitulo)
        {
            Boolean veri = false;
            datosEsp = logicaEspecialidadTituloProfe.mConsultarTablaEspecialidad(conexion, codProfe, codTitulo);
            if (datosEsp != null)
            {
                while (datosEsp.Read())
                {

                    if (datosEsp.GetInt32(0) == codProfe && datosEsp.GetInt32(1) == codTitulo)
                    {

                        veri = true;
                    }
                }
            }
            return veri;
        }

        #endregion


        private void dgEspecialidadTitulo_MouseClick(object sender, MouseEventArgs e)
        {

            txtCodEsp.Text = dgEspecialidadTitulo.CurrentRow.Cells["idEspecialidad"].Value.ToString();
            txtNombre.Text = dgEspecialidadTitulo.CurrentRow.Cells["nombre"].Value.ToString();
            txtDescripcion.Text = dgEspecialidadTitulo.CurrentRow.Cells["descripcion"].Value.ToString();
            txtInstitucion.Text = dgEspecialidadTitulo.CurrentRow.Cells["institucion"].Value.ToString();
            txtCodEsp.Text = dgEspecialidadTitulo.CurrentRow.Cells["idEspecialidad"].Value.ToString();
        }
    }
}
