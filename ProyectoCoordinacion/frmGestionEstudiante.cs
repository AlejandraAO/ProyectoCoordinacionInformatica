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
using System.IO;
using AccesoDatos;
using LogicaNegocios;
using EntidadNegocios;

namespace Vista
{
    public partial class frmGestionEstudiante : Form
    {

        #region Atributos
        OpenFileDialog dialog;
        clConexion conexion;
        SqlDataReader dtrEstudiante;
        clEntidadEstudiante entEstudiante;
        clEntidadCurriculum entCurriculum;
        clCurriculum curriculum;
        clEstudiante estudiante;
        frmConsultaEstudiante consulta;
        string fecha;
        Boolean agregarEst;
        Boolean agregarCurri;
        menuPrincipal menuPrincipal;
        #endregion


        public frmGestionEstudiante(menuPrincipal menu)
        {
            conexion = new clConexion();
            entEstudiante = new clEntidadEstudiante();
            entCurriculum = new clEntidadCurriculum();
            estudiante = new clEstudiante();
            curriculum = new clCurriculum();
            dialog = new OpenFileDialog();
            menuPrincipal = menu;
            InitializeComponent();
        }

        private void frmGestionEstudiante_Load(object sender, EventArgs e)
        {
            dtrEstudiante = estudiante.mConsultaEmpresas(conexion);

            if (dtrEstudiante != null)
            {
                while (dtrEstudiante.Read())
                {
                    cbInstitucion.Items.Add(dtrEstudiante.GetString(1));
                }//fin while
            }

            WindowState = FormWindowState.Normal;
            dtFechaNacimiento.Format = DateTimePickerFormat.Custom;
            dtFechaNacimiento.CustomFormat = "yyyy-MM-dd";
        }

        //region donde se encuentran todos los metodos
        #region Metodos

        public Boolean validarCamposVacios()
        {
            if(txtCarnet.Text != "" && txtNombre.Text != "" && txtApellido1.Text != "" && 
               txtApellido2.Text != "" && txtCedula.Text != "" && cbGenero.Text != "" &&
               cbInstitucion.Text != "" && cbEstado.Text != "" )
            {
                return true;
            }//Fin del if
            else
            {
                return false;
            }
        }//Fin del metodo validar CamposVacios

        public void limpiar()
        {
            txtCarnet.Text = ""; txtNombre.Text = ""; txtApellido1.Text = "";
            txtApellido2.Text = ""; txtCedula.Text = ""; cbGenero.Text = "";
            cbInstitucion.Text = ""; cbEstado.Text = "";
            btnModificar.Enabled = false;
            btnIngresar.Enabled = false;
            txtCarnet.ReadOnly = false;
            btnEliminar.Enabled = false;
            cbInstitucion.Enabled = true;
            pictureBox1.Image = null;
            erpControl.Clear();
        }//fin metodo limpiar

        private void btnBusquedaRapida_Click(object sender, EventArgs e)
        {
            consulta = new frmConsultaEstudiante(conexion);
            consulta.ShowDialog();
            if (consulta.getCarnet() != "")
            {
                entEstudiante.setCarnet(consulta.getCarnet());
                txtCarnet.Text = consulta.getCarnet();
            }
        }

        public void obtenerID()
        {
            entEstudiante.setIdEstudiante(1);
            dtrEstudiante = estudiante.mConsultaGeneral(conexion);
            while (dtrEstudiante.Read())
            {
                //ListViewItem lista;
                //lista = dtrEstudiante.Items.Add(dtrEstudiante.GetString(1));
                //lista.SubItems.Add(dtrEstudiante.GetString(2));
                entEstudiante.setIdEstudiante((dtrEstudiante.GetInt32(0))+1);
            }//fin while
        }

