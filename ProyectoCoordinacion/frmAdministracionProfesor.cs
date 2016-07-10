/**
 * Creado: Kevin Suárez Cubero
 * Fecha: 15/6/2016
 * **/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using LogicaNegocios;
using AccesoDatos;
using Entidades;
using System.Data.SqlClient;

namespace Vista
{
    public partial class frmAdministracionProfesor : Form
    {
        #region Atributos
        OpenFileDialog curriculum;
        OpenFileDialog imagen;
        clProfesor logicaProfesores;
        clTelefonos logicaTelefonos;
        clCorreo logicaCorreos;
        clConexion conexion;
        clEntidadProfesor entidadProfesor;
        clEntidadTelefonos entidadTelefono;
        private string tipoPersona;
        clEntidadCorreos entidadCorreo;
        byte[] contenidoImg;
        byte[] contenidoCurriculum;
        frmTituloProfesor titulosProfe;
        frmEspecialidaProfesorTitulo especialidadTituloProfe;
        frmConsultaProferores ventanaConsultaProfesores;
        SqlDataReader datosProfesor, datosTelefono, datosCorreos;
        String rutaFoto;
        String rutaCurriculum;
        private int idEntidadProfesor;
        #endregion

        #region constructor
        public frmAdministracionProfesor(frmTituloProfesor titulosProfe, frmConsultaProferores ventanaConsultaProfesores,frmEspecialidaProfesorTitulo especialidadTituloProfe, clConexion conexion, clProfesor logicaProfesores, clEspecialidadTituloProfesor logicaEspecialidad) 
        {
            InitializeComponent();
            this.conexion = conexion;
            this.curriculum = new OpenFileDialog();
            this.imagen = new OpenFileDialog();
            this.logicaProfesores = logicaProfesores;
            this.logicaTelefonos = new clTelefonos();
            this.logicaCorreos = new clCorreo();
            this.tipoPersona = "PROFESOR";
            this.limpiarLvs();
            this.titulosProfe = titulosProfe;
            this.ventanaConsultaProfesores = ventanaConsultaProfesores;
            this.especialidadTituloProfe = especialidadTituloProfe;
            this.rutaCurriculum = "";
            this.rutaFoto = "";

        }
        #endregion


        #region Acciones y botones

        private void frmAdministracionProfesor_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            dtFechaNacimiento.Format = DateTimePickerFormat.Custom;
            dtFechaNacimiento.CustomFormat = "yyyy-MM-dd";

        }
        /**
        * Metodos de eventos de botones
       **/


        private void btnAgregarEspTitulo_Click(object sender, EventArgs e)
        {
            especialidadTituloProfe.Show();
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            descargarCurriculum();
        }

