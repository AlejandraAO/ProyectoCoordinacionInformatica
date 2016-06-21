namespace Vista
{
    partial class frmCursos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxDatosCurso = new System.Windows.Forms.GroupBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.txtModalidad = new System.Windows.Forms.TextBox();
            this.lbModalidad = new System.Windows.Forms.Label();
            this.txtTotalHoras = new System.Windows.Forms.TextBox();
            this.lbNombrePrograma = new System.Windows.Forms.Label();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.lbTotalHoras = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.lbPrograma = new System.Windows.Forms.Label();
            this.txtCreditos = new System.Windows.Forms.TextBox();
            this.lbCreditos = new System.Windows.Forms.Label();
            this.txtCiclo = new System.Windows.Forms.TextBox();
            this.lbCiclo = new System.Windows.Forms.Label();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.lbLugar = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbSigla = new System.Windows.Forms.Label();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gbxRequisitoCorrequisito = new System.Windows.Forms.GroupBox();
            this.dgvCorrequisitos = new System.Windows.Forms.DataGridView();
            this.dgvRequisitos = new System.Windows.Forms.DataGridView();
            this.btnAgregarCorrequisito = new System.Windows.Forms.Button();
            this.btnAgregarRequisito = new System.Windows.Forms.Button();
            this.lbCorrequisito = new System.Windows.Forms.Label();
            this.lbRequisito = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idCoRequisito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siglaCorrequisito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCorrequisito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRequisito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiglaRequisito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreRequisito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxDatosCurso.SuspendLayout();
            this.gbxRequisitoCorrequisito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorrequisitos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisitos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxDatosCurso
            // 
            this.gbxDatosCurso.BackColor = System.Drawing.Color.Transparent;
            this.gbxDatosCurso.Controls.Add(this.cbEstado);
            this.gbxDatosCurso.Controls.Add(this.txtModalidad);
            this.gbxDatosCurso.Controls.Add(this.lbModalidad);
            this.gbxDatosCurso.Controls.Add(this.txtTotalHoras);
            this.gbxDatosCurso.Controls.Add(this.lbNombrePrograma);
            this.gbxDatosCurso.Controls.Add(this.btnExaminar);
            this.gbxDatosCurso.Controls.Add(this.lbTotalHoras);
            this.gbxDatosCurso.Controls.Add(this.lbEstado);
            this.gbxDatosCurso.Controls.Add(this.lbPrograma);
            this.gbxDatosCurso.Controls.Add(this.txtCreditos);
            this.gbxDatosCurso.Controls.Add(this.lbCreditos);
            this.gbxDatosCurso.Controls.Add(this.txtCiclo);
            this.gbxDatosCurso.Controls.Add(this.lbCiclo);
            this.gbxDatosCurso.Controls.Add(this.txtLugar);
            this.gbxDatosCurso.Controls.Add(this.lbLugar);
            this.gbxDatosCurso.Controls.Add(this.txtNombre);
            this.gbxDatosCurso.Controls.Add(this.lbNombre);
            this.gbxDatosCurso.Controls.Add(this.lbSigla);
            this.gbxDatosCurso.Controls.Add(this.txtSigla);
            this.gbxDatosCurso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatosCurso.ForeColor = System.Drawing.Color.White;
            this.gbxDatosCurso.Location = new System.Drawing.Point(48, 12);
            this.gbxDatosCurso.Name = "gbxDatosCurso";
            this.gbxDatosCurso.Size = new System.Drawing.Size(773, 269);
            this.gbxDatosCurso.TabIndex = 41;
            this.gbxDatosCurso.TabStop = false;
            this.gbxDatosCurso.Text = "Gestión Cursos";
            // 
            // cbEstado
            // 
            this.cbEstado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbEstado.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.ForeColor = System.Drawing.Color.Black;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbEstado.Location = new System.Drawing.Point(479, 37);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 25);
            this.cbEstado.TabIndex = 61;
            // 
            // txtModalidad
            // 
            this.txtModalidad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtModalidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModalidad.ForeColor = System.Drawing.Color.Black;
            this.txtModalidad.Location = new System.Drawing.Point(479, 119);
            this.txtModalidad.Name = "txtModalidad";
            this.txtModalidad.Size = new System.Drawing.Size(128, 26);
            this.txtModalidad.TabIndex = 58;
            // 
            // lbModalidad
            // 
            this.lbModalidad.AutoSize = true;
            this.lbModalidad.BackColor = System.Drawing.Color.Transparent;
            this.lbModalidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModalidad.ForeColor = System.Drawing.Color.White;
            this.lbModalidad.Location = new System.Drawing.Point(348, 122);
            this.lbModalidad.Name = "lbModalidad";
            this.lbModalidad.Size = new System.Drawing.Size(82, 18);
            this.lbModalidad.TabIndex = 57;
            this.lbModalidad.Text = "Modalidad";
            // 
            // txtTotalHoras
            // 
            this.txtTotalHoras.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotalHoras.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalHoras.ForeColor = System.Drawing.Color.Black;
            this.txtTotalHoras.Location = new System.Drawing.Point(479, 79);
            this.txtTotalHoras.Name = "txtTotalHoras";
            this.txtTotalHoras.Size = new System.Drawing.Size(128, 26);
            this.txtTotalHoras.TabIndex = 56;
            // 
            // lbNombrePrograma
            // 
            this.lbNombrePrograma.AutoSize = true;
            this.lbNombrePrograma.BackColor = System.Drawing.Color.Transparent;
            this.lbNombrePrograma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombrePrograma.ForeColor = System.Drawing.Color.White;
            this.lbNombrePrograma.Location = new System.Drawing.Point(476, 178);
            this.lbNombrePrograma.Name = "lbNombrePrograma";
            this.lbNombrePrograma.Size = new System.Drawing.Size(0, 18);
            this.lbNombrePrograma.TabIndex = 51;
            // 
            // btnExaminar
            // 
            this.btnExaminar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExaminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExaminar.FlatAppearance.BorderSize = 2;
            this.btnExaminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnExaminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnExaminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExaminar.ForeColor = System.Drawing.Color.Black;
            this.btnExaminar.Location = new System.Drawing.Point(351, 210);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(88, 35);
            this.btnExaminar.TabIndex = 52;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = false;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // lbTotalHoras
            // 
            this.lbTotalHoras.AutoSize = true;
            this.lbTotalHoras.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalHoras.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalHoras.ForeColor = System.Drawing.Color.White;
            this.lbTotalHoras.Location = new System.Drawing.Point(348, 79);
            this.lbTotalHoras.Name = "lbTotalHoras";
            this.lbTotalHoras.Size = new System.Drawing.Size(108, 18);
            this.lbTotalHoras.TabIndex = 55;
            this.lbTotalHoras.Text = "Total de Horas";
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.BackColor = System.Drawing.Color.Transparent;
            this.lbEstado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstado.ForeColor = System.Drawing.Color.White;
            this.lbEstado.Location = new System.Drawing.Point(352, 44);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(58, 18);
            this.lbEstado.TabIndex = 53;
            this.lbEstado.Text = "Estado";
            // 
            // lbPrograma
            // 
            this.lbPrograma.AutoSize = true;
            this.lbPrograma.BackColor = System.Drawing.Color.Transparent;
            this.lbPrograma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrograma.ForeColor = System.Drawing.Color.White;
            this.lbPrograma.Location = new System.Drawing.Point(352, 178);
            this.lbPrograma.Name = "lbPrograma";
            this.lbPrograma.Size = new System.Drawing.Size(78, 18);
            this.lbPrograma.TabIndex = 51;
            this.lbPrograma.Text = "Programa";
            // 
            // txtCreditos
            // 
            this.txtCreditos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCreditos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditos.ForeColor = System.Drawing.Color.Black;
            this.txtCreditos.Location = new System.Drawing.Point(137, 202);
            this.txtCreditos.Name = "txtCreditos";
            this.txtCreditos.Size = new System.Drawing.Size(128, 26);
            this.txtCreditos.TabIndex = 50;
            // 
            // lbCreditos
            // 
            this.lbCreditos.AutoSize = true;
            this.lbCreditos.BackColor = System.Drawing.Color.Transparent;
            this.lbCreditos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreditos.ForeColor = System.Drawing.Color.White;
            this.lbCreditos.Location = new System.Drawing.Point(6, 210);
            this.lbCreditos.Name = "lbCreditos";
            this.lbCreditos.Size = new System.Drawing.Size(68, 18);
            this.lbCreditos.TabIndex = 49;
            this.lbCreditos.Text = "Créditos";
            // 
            // txtCiclo
            // 
            this.txtCiclo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCiclo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiclo.ForeColor = System.Drawing.Color.Black;
            this.txtCiclo.Location = new System.Drawing.Point(137, 159);
            this.txtCiclo.Name = "txtCiclo";
            this.txtCiclo.Size = new System.Drawing.Size(128, 26);
            this.txtCiclo.TabIndex = 48;
            // 
            // lbCiclo
            // 
            this.lbCiclo.AutoSize = true;
            this.lbCiclo.BackColor = System.Drawing.Color.Transparent;
            this.lbCiclo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCiclo.ForeColor = System.Drawing.Color.White;
            this.lbCiclo.Location = new System.Drawing.Point(6, 167);
            this.lbCiclo.Name = "lbCiclo";
            this.lbCiclo.Size = new System.Drawing.Size(44, 18);
            this.lbCiclo.TabIndex = 47;
            this.lbCiclo.Text = "Ciclo";
            // 
            // txtLugar
            // 
            this.txtLugar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLugar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLugar.ForeColor = System.Drawing.Color.Black;
            this.txtLugar.Location = new System.Drawing.Point(137, 119);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(128, 26);
            this.txtLugar.TabIndex = 46;
            // 
            // lbLugar
            // 
            this.lbLugar.AutoSize = true;
            this.lbLugar.BackColor = System.Drawing.Color.Transparent;
            this.lbLugar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLugar.ForeColor = System.Drawing.Color.White;
            this.lbLugar.Location = new System.Drawing.Point(6, 127);
            this.lbLugar.Name = "lbLugar";
            this.lbLugar.Size = new System.Drawing.Size(48, 18);
            this.lbLugar.TabIndex = 45;
            this.lbLugar.Text = "Lugar";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(137, 76);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(128, 26);
            this.txtNombre.TabIndex = 44;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.BackColor = System.Drawing.Color.Transparent;
            this.lbNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.White;
            this.lbNombre.Location = new System.Drawing.Point(6, 84);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(64, 18);
            this.lbNombre.TabIndex = 43;
            this.lbNombre.Text = "Nombre";
            // 
            // lbSigla
            // 
            this.lbSigla.AutoSize = true;
            this.lbSigla.BackColor = System.Drawing.Color.Transparent;
            this.lbSigla.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSigla.ForeColor = System.Drawing.Color.White;
            this.lbSigla.Location = new System.Drawing.Point(10, 39);
            this.lbSigla.Name = "lbSigla";
            this.lbSigla.Size = new System.Drawing.Size(44, 18);
            this.lbSigla.TabIndex = 42;
            this.lbSigla.Text = "Sigla";
            // 
            // txtSigla
            // 
            this.txtSigla.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSigla.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSigla.ForeColor = System.Drawing.Color.Black;
            this.txtSigla.Location = new System.Drawing.Point(137, 36);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(128, 26);
            this.txtSigla.TabIndex = 41;
            this.txtSigla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSigla_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregar.FlatAppearance.BorderSize = 2;
            this.btnAgregar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(12, 567);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(88, 37);
            this.btnAgregar.TabIndex = 59;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            this.btnModificar.Location = new System.Drawing.Point(115, 567);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(88, 37);
            this.btnModificar.TabIndex = 60;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
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
            this.btnSalir.Location = new System.Drawing.Point(681, 567);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 37);
            this.btnSalir.TabIndex = 61;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.btnLimpiar.Location = new System.Drawing.Point(225, 567);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(88, 37);
            this.btnLimpiar.TabIndex = 60;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // gbxRequisitoCorrequisito
            // 
            this.gbxRequisitoCorrequisito.BackColor = System.Drawing.Color.Transparent;
            this.gbxRequisitoCorrequisito.Controls.Add(this.dgvCorrequisitos);
            this.gbxRequisitoCorrequisito.Controls.Add(this.dgvRequisitos);
            this.gbxRequisitoCorrequisito.Controls.Add(this.btnAgregarCorrequisito);
            this.gbxRequisitoCorrequisito.Controls.Add(this.btnAgregarRequisito);
            this.gbxRequisitoCorrequisito.Controls.Add(this.lbCorrequisito);
            this.gbxRequisitoCorrequisito.Controls.Add(this.lbRequisito);
            this.gbxRequisitoCorrequisito.Controls.Add(this.label2);
            this.gbxRequisitoCorrequisito.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxRequisitoCorrequisito.ForeColor = System.Drawing.Color.White;
            this.gbxRequisitoCorrequisito.Location = new System.Drawing.Point(40, 287);
            this.gbxRequisitoCorrequisito.Name = "gbxRequisitoCorrequisito";
            this.gbxRequisitoCorrequisito.Size = new System.Drawing.Size(787, 257);
            this.gbxRequisitoCorrequisito.TabIndex = 63;
            this.gbxRequisitoCorrequisito.TabStop = false;
            this.gbxRequisitoCorrequisito.Text = "Requisitos y correquisitos del curso";
            // 
            // dgvCorrequisitos
            // 
            this.dgvCorrequisitos.AllowUserToOrderColumns = true;
            this.dgvCorrequisitos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCorrequisitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCorrequisitos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCoRequisito,
            this.siglaCorrequisito,
            this.nombreCorrequisito});
            this.dgvCorrequisitos.Location = new System.Drawing.Point(398, 62);
            this.dgvCorrequisitos.Name = "dgvCorrequisitos";
            this.dgvCorrequisitos.ReadOnly = true;
            this.dgvCorrequisitos.Size = new System.Drawing.Size(316, 171);
            this.dgvCorrequisitos.TabIndex = 55;
            // 
            // dgvRequisitos
            // 
            this.dgvRequisitos.AllowUserToOrderColumns = true;
            this.dgvRequisitos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvRequisitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequisitos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRequisito,
            this.SiglaRequisito,
            this.nombreRequisito});
            this.dgvRequisitos.Location = new System.Drawing.Point(6, 62);
            this.dgvRequisitos.Name = "dgvRequisitos";
            this.dgvRequisitos.ReadOnly = true;
            this.dgvRequisitos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequisitos.Size = new System.Drawing.Size(316, 171);
            this.dgvRequisitos.TabIndex = 55;
            // 
            // btnAgregarCorrequisito
            // 
            this.btnAgregarCorrequisito.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarCorrequisito.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarCorrequisito.FlatAppearance.BorderSize = 2;
            this.btnAgregarCorrequisito.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnAgregarCorrequisito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAgregarCorrequisito.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCorrequisito.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarCorrequisito.Location = new System.Drawing.Point(725, 62);
            this.btnAgregarCorrequisito.Name = "btnAgregarCorrequisito";
            this.btnAgregarCorrequisito.Size = new System.Drawing.Size(56, 31);
            this.btnAgregarCorrequisito.TabIndex = 54;
            this.btnAgregarCorrequisito.Text = "+";
            this.btnAgregarCorrequisito.UseVisualStyleBackColor = false;
            this.btnAgregarCorrequisito.Click += new System.EventHandler(this.btnAgregarCorrequisito_Click);
            // 
            // btnAgregarRequisito
            // 
            this.btnAgregarRequisito.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarRequisito.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarRequisito.FlatAppearance.BorderSize = 2;
            this.btnAgregarRequisito.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnAgregarRequisito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAgregarRequisito.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRequisito.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarRequisito.Location = new System.Drawing.Point(328, 62);
            this.btnAgregarRequisito.Name = "btnAgregarRequisito";
            this.btnAgregarRequisito.Size = new System.Drawing.Size(56, 31);
            this.btnAgregarRequisito.TabIndex = 54;
            this.btnAgregarRequisito.Text = "+";
            this.btnAgregarRequisito.UseVisualStyleBackColor = false;
            this.btnAgregarRequisito.Click += new System.EventHandler(this.btnAgregarRequisito_Click);
            // 
            // lbCorrequisito
            // 
            this.lbCorrequisito.AutoSize = true;
            this.lbCorrequisito.BackColor = System.Drawing.Color.Transparent;
            this.lbCorrequisito.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorrequisito.ForeColor = System.Drawing.Color.White;
            this.lbCorrequisito.Location = new System.Drawing.Point(458, 32);
            this.lbCorrequisito.Name = "lbCorrequisito";
            this.lbCorrequisito.Size = new System.Drawing.Size(102, 18);
            this.lbCorrequisito.TabIndex = 53;
            this.lbCorrequisito.Text = "Correquisitos";
            // 
            // lbRequisito
            // 
            this.lbRequisito.AutoSize = true;
            this.lbRequisito.BackColor = System.Drawing.Color.Transparent;
            this.lbRequisito.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRequisito.ForeColor = System.Drawing.Color.White;
            this.lbRequisito.Location = new System.Drawing.Point(72, 32);
            this.lbRequisito.Name = "lbRequisito";
            this.lbRequisito.Size = new System.Drawing.Size(82, 18);
            this.lbRequisito.TabIndex = 53;
            this.lbRequisito.Text = "Requisitos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(476, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 51;
            // 
            // idCoRequisito
            // 
            this.idCoRequisito.HeaderText = "idCurso";
            this.idCoRequisito.Name = "idCoRequisito";
            this.idCoRequisito.ReadOnly = true;
            this.idCoRequisito.Visible = false;
            // 
            // siglaCorrequisito
            // 
            this.siglaCorrequisito.HeaderText = "Sigla";
            this.siglaCorrequisito.Name = "siglaCorrequisito";
            this.siglaCorrequisito.ReadOnly = true;
            this.siglaCorrequisito.Width = 70;
            // 
            // nombreCorrequisito
            // 
            this.nombreCorrequisito.HeaderText = "Nombre Curso";
            this.nombreCorrequisito.MinimumWidth = 10;
            this.nombreCorrequisito.Name = "nombreCorrequisito";
            this.nombreCorrequisito.ReadOnly = true;
            this.nombreCorrequisito.Width = 200;
            // 
            // idRequisito
            // 
            this.idRequisito.HeaderText = "idRequisito";
            this.idRequisito.Name = "idRequisito";
            this.idRequisito.ReadOnly = true;
            this.idRequisito.Visible = false;
            // 
            // SiglaRequisito
            // 
            this.SiglaRequisito.HeaderText = "Sigla";
            this.SiglaRequisito.Name = "SiglaRequisito";
            this.SiglaRequisito.ReadOnly = true;
            this.SiglaRequisito.Width = 70;
            // 
            // nombreRequisito
            // 
            this.nombreRequisito.HeaderText = "Nombre";
            this.nombreRequisito.MinimumWidth = 10;
            this.nombreRequisito.Name = "nombreRequisito";
            this.nombreRequisito.ReadOnly = true;
            this.nombreRequisito.Width = 200;
            // 
            // frmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoCoordinacion.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 616);
            this.ControlBox = false;
            this.Controls.Add(this.gbxRequisitoCorrequisito);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbxDatosCurso);
            this.DoubleBuffered = true;
            this.Name = "frmCursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCursos";
            this.Load += new System.EventHandler(this.frmCursos_Load);
            this.gbxDatosCurso.ResumeLayout(false);
            this.gbxDatosCurso.PerformLayout();
            this.gbxRequisitoCorrequisito.ResumeLayout(false);
            this.gbxRequisitoCorrequisito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorrequisitos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisitos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxDatosCurso;
        private System.Windows.Forms.TextBox txtModalidad;
        private System.Windows.Forms.Label lbModalidad;
        private System.Windows.Forms.TextBox txtTotalHoras;
        private System.Windows.Forms.Label lbTotalHoras;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Label lbPrograma;
        private System.Windows.Forms.TextBox txtCreditos;
        private System.Windows.Forms.Label lbCreditos;
        private System.Windows.Forms.TextBox txtCiclo;
        private System.Windows.Forms.Label lbCiclo;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Label lbLugar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbSigla;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lbNombrePrograma;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox gbxRequisitoCorrequisito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarCorrequisito;
        private System.Windows.Forms.Button btnAgregarRequisito;
        private System.Windows.Forms.Label lbCorrequisito;
        private System.Windows.Forms.Label lbRequisito;
        private System.Windows.Forms.DataGridView dgvRequisitos;
        private System.Windows.Forms.DataGridView dgvCorrequisitos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCoRequisito;
        private System.Windows.Forms.DataGridViewTextBoxColumn siglaCorrequisito;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCorrequisito;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRequisito;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiglaRequisito;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreRequisito;
    }
}