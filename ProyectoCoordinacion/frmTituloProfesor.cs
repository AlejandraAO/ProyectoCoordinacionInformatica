using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using AccesoDatos;
using LogicaNegocios;
using System.Data.SqlClient;


namespace Vista
{
    public partial class frmTituloProfesor : Form
    {
        clEntidadTituloProfesor entidadTitulo;
        clsTitulosProfesor tituloProfesor;
        clProfesor logicadatosProfesor;
        clTitulos logicaProfesor;
        clConexion conexion;
        SqlDataReader datosTitulo, datosProfesor;
        #region
        public frmTituloProfesor(clConexion conexion)
        {
            this.conexion = conexion;
            tituloProfesor = new clsTitulosProfesor();
            logicadatosProfesor = new clProfesor();
            InitializeComponent();
            cargarConsecutivo();
            cargarDataGrit();
        }
        #endregion
        private void frmTituloProfesor_Load(object sender, EventArgs e)
        {
            string hora = string.Format(dtFecha.Value.ToString("yyyy/MM/dd"));/* Este es  codigo para usar el DateTime*/
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (verificarBlancos() == true)
            {
                int codTitulo = 0;
                int codProfe = 0;
                string hora = string.Format(dtFecha.Value.ToString("yyyy/MM/dd"));
                codTitulo = tituloProfesor.idConsecutivo(conexion);
                if (verifarExistenciaProfesor(txtCodigoProfesor.Text.Trim()) == true)
                {
                    if (conexion.mConectar(conexion))
                    {

                        if(verifarirTitulo(Convert.ToInt32(txtCodTitulo.Text.Trim()))== false) {
                            codProfe = cargarCodigoProfesor(txtCodigoProfesor.Text.Trim());
                            if (comparacionDatos(codProfe, Convert.ToInt32(txtCodTitulo.Text.Trim())) == false)
                            {
                                
                                entidadTitulo = new clEntidadTituloProfesor(Convert.ToInt32(txtCodTitulo.Text.Trim()), txtNombreTitulo.Text.Trim(), txtInstitucion.Text.Trim(), hora, txtTipoTitulo.Text.Trim());

                                if (tituloProfesor.mInsertar(conexion, entidadTitulo))
                                {
                                    if (tituloProfesor.mInsertarTtitulosProfesor(conexion, entidadTitulo,Convert.ToString( codProfe)))
                                    {
                                        MessageBox.Show("Titulo " + codTitulo + "  Agregado");
                                        limpiarTodo();
                                        cargarDataGrit();
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Informcion Incorrecta");
                                    limpiarTodo();
                                }
                            
                            }
                            else
                            {

                                MessageBox.Show("Este Titulo ya lo posee el profesor");
                                limpiarTodo();
                            }
                    } else {


                            MessageBox.Show("Este Titulo ya Existe");
                            limpiarTodo();

                        }
                    }
                }
                else
                {
                    MessageBox.Show("La Identificacion Digitada no existe");
                    limpiarTodo();
                }
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigoProfesor.Text.Trim() != "")
            {
                datosTitulo = tituloProfesor.mConsultaCodigoTitulo(conexion, Convert.ToInt32(txtCodTitulo.Text.Trim()));
                if (datosTitulo != null)
                {
                    tituloProfesor.mEliminar(conexion, entidadTitulo.getcodigo());
                }
            }


        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            int codProfe = 0;

            MessageBox.Show("Por Razones de seguridad el Codigo del Profesor No sera modificado");
            if (verificarmodificar() == true)
            {
                string hora = string.Format(dtFecha.Value.ToString("yyyy/MM/dd"));

                    if (conexion.mConectar(conexion))
                    {

                        if (verifarirTitulo(Convert.ToInt32(txtCodTitulo.Text.Trim())) == true)
                        {
                            codProfe = cargarCodigoProfesor(txtCodigoProfesor.Text.Trim());
                            entidadTitulo = new clEntidadTituloProfesor(codProfe, txtNombreTitulo.Text.Trim(), txtInstitucion.Text.Trim(), hora, txtTipoTitulo.Text.Trim());
                            if (tituloProfesor.mModificar(conexion, entidadTitulo))
                            {
                                MessageBox.Show("Titulo " + Convert.ToInt32(txtCodTitulo.Text.Trim()) + "  modificado");
                                limpiarTodo();
                                cargarDataGrit();
                            cargarConsecutivo();
                            }
                            else
                            {
                                MessageBox.Show("Informcion Incorrecta");
                                limpiarTodo();
                            }
                        }
                        else {
                            MessageBox.Show("El Titulo no existe");
                            limpiarTodo();
                            cargarDataGrit();
                                
                        }
                    }
               
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int codProfe = 0;
            if (verificarmodificar() == true)
            {
                int codTitulo = 0;
                string hora = string.Format(dtFecha.Value.ToString("yyyy/MM/dd"));
                codTitulo = tituloProfesor.idConsecutivo(conexion);
                if (verifarExistenciaProfesor(txtCodigoProfesor.Text.Trim()) == true)
                { 
                    if (verifarirTitulo(Convert.ToInt32(txtCodTitulo.Text.Trim())) ==true) { 
                    if (conexion.mConectar(conexion))

                    {
                        if (comparacionDatos(Convert.ToInt32(txtCodigoProfesor.Text.Trim()), Convert.ToInt32(txtCodTitulo.Text.Trim())) == false)
                        {
                                codProfe = cargarCodigoProfesor(txtCodigoProfesor.Text.Trim());

                                entidadTitulo = new clEntidadTituloProfesor(codProfe, txtNombreTitulo.Text.Trim(), txtInstitucion.Text.Trim(), hora, txtTipoTitulo.Text.Trim());

                            if (tituloProfesor.mInsertarTtitulosProfesor(conexion, entidadTitulo, Convert.ToString(codProfe)))
                            {
                                MessageBox.Show("Titulo " + txtCodTitulo.Text.Trim() + "  Agregado al\n" + "Profesor" + txtCodigoProfesor.Text.Trim());
                                limpiarTodo();
                                    cargarDataGrit();
                                    cargarConsecutivo();
                            }
                            else
                            {
                                MessageBox.Show("Informcion Incorrecta");
                                limpiarTodo();
                            }
                        }
                        else
                        {

                            MessageBox.Show("Este Titulo ya lo posee el profesor");
                        }
                    }
                }
                else {
                    MessageBox.Show("El Titulo no existe");
                }
                }
                else
                {
                    MessageBox.Show("La Identificacion Digitada no existe");
                    limpiarTodo();
                }
            }


        }



        private Boolean verificarBlancos()
        {
            Boolean veri = true;
            if (txtCodigoProfesor.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCodigoProfesor, "No hay codigo de titulo");
                txtCodigoProfesor.Focus();
                MessageBox.Show("No hay codigo de titulo");
                veri = false;
            }
            else if (txtNombreTitulo.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNombreTitulo, "Debe ingresar Nombre del titulo");
                veri = false;
                MessageBox.Show("Debe ingresar Nombre del titulo");
            }
            else if (txtTipoTitulo.Text.Trim() == "")
            {
                veri = false;
                errorProvider1.SetError(txtTipoTitulo, "Debe ingresar el tipo de titulo");
                MessageBox.Show("Debe ingresar el tipo de titulo");
            }
            else if (txtInstitucion.Text.Trim() == "")
            {
                errorProvider1.SetError(txtInstitucion, "Debe ingresar  nombre de la institucion");
                veri = false;
                MessageBox.Show("Debe ingresar  nombre de la institucion");
            }
            else if (Convert.ToDateTime(dtFecha.Text.Trim()).Date.CompareTo(DateTime.Now.Date) == 0 || Convert.ToDateTime(dtFecha.Text.Trim()).Date.CompareTo(DateTime.Now.Date) >= 1)
            {
                errorProvider1.SetError(dtFecha, "Debe ingresar una fecha correcta ");
                veri = false;
                MessageBox.Show("Debe ingresar una fecha correcta ");
            }
            return veri;
        }