        public int ontenerIDCorreos()
        {
            int id = 1;
            dtrEstudiante = estudiante.mConsultaGeneralCorreos(conexion);
            while (dtrEstudiante.Read())
            {
                id = dtrEstudiante.GetInt32(0) + 1;
            }//fin while
            return id;
        }
        public int obtenerIDTelefonos()
        {
            int id = 1;
            dtrEstudiante = estudiante.mConsultaGeneralTelefonos(conexion);
            while (dtrEstudiante.Read())
            {
                id = dtrEstudiante.GetInt32(0) + 1;
            }//fin while
            return id;
        }

        
        #endregion

        private void txtCarnet_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(validarCamposVacios())
            {
                entEstudiante.setCarnet(txtCarnet.Text.Trim());
                entEstudiante.setNombre(txtNombre.Text.Trim());
                entEstudiante.setApellido1(txtApellido1.Text.Trim());
                entEstudiante.setApellido2(txtApellido2.Text.Trim());
                entEstudiante.setCedula(Convert.ToInt32(txtCedula.Text));
                //entEstudiante.setFechaNacimiento("");
                fecha = string.Format(dtFechaNacimiento.Value.ToString("yyyy-MM-dd"));
                entEstudiante.setFechaNacimiento(fecha);
                //entEstudiante.setFechaNacimiento(cbDia.Text + "/" + obtenerNumeroMes(cbMes.Text) + "/" + cbAno.Text); //No se si funcionara así, es para ir adelantando codigo que lo pongo asi
                entEstudiante.setGenero(cbGenero.Text.Trim());
                entEstudiante.setInstitucion(cbInstitucion.Text.Trim());
                entEstudiante.setCarrera("Informatica Empresarial");

                if (pictureBox1.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    this.pictureBox1.Image.Save(ms, this.pictureBox1.Image.RawFormat);
                    entEstudiante.setFoto(ms.GetBuffer());
                } else
                {
                    entEstudiante.setFoto(null);
                }

                obtenerID();
               

                agregarEst = estudiante.mInsertar(conexion, entEstudiante);
               if (agregarEst==true)
                {
                    MessageBox.Show("El Estudiate se registro correctamente");
                    limpiar();
                }
               else
                {
                    MessageBox.Show("Lo sentimos, el estudiante no se registro.");
                }

            }
            else
            {
                MessageBox.Show("Por favor llene todos los campos que son requeridos.");
            }

        }//Fin del metodo del boton ingresar

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if(txtCarnet.Text != "")
            {
                erpControl.Clear();
                entEstudiante.setCarnet(txtCarnet.Text);
                dtrEstudiante = estudiante.mConsultarCarnet(conexion, entEstudiante);

                if(dtrEstudiante != null)
                {
                    if(dtrEstudiante.Read())
                    {

                        txtNombre.Text = dtrEstudiante.GetString(2);
                        txtApellido1.Text = dtrEstudiante.GetString(3);
                        txtApellido2.Text = dtrEstudiante.GetString(4);
                        txtCedula.Text = ""+dtrEstudiante.GetInt32(5);
                    
                        DateTime oDate = dtrEstudiante.GetDateTime(6);
                        dtFechaNacimiento.Value = oDate;

                        cbGenero.Text = dtrEstudiante.GetString(7);
                        cbInstitucion.Text = dtrEstudiante.GetString(8);

                        if (dtrEstudiante.GetString(8) == "UCR")
                        {
                            cbEstado.Text = "Activo";
                        }//fin if ucr
                        else
                        {
                            cbEstado.Text = "Egresado";
                        }//else ucr
                        
                        txtCarnet.ReadOnly = true;
                        btnModificar.Enabled = true;
                        btnEliminar.Enabled = true;

                    }//fin del if del read
                    else
                    {
                        DialogResult respuesta = MessageBox.Show("El usuario no existe, desea agregarlo", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (respuesta == DialogResult.OK)
                        {
                            this.txtCarnet.ReadOnly = true;
                            this.btnIngresar.Enabled = true;

                        }//fin if dialogResult
                    }//fin else read

                }//fin del if del null

            }//fin del if de txtCarnet 
            else
            {
                MessageBox.Show("Ingrese un Carnet");
                erpControl.SetError(txtCarnet, "Ingrese un carnet");
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            entEstudiante.setIdEstudiante(Int32.Parse(txtCarnet.Text));
            entEstudiante.setCarnet(txtCarnet.Text.Trim());
            entEstudiante.setNombre(txtNombre.Text.Trim());
            entEstudiante.setApellido1(txtApellido1.Text.Trim());
            entEstudiante.setApellido2(txtApellido2.Text.Trim());
            entEstudiante.setCedula(Convert.ToInt32(txtCedula.Text));
            fecha = string.Format(dtFechaNacimiento.Value.ToString("yyyy-MM-dd"));
            entEstudiante.setFechaNacimiento(fecha);
            //entEstudiante.setFechaNacimiento(cbDia.Text + "/" + obtenerNumeroMes(cbMes.Text) + "/" + cbAno.Text); //No se si funcionara así, es para ir adelantando codigo que lo pongo asi
            entEstudiante.setGenero(cbGenero.Text.Trim());
            entEstudiante.setInstitucion(cbInstitucion.Text.Trim());
            entEstudiante.setCarrera("Informatica Empresarial");

            if (pictureBox1.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                this.pictureBox1.Image.Save(ms, this.pictureBox1.Image.RawFormat);
                entEstudiante.setFoto(ms.GetBuffer());
            }
            else
            {
                entEstudiante.setFoto(null);
            }

            if (estudiante.mModificar(conexion, entEstudiante))
            {
                MessageBox.Show("La información del Estudiante de actualizó correctamente");
                limpiar();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error,\n Por favor verifique los datos, he inténtelo nuevamente");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (txtCarnet.Text != "")
            {
                DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea eliminar este estudiante?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.OK)
                {

                    entEstudiante.setCarnet(txtCarnet.Text.Trim());

                    if (estudiante.mEliminarEstudiante(conexion, entEstudiante))
                    {
                        MessageBox.Show("La información del Estudiante de actualizó correctamente");
                        limpiar();

                    }  //fin del if de mEliminarEstudiante
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error,\n Por favor verifique los datos, he inténtelo nuevamente");
                    }

                }//fin del if Dialog result

            }//fin del if carnet vacio
            

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            menuPrincipal.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnBuscarTelefono_Click(object sender, EventArgs e)
        {
            if (txtCarnet.Text != "")
            {
                erpControl.Clear();
                //entEstudiante.setCarnet(txtCarnet.Text);
                frmConsultaTelefono consulta = new frmConsultaTelefono(conexion, txtCarnet.Text);
                consulta.ShowDialog();
            }
            else {
                MessageBox.Show("Primero ingrese el carnet del usuario al que desea consultar los telefonos");
                erpControl.SetError(txtCarnet, "Ingrese un carnet");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Se crea el OpenFileDialog
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "Imagenes JPG|*.jpg|Imagenes PNG|*.png";
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dialog.FileName);

            }//Fin del if
        }