        private void btnEliminarProfesor_Click(object sender, EventArgs e)
        {
            if (idEntidadProfesor !=0)
            {
                if (mensajeEliminarAlgo("Esta seguro que desea eliminar al profesor.") == DialogResult.Yes)
                {
                    if (logicaProfesores.mEliminar(conexion, idEntidadProfesor))
                    {
                        mensajeAviso("Se elimino correctamente el profesor.");
                        limpiarGBInformacion1();
                        limpiarLvs();
                    }else
                    {
                        mensajeError("Se produjo un error en los datos.");
                    }
                }
            }else
            {
                mensajeAviso("Verifique los datos y vuelva a intentar.");
            }
        }

       
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            String cedula = "";
            if (verificarGBInformacion1())
            {
                datosProfesor = logicaProfesores.mConsultaPoridentificacion(conexion, txtIdentificacion.Text);
                if (datosProfesor != null)
                {
                    while (datosProfesor.Read())
                    {
                        cedula = datosProfesor.GetString(8);
                    }

                    if (cedula != txtIdentificacion.Text)
                    {
                        string fechaNac = string.Format(dtFechaNacimiento.Value.ToString("yyyy-MM-dd"));
                        try
                        {
                            //cargar foto en un buffer
                            FileInfo info = new FileInfo(rutaFoto);
                            long longitud = info.Length;
                            FileStream stream = new FileStream(this.rutaFoto, FileMode.Open, FileAccess.Read, FileShare.Read);
                            BinaryReader binario = new BinaryReader(stream);
                            contenidoImg = binario.ReadBytes((int)longitud);

                            //cargar curriculum en un buffer
                            FileInfo infor = new FileInfo(rutaCurriculum);
                            long longit = info.Length;
                            FileStream strm = new FileStream(this.rutaCurriculum, FileMode.Open, FileAccess.Read, FileShare.Read);
                            BinaryReader binary = new BinaryReader(strm);
                            contenidoCurriculum = binary.ReadBytes((int)longit);

                        }
                        catch (Exception ev)
                        {
                            throw new Exception(ev.Message);
                        }
                        clEntidadProfesor entidadProf = new clEntidadProfesor();

                        entidadProf.setIdProfesor(logicaProfesores.idConsecutivo(conexion));
                        entidadProf.setNombre(this.txtNombre.Text.Trim());
                        entidadProf.setApellido1(txtApellido1.Text.Trim());
                        entidadProf.setApellido2(txtApellido2.Text.Trim());
                        entidadProf.setGenero(cbGenero.Text.Trim());
                        entidadProf.setFechaNaci(fechaNac);
                        if (cbJornada.Text.Trim().Equals("COMPLETA")) { entidadProf.setJornada("1"); }
                        else { entidadProf.setJornada(cbJornada.Text.Trim()); }

                        entidadProf.setEstado(cbEstado.Text.Trim());
                        entidadProf.setTipoIden(cbTipoIdentificacion.Text.Trim());
                        entidadProf.setIdentificacion(txtIdentificacion.Text.Trim());
                        entidadProf.setFoto(contenidoImg);
                        entidadProf.setCurriculum(contenidoCurriculum);


                        if (entidadProf != null)
                        {
                            if (logicaProfesores.mInsertar(conexion, entidadProf))
                            {
                                limpiarGBInformacion1();
                                
                                mensajeAviso("El profesor fue ingresado correctamente.");

                            }
                            else
                            {
                                mensajeError("Se produjo un error al ingresar el profesor, vuelva a intentarlo.");
                            }
                        }
                        else
                        {
                            mensajeError("Error en el ingreso de los datos.");
                        }

                        for (int i = 0; i < lvTelefonos.Items.Count; i++)
                        {// Inicio del for que agrega cada telefono despues de agregar el profesor.
                            if (lvTelefonos != null)
                            {// condicion para evitar violacion de la entidad referecial. Ya que no es necesario guardar de una ves los telefonos del profesor, los puede agregar despues.
                                entidadTelefono = new clEntidadTelefonos();
                                entidadTelefono.setIdTelefono(logicaTelefonos.idConsecutivo(this.conexion));
                                entidadTelefono.setTelefono(Convert.ToInt32(lvTelefonos.Items[i].SubItems[0].Text));
                                entidadTelefono.setIdPersona((logicaProfesores.idConsecutivo(this.conexion) - 1));
                                entidadTelefono.setTipoPers(this.tipoPersona);
                                logicaTelefonos.mInsertar(this.conexion, entidadTelefono);
                            }// fin condicion de diferente de null.         
                        }// fin del for que agrega cada telefono despues de agregar el profesor.

                        for (int i = 0; i < lvCorreos.Items.Count; i++)
                        {
                            if (lvCorreos != null)
                            {
                                entidadCorreo = new clEntidadCorreos();
                                entidadCorreo.setIdCorreo(logicaCorreos.idConsecutivo(this.conexion));
                                entidadCorreo.setIdPersona((logicaProfesores.idConsecutivo(this.conexion) - 1));
                                entidadCorreo.setTipoPers(this.tipoPersona);
                                entidadCorreo.setCorreo(this.txtEmail.Text);
                                logicaCorreos.mInsertar(this.conexion, entidadCorreo);
                            }
                        }
                        this.limpiarLvs();
                    }
                    else
                    {
                        mensajePeligro("La identificacion del usuario ya existe.");
                    }

                }
                else
                {
                    mensajeError("Debe completar el formulario");
                }
            }
            
        }//Fin del evento del btnAgregar profesores.

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventanaConsultaProfesores.ShowDialog();
            int idProfesor = ventanaConsultaProfesores.mDevolverFila();
            mBuscarPorID(idProfesor);
        }

        private void btnModificar_Click(object sender, EventArgs e)//problema ahi que cambiar la imagen y el curriculum para poder modificar
        {
            if (verificarGBInformacion1())
            {
                string fechaNac = string.Format(dtFechaNacimiento.Value.ToString("yyyy-MM-dd"));
                try
                {
                    //cargar foto en un buffer
                    FileInfo info = new FileInfo(rutaFoto);
                    long longitud = info.Length;
                    FileStream stream = new FileStream(this.rutaFoto, FileMode.Open, FileAccess.Read, FileShare.Read);
                    BinaryReader binario = new BinaryReader(stream);
                    contenidoImg = binario.ReadBytes((int)longitud);

                    //cargar curriculum en un buffer
                    FileInfo infor = new FileInfo(rutaCurriculum);
                    long longit = info.Length;
                    FileStream strm = new FileStream(this.rutaCurriculum, FileMode.Open, FileAccess.Read, FileShare.Read);
                    BinaryReader binary = new BinaryReader(strm);
                    contenidoCurriculum = binary.ReadBytes((int)longit);

                }
                catch (Exception ev)
                {
                    throw new Exception(ev.Message);
                }
                clEntidadProfesor entidadProfesor = new clEntidadProfesor();

                entidadProfesor.setIdProfesor(idEntidadProfesor);
                entidadProfesor.setNombre(this.txtNombre.Text.Trim());
                entidadProfesor.setApellido1(txtApellido1.Text.Trim());
                entidadProfesor.setApellido2(txtApellido2.Text.Trim());
                entidadProfesor.setGenero(cbGenero.Text.Trim());
                entidadProfesor.setFechaNaci(fechaNac);
                if (cbJornada.Text.Trim().Equals("COMPLETA")) { entidadProfesor.setJornada("1"); }
                else { entidadProfesor.setJornada(cbJornada.Text.Trim()); }

                entidadProfesor.setEstado(cbEstado.Text.Trim());
                entidadProfesor.setTipoIden(cbTipoIdentificacion.Text.Trim());
                entidadProfesor.setIdentificacion(txtIdentificacion.Text.Trim());
                entidadProfesor.setFoto(contenidoImg);
                entidadProfesor.setCurriculum(contenidoCurriculum);
                if (entidadProfesor != null)
                {
                    mensajeAviso(entidadProfesor.getIdProfesor() + "");
                    if (logicaProfesores.mModificar(conexion, entidadProfesor))
                    {
                        mensajeAviso("Se modifico al profesor.");
                        limpiarGBInformacion1();
                        limpiarLvs();
                    }
                    else
                    {
                        mensajeError("Se produjo un error, vuelva a intentarlo.");
                    }
                }
            }
            else
            {
                mensajePeligro("Verifique que la informacion este correcta.");
            }
        }

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            //crea un nuevo openfiledialog para cargar un archivo

            //permite que se muestre la ventana para seleccionar la imagen
            OpenFileDialog result = new OpenFileDialog();
            result.Filter = "*.bmp;*.gif;*.jpg;*.png|*.bmp;*.gif;*.jpg;*.png";
            result.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            result.Title = "Seleccione una Imagen de perfil para el profesor";
            result.RestoreDirectory = true;

            //verifica la respuesta del openfile
            if (result.ShowDialog() == DialogResult.OK)
            {
                    //Carga la imagen en el picturebox
                    pbImagen.Image = Image.FromFile(result.FileName);

                    //permite el auto ajuste de la imagen al tamaño del picturebox
                    pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                    contenidoImg = File.ReadAllBytes(result.FileName);
                     rutaFoto = result.FileName;
            }
            else
            {
                mensajeError("El formato de la imagen no es compatible.");
            }
        }//fin metodo btnCargar foto

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog result = new OpenFileDialog();
            result.Filter = "*.odt;*.docx;|*.odt;*.docx;";
            result.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            result.Title = "Seleccione un archivo de de curriculum para el profesor";
            result.RestoreDirectory = true;

            if (result.ShowDialog() == DialogResult.OK)
            {
                txtDireccionArchivo.Text = result.FileName;
                this.rutaCurriculum = result.FileName;
                contenidoCurriculum = File.ReadAllBytes(result.FileName);
                this.rutaCurriculum = result.FileName;

            }
            else
            {
                mensajeError("El formato del documento no es compatible.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.limpiarGBInformacion1();

            this.Hide();
        }

        private void btnAgregarTitulo_Click(object sender, EventArgs e)
        {
            this.titulosProfe.Show(); ;

        }
 
        private void btnAgregarTelefono_Click(object sender, EventArgs e)
        {
            if (this.txtTelefono.Text == "")
            {
                this.mensajePeligro("Debe un numero de telefono.");
            }
            else
            {
                ListViewItem lista;
                lista = lvTelefonos.Items.Add(this.txtTelefono.Text);
                this.txtTelefono.Text = "";
            }// fin del else que agrega a la base de datos
        }// fin del evento del boton agregar.

        private void btnBuscarPorIdentificacion_Click(object sender, EventArgs e)
        {
            if (txtIdentificacion.Text.Trim() != "")
            {
                datosProfesor = logicaProfesores.mConsultaPoridentificacion(conexion, txtIdentificacion.Text.Trim());
                if (datosProfesor != null)
                {
                    datosTelefono = logicaTelefonos.getTelefonos(conexion, Convert.ToInt32(txtIdentificacion.Text.Trim()));
                    datosCorreos = logicaCorreos.getCorreos(conexion, Convert.ToInt32(txtIdentificacion.Text.Trim()));
                    while (datosProfesor.Read())
                    {
                        idEntidadProfesor = datosProfesor.GetInt32(0);
                        txtIdentificacion.Text = datosProfesor.GetString(8);
                        cbTipoIdentificacion.Text = datosProfesor.GetString(9);
                        txtNombre.Text = datosProfesor.GetString(1);
                        txtApellido1.Text = datosProfesor.GetString(2);
                        txtApellido2.Text = datosProfesor.GetString(3);
                        cbGenero.Text = datosProfesor.GetString(4);
                        dtFechaNacimiento.Text =Convert.ToString( datosProfesor.GetDateTime(5));
                        if (datosProfesor.GetString(6).Equals("1")) { cbJornada.Text = "COMPLETA"; cbJornada.SelectedIndex = 0; }
                        else {
                            cbJornada.Text = datosProfesor.GetString(6);
                        }
                        cbEstado.Text= datosProfesor.GetString(7);
                        cargarImagenDesdeBD(datosProfesor.GetStream(10));
                        cargarCurriculumDesdeBD(datosProfesor.GetStream(11), datosProfesor.GetString(2), datosProfesor.GetString(8));
                        btnEliminarProfesor.Enabled = true;
                        btnModificar.Enabled = true;
                        btnBuscar.Enabled = false;
                        btnBuscarPorIdentificacion.Enabled = false;
                        btnAgregar.Enabled = false;
                    }
                }
                else if(datosProfesor == null)
                {
                    mensajeAviso("No existe un profesor asociado a esa identificacion.");
                }
                /*  if (datosCorreos.Read () != null) {


                          DataTable miTabla = new DataTable();
                          miTabla.Load(datosCorreos);
                          dataGridView1.DataSource = miTabla;
                      }
                      if (datosTelefono.Read() != null) {

                          DataTable miTabla = new DataTable();
                          miTabla.Load(datosTelefono);
                          dataGridView1.DataSource = miTabla;
                      }*/

            }
            else
            {
                mensajeAviso("Introduzca la identificacion del profesor.");
            }
        }
        private void cargarImagenDesdeBD(Stream ms)
        {
            try {
            // Se crea un MemoryStream a partir de ese buffer
            //System.IO.MemoryStream ms = new System.IO.MemoryStream(img);
            pbImagen.Image = Image.FromStream(ms);
            pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cargarCurriculumDesdeBD(Stream ms,String cedula,String nombreProfe)
        {
            try
            {

                txtDireccionArchivo.Text = "Curriculum_" + nombreProfe + "_" + cedula + ".docx";


            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void descargarCurriculum()
        {
            String nombreProf = "";
            String apellido1 = "";
            String apellido2 = "";
            String cedula = "";
            Stream ms = null;
            if (txtDireccionArchivo.Text.Equals(""))
            {
                mensajeAviso("Debe buscar un Profesor antes de proceder a descargar su curriculum");
            }
            else
            {
                datosProfesor = logicaProfesores.mConsultaPoridentificacion(conexion, txtIdentificacion.Text.Trim());
                if (datosProfesor != null)
                {
                    while (datosProfesor.Read())
                    {
                        nombreProf = datosProfesor.GetString(1);
                        apellido1 = datosProfesor.GetString(2);
                        apellido2 = datosProfesor.GetString(3);

                        cedula = datosProfesor.GetString(8);
                        ms = datosProfesor.GetStream(11);
                    }
                    try
                    {
                        DialogResult dialogResult = MessageBox.Show("¿Qué desea hacer con el curriculum del Profesor "+ nombreProf+" " + apellido1+"  "+ apellido2 + " ?\nPresione SI para editar el documento. \nNO Para solamente descargarlo ", "Confrimar descarga curriculum", MessageBoxButtons.YesNoCancel);
                        if (dialogResult == DialogResult.Yes)
                        {
                            BinaryReader binary = new BinaryReader(ms);
                            byte[] bits = binary.ReadBytes((int)ms.Length);
                            string sFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Curriculum_" + nombreProf + "_" + cedula + ".docx";///////////////////
                            FileStream fs = new FileStream(sFile, FileMode.Create);
                            //Y escribimos en disco el array de bytes que conforman
                            //el fichero Word
                            fs.Write(bits, 0, Convert.ToInt32(bits.Length));
                            fs.Close();
                            System.Diagnostics.Process obj = new System.Diagnostics.Process();
                            obj.StartInfo.FileName = sFile;
                            obj.Start();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            BinaryReader binary = new BinaryReader(ms);
                            byte[] bits = binary.ReadBytes((int)ms.Length);
                            string sFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Curriculum_" + nombreProf + "_" + cedula + ".docx";
                            FileStream fs = new FileStream(sFile, FileMode.Create);
                            fs.Write(bits, 0, Convert.ToInt32(bits.Length));
                            fs.Close();
                            System.Diagnostics.Process obj = new System.Diagnostics.Process();
                            //Y escribimos en disco el array de bytes que conforman
                            //el fichero Word
                            mensajeAviso("El curriculum del profesor fue descargado exitosamente, se encuentra ubicado en \n" +
                                sFile);
                        }
                        else if (dialogResult == DialogResult.Cancel)
                        {
                            limpiarGBInformacion1();
                         }

                        }

                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        public void limpiarLvs()
        {
            this.lvCorreos.Items.Clear();
            this.lvTelefonos.Items.Clear();
        }
        #region errorprovider
        /**
         * Metodos de vaidacion error provider
         * Metodos de validacion de espacion en blanco y formato de correo
         * **/
        private void txtIdentificacion_Validated(object sender, EventArgs e)
        {
            if (txtIdentificacion.Text.Trim() == "")
            {
                epError.SetError(txtIdentificacion, "Introduzca la identificación.");
                txtIdentificacion.Focus();
            }
        }

        private void cbTipoIdentificacion_Validated(object sender, EventArgs e)
        {
            if (cbTipoIdentificacion.Text.Trim() == "")
            {
                epError.SetError(cbTipoIdentificacion, "Debe seleccionar un item.");
                cbTipoIdentificacion.Focus();
            }
        }

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                epError.SetError(txtNombre, "Introduzca el nombre.");
                txtNombre.Focus();
            }
        }

        private void txtApellido1_Validated(object sender, EventArgs e)
        {
            if (txtApellido1.Text.Trim() == "")
            {
                epError.SetError(txtApellido1, "Introduzca el primer apellido.");
                txtApellido1.Focus();
            }
        }

        private void txtApellido2_Validated(object sender, EventArgs e)
        {
            if (txtApellido2.Text.Trim() == "")
            {
                epError.SetError(txtApellido2, "Introduzca segundo apellido.");
                txtApellido2.Focus();
            }
        }

        private void cbGenero_Validated(object sender, EventArgs e)
        {
            if (cbGenero.Text.Trim() == "")
            {
                epError.SetError(cbGenero, "Debe seleccionar el genero.");
                cbGenero.Focus();
            }
        }

        private void dtFechaNacimiento_Validated(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(dtFechaNacimiento.Text.Trim()).Date.CompareTo(DateTime.Now.Date) == 0 || Convert.ToDateTime(dtFechaNacimiento.Text.Trim()).Date.CompareTo(DateTime.Now.Date) >= 1)
            {
                epError.SetError(dtFechaNacimiento, "La fecha Ingresada es Incorrecta.");
                dtFechaNacimiento.Focus();
            }
        }

        private void cbEstado_Validated(object sender, EventArgs e)
        {
            if (cbEstado.Text.Trim() == "")
            {
                epError.SetError(cbEstado, "Debe seleccionar el estado.");
                cbEstado.Focus();
            }
        }

        private void txtDireccionArchivo_Validated(object sender, EventArgs e)
        {
            if (txtDireccionArchivo.Text.Trim() == "")
            {
                epError.SetError(txtDireccionArchivo, "Debe cargar el curriculum.");
                txtDireccionArchivo.Focus();
            }
        }
        #endregion

        /**
        Agrega a la lista para despues insertarlas en la base datos. 
        **/
        private void btnAgregarCorreo_Click(object sender, EventArgs e)
        {
            String expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (this.txtEmail.Text == "")
            {
                this.mensajePeligro("Debe Agregar el Correo");
            }

            else if (Regex.IsMatch(txtEmail.Text, expresion))
            {
                if (Regex.Replace(txtEmail.Text, expresion, string.Empty).Length == 0)
                {
                    ListViewItem lista;
                    lista = lvCorreos.Items.Add(this.txtEmail.Text);
                    this.txtEmail.Text = "";
                }
                else
                {
                    this.mensajeError("Formato de Correo incorrecto.");
                    this.txtEmail.Text = "";
                }
            }
            else
            {
                this.mensajeError("Formato de Correo incorrecto.");
                this.txtEmail.Text = "";
            }
        }


        public Boolean verificarGBInformacion1()
        {
            foreach(Control control in gbInformacion1.Controls)
            {
                if(control.GetType().Equals(typeof(TextBox)) || control.GetType().Equals(typeof(ComboBox)))
                {
                    if (control.Text.Equals(""))
                    {
                        return false;
                    }
                }
                else if(rutaFoto.Equals(""))
                {
                    return false;
                }
                else if (rutaCurriculum.Equals(""))
                {
                    return false;
                }
            }
            return true;
        }

        public void limpiarGBInformacion1()
        {
            foreach(Control control in gbInformacion1.Controls)
            {
                if(control.GetType().Equals(typeof(TextBox)))
                {
                    control.Text = "";
                }else if (control.GetType().Equals(typeof(ComboBox)))
                {
                    control.ResetText();
                }
                else if (control.GetType().Equals(typeof(DateTimePicker)))
                {
                    control.ResetText();
                }
                this.pbImagen.Image = null;
                this.cbEstado.SelectedIndex=-1;
                this.cbGenero.SelectedIndex = -1;
                this.cbTipoIdentificacion.SelectedIndex = -1;
                this.cbJornada.SelectedIndex = -1;
                btnEliminarProfesor.Enabled = false;
                btnModificar.Enabled = false;
                btnAgregar.Enabled = true;
                btnBuscar.Enabled = true;
                btnBuscarPorIdentificacion.Enabled = true;
            }
        }

       /* public Boolean verificacionCurriculum(OpenFileDialog openFile)
        {
            string[] extenciones = new string[] { "odt","docx" };
            string extencionArchivo = openFile.FileName.Split('.').Last();
            foreach (string ext in extenciones)
            {
                if (extencionArchivo == ext)
                {
                    return true;
                }
            }

            return false;
        }//fin metodo verificar formatoCurriculum*/

        #endregion

        #region Metodos manejo de archivos
        /**
         * metodo cara cargar un archivo a la base de datos
         * **/
        public Byte[] cargarImagen(OpenFileDialog openFile)
        {
            Byte[] bytes = File.ReadAllBytes(openFile.FileName);
            return bytes;
        }

        public void mBuscarPorID(int idProfesor)
        {

            if (idProfesor != 0)
            {

                datosProfesor = logicaProfesores.mConsultaPorCodigo(conexion, idProfesor);
                if (datosProfesor != null)
                {
                    datosTelefono = logicaTelefonos.getTelefonos(conexion, idProfesor);
                    datosCorreos = logicaCorreos.getCorreos(conexion, idProfesor);
                    while (datosProfesor.Read())
                    {
                        idEntidadProfesor = datosProfesor.GetInt32(0);
                        txtIdentificacion.Text = datosProfesor.GetString(8);
                        cbTipoIdentificacion.Text = datosProfesor.GetString(9);
                        txtNombre.Text = datosProfesor.GetString(1);
                        txtApellido1.Text = datosProfesor.GetString(2);
                        txtApellido2.Text = datosProfesor.GetString(3);
                        cbGenero.Text = datosProfesor.GetString(4);
                        dtFechaNacimiento.Text = Convert.ToString(datosProfesor.GetDateTime(5));
                        if (datosProfesor.GetString(6).Equals("1")) { cbJornada.Text = "COMPLETA"; cbJornada.SelectedIndex = 0; }
                        else
                        {
                            cbJornada.Text = datosProfesor.GetString(6);
                        }
                        cbEstado.Text = datosProfesor.GetString(7);
                        cargarImagenDesdeBD(datosProfesor.GetStream(10));
                        cargarCurriculumDesdeBD(datosProfesor.GetStream(11), datosProfesor.GetString(2), datosProfesor.GetString(8));
                        btnModificar.Enabled = true;
                        btnEliminarProfesor.Enabled = true;
                        btnAgregar.Enabled = false;
                    }
                }
            }
        }

        #endregion

        #region mensajes

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
        }

        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;

            }
        }

        public DialogResult mensajeEliminarAlgo(String mensaje)
        {
            return MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.YesNo);

        }

        #endregion

        private void lvTelefonos_TabIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lvTelefonos.Items.Count; i++)
            {
                if (lvTelefonos.Items[i].Selected)
                {
                    this.txtTelefono.Text = lvTelefonos.Items[i].Text;//se llena la variable con el texto que esta en la lista
                }
            }
        }

       
        
      /*  private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;


            }
        }*/
    }// fin de la clase.
}// fin del nameSpace