       private Boolean verificarmodificar()
        {
            Boolean veri = true;
           
             if (txtNombreTitulo.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNombreTitulo, "Debe ingresar Nombre del titulo");
                veri = false;
                MessageBox.Show("Debe ingresar Nombre del titulo");
            }
            else if (txtTipoTitulo.Text.Trim() == "")
            {
                veri = false;
                errorProvider1.SetError(txtTipoTitulo, "Debe ingresar el tipo de titulo");
                MessageBox.Show("Debe ingresar el tipo de titulo");
            }
            else if (txtInstitucion.Text.Trim() == "")
            {
                errorProvider1.SetError(txtInstitucion, "Debe ingresar  nombre de la institucion");
                veri = false;
                MessageBox.Show("Debe ingresar  nombre de la institucion");
            }
            else if (Convert.ToDateTime(dtFecha.Text.Trim()).Date.CompareTo(DateTime.Now.Date) == 0 || Convert.ToDateTime(dtFecha.Text.Trim()).Date.CompareTo(DateTime.Now.Date) >= 1)
            {
                errorProvider1.SetError(dtFecha, "Debe ingresar una fecha correcta ");
                veri = false;
                MessageBox.Show("Debe ingresar una fecha correcta ");
            }
            return veri;
        }


        public void imprimerMensaje(string mensaje)
        {

            MessageBox.Show("   " + mensaje);
        }

