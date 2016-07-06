namespace Vista
{
    partial class frmGestionEstudiante
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbAcessoUsuario = new System.Windows.Forms.GroupBox();
            this.cbInstitucion = new System.Windows.Forms.ComboBox();
            this.dtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBusquedaRapida = new System.Windows.Forms.Button();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbBotones = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnEliminarTelefono = new System.Windows.Forms.Button();
            this.btnAgregarTelefono = new System.Windows.Forms.Button();
            this.btnBuscarTelefono = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnEliminarCorreo = new System.Windows.Forms.Button();
            this.btnAgregarCorreo = new System.Windows.Forms.Button();
            this.btnBuscarCorreo = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCancelarPdf = new System.Windows.Forms.Button();
            this.btnAgregarPdf = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnPdf = new System.Windows.Forms.Button();
            this.erpControl = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbAcessoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbBotones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpControl)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAcessoUsuario
            // 
            this.gbAcessoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.gbAcessoUsuario.Controls.Add(this.cbInstitucion);
            this.gbAcessoUsuario.Controls.Add(this.dtFechaNacimiento);
            this.gbAcessoUsuario.Controls.Add(this.button1);
            this.gbAcessoUsuario.Controls.Add(this.pictureBox1);
            this.gbAcessoUsuario.Controls.Add(this.label11);
            this.gbAcessoUsuario.Controls.Add(this.label10);
            this.gbAcessoUsuario.Controls.Add(this.cbEstado);
            this.gbAcessoUsuario.Controls.Add(this.label8);
            this.gbAcessoUsuario.Controls.Add(this.label7);
            this.gbAcessoUsuario.Controls.Add(this.btnBusquedaRapida);
            this.gbAcessoUsuario.Controls.Add(this.txtCedula);
            this.gbAcessoUsuario.Controls.Add(this.txtApellido2);
            this.gbAcessoUsuario.Controls.Add(this.txtApellido1);
            this.gbAcessoUsuario.Controls.Add(this.txtNombre);
            this.gbAcessoUsuario.Controls.Add(this.txtCarnet);
            this.gbAcessoUsuario.Controls.Add(this.cbGenero);
            this.gbAcessoUsuario.Controls.Add(this.label6);
            this.gbAcessoUsuario.Controls.Add(this.label5);
            this.gbAcessoUsuario.Controls.Add(this.label4);
            this.gbAcessoUsuario.Controls.Add(this.label2);
            this.gbAcessoUsuario.Controls.Add(this.label1);
            this.gbAcessoUsuario.Controls.Add(this.label3);
            this.gbAcessoUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAcessoUsuario.ForeColor = System.Drawing.Color.White;
            this.gbAcessoUsuario.Location = new System.Drawing.Point(41, 25);
            this.gbAcessoUsuario.Name = "gbAcessoUsuario";
            this.gbAcessoUsuario.Size = new System.Drawing.Size(369, 526);
            this.gbAcessoUsuario.TabIndex = 27;
            this.gbAcessoUsuario.TabStop = false;
            this.gbAcessoUsuario.Text = "Control de Usuarios";
            // 
            // cbInstitucion
            // 
            this.cbInstitucion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbInstitucion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInstitucion.ForeColor = System.Drawing.Color.Black;
            this.cbInstitucion.FormattingEnabled = true;
            this.cbInstitucion.Location = new System.Drawing.Point(136, 357);
            this.cbInstitucion.Name = "cbInstitucion";
            this.cbInstitucion.Size = new System.Drawing.Size(162, 25);
            this.cbInstitucion.TabIndex = 54;
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.Location = new System.Drawing.Point(110, 281);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Size = new System.Drawing.Size(200, 26);
            this.dtFechaNacimiento.TabIndex = 53;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(251, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 26);
            this.button1.TabIndex = 52;
            this.button1.Text = "~//...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(96, 404);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(46, 392);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 18);
            this.label11.TabIndex = 49;
            this.label11.Text = "Foto:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(46, 360);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 18);
            this.label10.TabIndex = 48;
            this.label10.Text = "Institución:";
            // 
            // cbEstado
            // 
            this.cbEstado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbEstado.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.ForeColor = System.Drawing.Color.Black;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Activo",
            "Egresado"});
            this.cbEstado.Location = new System.Drawing.Point(136, 326);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(161, 25);
            this.cbEstado.TabIndex = 46;
            this.cbEstado.SelectedValueChanged += new System.EventHandler(this.cbEstado_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(46, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 45;
            this.label8.Text = "Estado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(46, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 18);
            this.label7.TabIndex = 41;
            this.label7.Text = "Fecha de Nacimiento:";
            // 
            // btnBusquedaRapida
            // 
            this.btnBusquedaRapida.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBusquedaRapida.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBusquedaRapida.FlatAppearance.BorderSize = 2;
            this.btnBusquedaRapida.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnBusquedaRapida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBusquedaRapida.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusquedaRapida.ForeColor = System.Drawing.Color.Black;
            this.btnBusquedaRapida.Location = new System.Drawing.Point(278, 34);
            this.btnBusquedaRapida.Name = "btnBusquedaRapida";
            this.btnBusquedaRapida.Size = new System.Drawing.Size(32, 32);
            this.btnBusquedaRapida.TabIndex = 35;
            this.btnBusquedaRapida.UseVisualStyleBackColor = false;
            this.btnBusquedaRapida.Click += new System.EventHandler(this.btnBusquedaRapida_Click);
            // 
            // txtCedula
            // 
            this.txtCedula.AcceptsReturn = true;
            this.txtCedula.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCedula.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.ForeColor = System.Drawing.Color.Black;
            this.txtCedula.Location = new System.Drawing.Point(148, 186);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(162, 26);
            this.txtCedula.TabIndex = 34;
            // 
            // txtApellido2
            // 
            this.txtApellido2.AcceptsReturn = true;
            this.txtApellido2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtApellido2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido2.ForeColor = System.Drawing.Color.Black;
            this.txtApellido2.Location = new System.Drawing.Point(148, 151);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(162, 26);
            this.txtApellido2.TabIndex = 33;
            // 
            // txtApellido1
            // 
            this.txtApellido1.AcceptsReturn = true;
            this.txtApellido1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtApellido1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido1.ForeColor = System.Drawing.Color.Black;
            this.txtApellido1.Location = new System.Drawing.Point(148, 114);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(162, 26);
            this.txtApellido1.TabIndex = 32;
            // 
            // txtNombre
            // 
            this.txtNombre.AcceptsReturn = true;
            this.txtNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(148, 76);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(162, 26);
            this.txtNombre.TabIndex = 31;
            // 
            // txtCarnet
            // 
            this.txtCarnet.AcceptsReturn = true;
            this.txtCarnet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCarnet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarnet.ForeColor = System.Drawing.Color.Black;
            this.txtCarnet.Location = new System.Drawing.Point(148, 38);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(124, 26);
            this.txtCarnet.TabIndex = 30;
            this.txtCarnet.TextChanged += new System.EventHandler(this.txtCarnet_TextChanged);
            // 
            // cbGenero
            // 
            this.cbGenero.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbGenero.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenero.ForeColor = System.Drawing.Color.Black;
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbGenero.Location = new System.Drawing.Point(148, 223);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(162, 25);
            this.cbGenero.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(46, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 18);
            this.label6.TabIndex = 24;
            this.label6.Text = "Género:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(46, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Cedula:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(46, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "2° Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "1° Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Carnet:";
            // 
            // gbBotones
            // 
            this.gbBotones.BackColor = System.Drawing.Color.Transparent;
            this.gbBotones.Controls.Add(this.btnLimpiar);
            this.gbBotones.Controls.Add(this.btnSalir);
            this.gbBotones.Controls.Add(this.btnEliminar);
            this.gbBotones.Controls.Add(this.btnModificar);
            this.gbBotones.Controls.Add(this.btnConsultar);
            this.gbBotones.Controls.Add(this.btnIngresar);
            this.gbBotones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBotones.ForeColor = System.Drawing.Color.White;
            this.gbBotones.Location = new System.Drawing.Point(114, 557);
            this.gbBotones.Name = "gbBotones";
            this.gbBotones.Size = new System.Drawing.Size(578, 87);
            this.gbBotones.TabIndex = 28;
            this.gbBotones.TabStop = false;
            this.gbBotones.Text = "Controles";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiar.FlatAppearance.BorderSize = 2;
            this.btnLimpiar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(382, 35);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(83, 37);
            this.btnLimpiar.TabIndex = 29;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(471, 35);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(83, 37);
            this.btnSalir.TabIndex = 28;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatAppearance.BorderSize = 2;
            this.btnEliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(293, 35);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(83, 37);
            this.btnEliminar.TabIndex = 27;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnModificar.Enabled = false;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnModificar.FlatAppearance.BorderSize = 2;
            this.btnModificar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnModificar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.Location = new System.Drawing.Point(204, 35);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(83, 37);
            this.btnModificar.TabIndex = 26;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConsultar.FlatAppearance.BorderSize = 2;
            this.btnConsultar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConsultar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.Black;
            this.btnConsultar.Location = new System.Drawing.Point(115, 35);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(83, 37);
            this.btnConsultar.TabIndex = 25;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnIngresar.Enabled = false;
            this.btnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIngresar.FlatAppearance.BorderSize = 2;
            this.btnIngresar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnIngresar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.Black;
            this.btnIngresar.Location = new System.Drawing.Point(26, 35);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(83, 37);
            this.btnIngresar.TabIndex = 24;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.btnEliminarTelefono);
            this.groupBox1.Controls.Add(this.btnAgregarTelefono);
            this.groupBox1.Controls.Add(this.btnBuscarTelefono);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(436, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 172);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control de telefonos";
            // 
            // txtTelefono
            // 
            this.txtTelefono.AcceptsReturn = true;
            this.txtTelefono.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTelefono.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.Black;
            this.txtTelefono.Location = new System.Drawing.Point(26, 79);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(244, 26);
            this.txtTelefono.TabIndex = 39;
            // 
            // btnEliminarTelefono
            // 
            this.btnEliminarTelefono.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminarTelefono.Enabled = false;
            this.btnEliminarTelefono.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarTelefono.FlatAppearance.BorderSize = 2;
            this.btnEliminarTelefono.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnEliminarTelefono.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEliminarTelefono.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTelefono.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarTelefono.Location = new System.Drawing.Point(141, 117);
            this.btnEliminarTelefono.Name = "btnEliminarTelefono";
            this.btnEliminarTelefono.Size = new System.Drawing.Size(83, 37);
            this.btnEliminarTelefono.TabIndex = 38;
            this.btnEliminarTelefono.Text = "Eliminar";
            this.btnEliminarTelefono.UseVisualStyleBackColor = false;
            // 
            // btnAgregarTelefono
            // 
            this.btnAgregarTelefono.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarTelefono.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarTelefono.FlatAppearance.BorderSize = 2;
            this.btnAgregarTelefono.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnAgregarTelefono.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAgregarTelefono.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTelefono.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarTelefono.Location = new System.Drawing.Point(26, 117);
            this.btnAgregarTelefono.Name = "btnAgregarTelefono";
            this.btnAgregarTelefono.Size = new System.Drawing.Size(83, 37);
            this.btnAgregarTelefono.TabIndex = 37;
            this.btnAgregarTelefono.Text = "Agregar";
            this.btnAgregarTelefono.UseVisualStyleBackColor = false;
            this.btnAgregarTelefono.Click += new System.EventHandler(this.btnAgregarTelefono_Click);
            // 
            // btnBuscarTelefono
            // 
            this.btnBuscarTelefono.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarTelefono.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscarTelefono.FlatAppearance.BorderSize = 2;
            this.btnBuscarTelefono.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnBuscarTelefono.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBuscarTelefono.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarTelefono.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarTelefono.Location = new System.Drawing.Point(270, 20);
            this.btnBuscarTelefono.Name = "btnBuscarTelefono";
            this.btnBuscarTelefono.Size = new System.Drawing.Size(32, 32);
            this.btnBuscarTelefono.TabIndex = 36;
            this.btnBuscarTelefono.UseVisualStyleBackColor = false;
            this.btnBuscarTelefono.Click += new System.EventHandler(this.btnBuscarTelefono_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(23, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Telefono:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtCorreo);
            this.groupBox2.Controls.Add(this.btnEliminarCorreo);
            this.groupBox2.Controls.Add(this.btnAgregarCorreo);
            this.groupBox2.Controls.Add(this.btnBuscarCorreo);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(436, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 177);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control de Correos";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtCorreo
            // 
            this.txtCorreo.AcceptsReturn = true;
            this.txtCorreo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCorreo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.Black;
            this.txtCorreo.Location = new System.Drawing.Point(26, 80);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(244, 26);
            this.txtCorreo.TabIndex = 40;
            // 
            // btnEliminarCorreo
            // 
            this.btnEliminarCorreo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminarCorreo.Enabled = false;
            this.btnEliminarCorreo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarCorreo.FlatAppearance.BorderSize = 2;
            this.btnEliminarCorreo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnEliminarCorreo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEliminarCorreo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCorreo.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarCorreo.Location = new System.Drawing.Point(141, 118);
            this.btnEliminarCorreo.Name = "btnEliminarCorreo";
            this.btnEliminarCorreo.Size = new System.Drawing.Size(83, 37);
            this.btnEliminarCorreo.TabIndex = 39;
            this.btnEliminarCorreo.Text = "Eliminar";
            this.btnEliminarCorreo.UseVisualStyleBackColor = false;
            // 
            // btnAgregarCorreo
            // 
            this.btnAgregarCorreo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarCorreo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarCorreo.FlatAppearance.BorderSize = 2;
            this.btnAgregarCorreo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnAgregarCorreo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAgregarCorreo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCorreo.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarCorreo.Location = new System.Drawing.Point(26, 118);
            this.btnAgregarCorreo.Name = "btnAgregarCorreo";
            this.btnAgregarCorreo.Size = new System.Drawing.Size(83, 37);
            this.btnAgregarCorreo.TabIndex = 38;
            this.btnAgregarCorreo.Text = "Agregar";
            this.btnAgregarCorreo.UseVisualStyleBackColor = false;
            this.btnAgregarCorreo.Click += new System.EventHandler(this.btnAgregarCorreo_Click);
            // 
            // btnBuscarCorreo
            // 
            this.btnBuscarCorreo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarCorreo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscarCorreo.FlatAppearance.BorderSize = 2;
            this.btnBuscarCorreo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnBuscarCorreo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBuscarCorreo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCorreo.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarCorreo.Location = new System.Drawing.Point(270, 17);
            this.btnBuscarCorreo.Name = "btnBuscarCorreo";
            this.btnBuscarCorreo.Size = new System.Drawing.Size(32, 32);
            this.btnBuscarCorreo.TabIndex = 36;
            this.btnBuscarCorreo.UseVisualStyleBackColor = false;
            this.btnBuscarCorreo.Click += new System.EventHandler(this.btnBuscarCorreo_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(23, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 18);
            this.label12.TabIndex = 20;
            this.label12.Text = "Correo:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnCancelarPdf);
            this.groupBox3.Controls.Add(this.btnAgregarPdf);
            this.groupBox3.Controls.Add(this.txtUrl);
            this.groupBox3.Controls.Add(this.btnPdf);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(436, 386);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(308, 134);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Control de Curriculum";
            // 
            // btnCancelarPdf
            // 
            this.btnCancelarPdf.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelarPdf.Enabled = false;
            this.btnCancelarPdf.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelarPdf.FlatAppearance.BorderSize = 2;
            this.btnCancelarPdf.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnCancelarPdf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCancelarPdf.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPdf.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarPdf.Location = new System.Drawing.Point(141, 74);
            this.btnCancelarPdf.Name = "btnCancelarPdf";
            this.btnCancelarPdf.Size = new System.Drawing.Size(83, 37);
            this.btnCancelarPdf.TabIndex = 42;
            this.btnCancelarPdf.Text = "Cancelar";
            this.btnCancelarPdf.UseVisualStyleBackColor = false;
            this.btnCancelarPdf.Click += new System.EventHandler(this.btnCancelarPdf_Click);
            // 
            // btnAgregarPdf
            // 
            this.btnAgregarPdf.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarPdf.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarPdf.FlatAppearance.BorderSize = 2;
            this.btnAgregarPdf.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnAgregarPdf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAgregarPdf.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPdf.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarPdf.Location = new System.Drawing.Point(26, 74);
            this.btnAgregarPdf.Name = "btnAgregarPdf";
            this.btnAgregarPdf.Size = new System.Drawing.Size(83, 37);
            this.btnAgregarPdf.TabIndex = 41;
            this.btnAgregarPdf.Text = "Enviar";
            this.btnAgregarPdf.UseVisualStyleBackColor = false;
            this.btnAgregarPdf.Click += new System.EventHandler(this.btnAgregarPdf_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.AcceptsReturn = true;
            this.txtUrl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUrl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.ForeColor = System.Drawing.Color.Black;
            this.txtUrl.Location = new System.Drawing.Point(16, 33);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.ReadOnly = true;
            this.txtUrl.Size = new System.Drawing.Size(184, 26);
            this.txtUrl.TabIndex = 40;
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPdf.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPdf.FlatAppearance.BorderSize = 2;
            this.btnPdf.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnPdf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPdf.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdf.ForeColor = System.Drawing.Color.Black;
            this.btnPdf.Location = new System.Drawing.Point(206, 22);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(96, 37);
            this.btnPdf.TabIndex = 39;
            this.btnPdf.Text = "Examinar";
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // erpControl
            // 
            this.erpControl.ContainerControl = this;
            // 
            // frmGestionEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoCoordinacion.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 656);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbBotones);
            this.Controls.Add(this.gbAcessoUsuario);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGestionEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Estudiantes";
            this.Load += new System.EventHandler(this.frmGestionEstudiante_Load);
            this.gbAcessoUsuario.ResumeLayout(false);
            this.gbAcessoUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbBotones.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAcessoUsuario;
        private System.Windows.Forms.GroupBox gbBotones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Button btnBusquedaRapida;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBuscarTelefono;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarCorreo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnEliminarTelefono;
        private System.Windows.Forms.Button btnAgregarTelefono;
        private System.Windows.Forms.Button btnEliminarCorreo;
        private System.Windows.Forms.Button btnAgregarCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtFechaNacimiento;
        private System.Windows.Forms.ComboBox cbInstitucion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnCancelarPdf;
        private System.Windows.Forms.Button btnAgregarPdf;
        private System.Windows.Forms.ErrorProvider erpControl;
    }
}