        private void cbEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbEstado.Text == "Activo")
            {
                cbInstitucion.Text = "UCR";
                cbInstitucion.Enabled = false;
            } else
            {
                cbInstitucion.Enabled = true;
            }
        }

        private void btnAgregarTelefono_Click(object sender, EventArgs e)
        {
            if (txtCarnet.Text != "")
            {
                int idEstudiante = 0;
                erpControl.Clear();

                entEstudiante.setCarnet(txtCarnet.Text);
                dtrEstudiante = estudiante.mConsultarCarnet(conexion, entEstudiante);
                if (dtrEstudiante.Read())
                {
                    idEstudiante = dtrEstudiante.GetInt32(0);

                    if (idEstudiante != 0)
                    {
                        if (estudiante.mIngresarTelefono(conexion, idEstudiante, Int32.Parse(txtTelefono.Text),obtenerIDTelefonos()))
                        {
                            MessageBox.Show("Telefono Agregado satisfactoriamente");
                        }
                        else
                        {
                            MessageBox.Show("Error al Ingresar el telefono");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El estudiante no existe\nVerifique el carnet");
                }
            }
            else
            {
                MessageBox.Show("Favor de ingresar un carnet primero");
                erpControl.SetError(txtCarnet,"Ingrese un carnet");
            }

        }

        private void btnAgregarCorreo_Click(object sender, EventArgs e)
        {
            if (txtCarnet.Text != "")
            {
                int idEstudiante = 0;
                erpControl.Clear();
                entEstudiante.setCarnet(txtCarnet.Text);
                dtrEstudiante = estudiante.mConsultarCarnet(conexion, entEstudiante);
                if (dtrEstudiante.Read())
                { 
                    idEstudiante = dtrEstudiante.GetInt32(0);

                    if (idEstudiante != 0)
                    {
                        if (estudiante.mIngresarCorreo(conexion, idEstudiante, Int32.Parse(txtCorreo.Text),ontenerIDCorreos()))
                        {
                            MessageBox.Show("Correo Agregado satisfactoriamente");
                        }
                        else
                        {
                            MessageBox.Show("Error al Ingresar el Correo");
                        }
                    }
                } else
                {
                    MessageBox.Show("El estudiante no existe\nVerifique el carnet");
                }   
            } else
            {
                MessageBox.Show("Favor de ingresar un carnet primero");
                erpControl.SetError(txtCarnet, "Ingrese un carnet");
            }
        }

        private void btnBuscarCorreo_Click(object sender, EventArgs e)
        {
            if (txtCarnet.Text != "")
            {
                erpControl.Clear();
                frmConsultaCorreo consulta = new frmConsultaCorreo(conexion,txtCarnet.Text);
            }
            else
            {
                MessageBox.Show("Primero ingrese el carnet del usuario al que desea consultar los correos");
                erpControl.SetError(txtCarnet, "Ingrese un carnet");
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            dialog.InitialDirectory = "c:\\";
            dialog.Filter = "PDF Document|*.PDF";
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = dialog.OpenFile())!=null)
                    {
                        using (myStream)
                        {
                            txtUrl.Text = dialog.FileName;
                        }
                        btnCancelarPdf.Enabled = true;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Curriculum Agregado satisfactoriamente"+ex.Message);
                }

            }

        }

        private void btnAgregarPdf_Click(object sender, EventArgs e)
        {
            int idEstudiante = 0;
            if (txtCarnet.Text != "")
            {
                erpControl.Clear();

                entEstudiante.setCarnet(txtCarnet.Text);
                dtrEstudiante = estudiante.mConsultarCarnet(conexion, entEstudiante);
                dtrEstudiante.Read();
                idEstudiante = dtrEstudiante.GetInt32(0);
                entCurriculum.setCurriculum(dialog.FileName);
                entCurriculum.setIdEstudiante(idEstudiante);



                if (idEstudiante != 0)
                {
                    //agregarCurri = curriculum.mInsertarCurriculum(conexion, entCurriculum);
                    if (curriculum.mInsertarCurriculum(conexion, entCurriculum))
                    {
                        MessageBox.Show("Curriculum Agregado satisfactoriamente");
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Error al Ingresar el Curriculum");
                        limpiar();
                    }
                }
            } else
            {
                MessageBox.Show("Primero ingrese el carnet del usuario al que desea consultar los correos");
                erpControl.SetError(txtCarnet, "Ingrese un carnet");
            }
        }

        private void btnCancelarPdf_Click(object sender, EventArgs e)
        {
            txtUrl.Text = "";
            erpControl.Clear();
            btnCancelarPdf.Enabled = false;
        }
    }//fin de la clase
}//fin del namespace