        public void limpiarTodo()
        {
            txtCodigoProfesor.Text = "";
            txtInstitucion.Text = "";
            txtNombreTitulo.Text = "";
            txtTipoTitulo.Text = "";
        }




        private void txtCodigoTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;

            }
        }
        private Boolean verifarExistenciaProfesor(string codigo)
        {
            Boolean veri = false;
            datosProfesor = logicadatosProfesor.mConsultaGeneral(conexion);
            if (datosProfesor != null)
            {
                while (datosProfesor.Read())
                {
                    if (datosProfesor.GetString(8).Equals( codigo))
                    {
                        veri = true;
                    }
                }
            }

            return veri;
        }
        private int cargarCodigoProfesor(string codigo)
        {
            int idProfesor = 0;
            datosProfesor = logicadatosProfesor.mConsultaGeneral(conexion);
            if (datosProfesor != null)
            {
                while (datosProfesor.Read())
                {
                    if (datosProfesor.GetString(8).Equals( codigo))
                    {
                        idProfesor = datosProfesor.GetInt32(0);
                    }
                }
            }

            return idProfesor;
        }

        private Boolean verifarirTitulo(int codigo)
        {
            Boolean veri = false;
            datosProfesor = tituloProfesor.mConsultaCodigoTitulo(conexion, codigo);
            if (datosProfesor != null)
            {
                while (datosProfesor.Read())
                {
                    if (datosProfesor.GetInt32(0) == codigo)
                    {
                        veri = true;
                    }
                }
            }

            return veri;
        }
        private void cargarDataGrit()
        {
            dgListaTitulos.DefaultCellStyle.ForeColor= Color.Black;
            dgListaTitulos.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;

            datosTitulo = tituloProfesor.mConsultaGeneral(conexion);

            if (datosTitulo != null)
            {
                DataTable miTabla = new DataTable();
                miTabla.Load(datosTitulo);
                dgListaTitulos.DataSource = miTabla;
            }
        }

        private void dgListaTitulos_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            txtCodTitulo.Text = dgListaTitulos.CurrentRow.Cells["idTitulo"].Value.ToString();
            txtInstitucion.Text = dgListaTitulos.CurrentRow.Cells["nombre"].Value.ToString();
            txtNombreTitulo.Text = dgListaTitulos.CurrentRow.Cells["institucion"].Value.ToString();
            txtTipoTitulo.Text = dgListaTitulos.CurrentRow.Cells["tipo"].Value.ToString();

        }

        private void cargarConsecutivo()
        {
            txtCodTitulo.Text = Convert.ToString(tituloProfesor.idConsecutivo(conexion));
        }

        private void frmTituloProfesor_Load_1(object sender, EventArgs e)
        {

        }

        private void lbTipoIdentificacion_Click(object sender, EventArgs e)
        {

        }

        public Boolean comparacionDatos(int codProfe, int codTitulo)
        {
            Boolean veri = false;
            datosProfesor = tituloProfesor.ConsultaComparacionDatos(conexion, codProfe, codTitulo);
            if (datosProfesor != null)
            {
                while (datosProfesor.Read())
                {

                    if (datosProfesor.GetInt32(0) == codProfe && datosProfesor.GetInt32(1) == codTitulo)
                    {

                        veri = true;
                    }
                }
            }
            return veri;
        }

    }
}
