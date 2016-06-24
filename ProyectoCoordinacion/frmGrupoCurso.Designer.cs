namespace Vista
{
    partial class frmGrupoCurso
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.lbIdGrupo = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.numCupoActual = new System.Windows.Forms.NumericUpDown();
            this.numCupoMinimo = new System.Windows.Forms.NumericUpDown();
            this.numCupoMaximo = new System.Windows.Forms.NumericUpDown();
            this.lbCupoMaximo = new System.Windows.Forms.Label();
            this.lbNumeroGrupo = new System.Windows.Forms.Label();
            this.lbIdCurso = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lbCupoActual = new System.Windows.Forms.Label();
            this.txtNumeroGrupo = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtIdGrupo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lbCupoMinimo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregarTabla = new System.Windows.Forms.Button();
            this.btnModifcarHorario = new System.Windows.Forms.Button();
            this.lvHorarios = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtHoraFinal = new System.Windows.Forms.TextBox();
            this.lbDia = new System.Windows.Forms.Label();
            this.txtHoraInicio = new System.Windows.Forms.TextBox();
            this.lbIdHorario = new System.Windows.Forms.Label();
            this.lbHoraFinal = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtIdHorario = new System.Windows.Forms.TextBox();
            this.lbHoraInicio = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCupoActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCupoMinimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCupoMaximo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbIdGrupo
            // 
            this.lbIdGrupo.AutoSize = true;
            this.lbIdGrupo.Location = new System.Drawing.Point(10, 34);
            this.lbIdGrupo.Name = "lbIdGrupo";
            this.lbIdGrupo.Size = new System.Drawing.Size(0, 13);
            this.lbIdGrupo.TabIndex = 13;
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
            this.btnSalir.Location = new System.Drawing.Point(1033, 509);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(82, 37);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.numCupoActual);
            this.groupBox.Controls.Add(this.numCupoMinimo);
            this.groupBox.Controls.Add(this.numCupoMaximo);
            this.groupBox.Controls.Add(this.lbCupoMaximo);
            this.groupBox.Controls.Add(this.lbNumeroGrupo);
            this.groupBox.Controls.Add(this.lbIdCurso);
            this.groupBox.Controls.Add(this.btnConsultar);
            this.groupBox.Controls.Add(this.lbCupoActual);
            this.groupBox.Controls.Add(this.txtNumeroGrupo);
            this.groupBox.Controls.Add(this.btnModificar);
            this.groupBox.Controls.Add(this.txtIdGrupo);
            this.groupBox.Controls.Add(this.btnAgregar);
            this.groupBox.Controls.Add(this.lbCupoMinimo);
            this.groupBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.ForeColor = System.Drawing.Color.White;
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(489, 446);
            this.groupBox.TabIndex = 42;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Información de Grupo";
            this.groupBox.Enter += new System.EventHandler(this.groupBox_Enter);
            // 
            // numCupoActual
            // 
            this.numCupoActual.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numCupoActual.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCupoActual.ForeColor = System.Drawing.Color.Black;
            this.numCupoActual.Location = new System.Drawing.Point(140, 262);
            this.numCupoActual.Name = "numCupoActual";
            this.numCupoActual.Size = new System.Drawing.Size(120, 26);
            this.numCupoActual.TabIndex = 51;
            // 
            // numCupoMinimo
            // 
            this.numCupoMinimo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numCupoMinimo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCupoMinimo.ForeColor = System.Drawing.Color.Black;
            this.numCupoMinimo.Location = new System.Drawing.Point(140, 212);
            this.numCupoMinimo.Name = "numCupoMinimo";
            this.numCupoMinimo.Size = new System.Drawing.Size(120, 26);
            this.numCupoMinimo.TabIndex = 50;
            // 
            // numCupoMaximo
            // 
            this.numCupoMaximo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numCupoMaximo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCupoMaximo.ForeColor = System.Drawing.Color.Black;
            this.numCupoMaximo.Location = new System.Drawing.Point(140, 159);
            this.numCupoMaximo.Name = "numCupoMaximo";
            this.numCupoMaximo.Size = new System.Drawing.Size(120, 26);
            this.numCupoMaximo.TabIndex = 49;
            // 
            // lbCupoMaximo
            // 
            this.lbCupoMaximo.AutoSize = true;
            this.lbCupoMaximo.BackColor = System.Drawing.Color.Transparent;
            this.lbCupoMaximo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCupoMaximo.ForeColor = System.Drawing.Color.White;
            this.lbCupoMaximo.Location = new System.Drawing.Point(17, 159);
            this.lbCupoMaximo.Name = "lbCupoMaximo";
            this.lbCupoMaximo.Size = new System.Drawing.Size(105, 18);
            this.lbCupoMaximo.TabIndex = 46;
            this.lbCupoMaximo.Text = "Cupo Máximo";
            // 
            // lbNumeroGrupo
            // 
            this.lbNumeroGrupo.AutoSize = true;
            this.lbNumeroGrupo.BackColor = System.Drawing.Color.Transparent;
            this.lbNumeroGrupo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumeroGrupo.ForeColor = System.Drawing.Color.White;
            this.lbNumeroGrupo.Location = new System.Drawing.Point(11, 104);
            this.lbNumeroGrupo.Name = "lbNumeroGrupo";
            this.lbNumeroGrupo.Size = new System.Drawing.Size(110, 18);
            this.lbNumeroGrupo.TabIndex = 45;
            this.lbNumeroGrupo.Text = "Numero Grupo";
            // 
            // lbIdCurso
            // 
            this.lbIdCurso.AutoSize = true;
            this.lbIdCurso.BackColor = System.Drawing.Color.Transparent;
            this.lbIdCurso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdCurso.ForeColor = System.Drawing.Color.White;
            this.lbIdCurso.Location = new System.Drawing.Point(17, 43);
            this.lbIdCurso.Name = "lbIdCurso";
            this.lbIdCurso.Size = new System.Drawing.Size(63, 18);
            this.lbIdCurso.TabIndex = 44;
            this.lbIdCurso.Text = "idCurso";
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
            this.btnConsultar.Location = new System.Drawing.Point(303, 40);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(82, 37);
            this.btnConsultar.TabIndex = 43;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click_2);
            // 
            // lbCupoActual
            // 
            this.lbCupoActual.AutoSize = true;
            this.lbCupoActual.BackColor = System.Drawing.Color.Transparent;
            this.lbCupoActual.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCupoActual.ForeColor = System.Drawing.Color.White;
            this.lbCupoActual.Location = new System.Drawing.Point(33, 262);
            this.lbCupoActual.Name = "lbCupoActual";
            this.lbCupoActual.Size = new System.Drawing.Size(92, 18);
            this.lbCupoActual.TabIndex = 48;
            this.lbCupoActual.Text = "Cupo Actual";
            // 
            // txtNumeroGrupo
            // 
            this.txtNumeroGrupo.Location = new System.Drawing.Point(140, 102);
            this.txtNumeroGrupo.Name = "txtNumeroGrupo";
            this.txtNumeroGrupo.Size = new System.Drawing.Size(146, 26);
            this.txtNumeroGrupo.TabIndex = 40;
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
            this.btnModificar.Location = new System.Drawing.Point(113, 372);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(82, 37);
            this.btnModificar.TabIndex = 42;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtIdGrupo
            // 
            this.txtIdGrupo.Location = new System.Drawing.Point(140, 43);
            this.txtIdGrupo.Name = "txtIdGrupo";
            this.txtIdGrupo.Size = new System.Drawing.Size(146, 26);
            this.txtIdGrupo.TabIndex = 39;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregar.FlatAppearance.BorderSize = 2;
            this.btnAgregar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(18, 372);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(77, 37);
            this.btnAgregar.TabIndex = 41;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_2);
            // 
            // lbCupoMinimo
            // 
            this.lbCupoMinimo.AutoSize = true;
            this.lbCupoMinimo.BackColor = System.Drawing.Color.Transparent;
            this.lbCupoMinimo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCupoMinimo.ForeColor = System.Drawing.Color.White;
            this.lbCupoMinimo.Location = new System.Drawing.Point(32, 212);
            this.lbCupoMinimo.Name = "lbCupoMinimo";
            this.lbCupoMinimo.Size = new System.Drawing.Size(101, 18);
            this.lbCupoMinimo.TabIndex = 47;
            this.lbCupoMinimo.Text = "Cupo Minimo";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnAgregarTabla);
            this.groupBox1.Controls.Add(this.btnModifcarHorario);
            this.groupBox1.Controls.Add(this.lvHorarios);
            this.groupBox1.Controls.Add(this.txtHoraFinal);
            this.groupBox1.Controls.Add(this.lbDia);
            this.groupBox1.Controls.Add(this.txtHoraInicio);
            this.groupBox1.Controls.Add(this.lbIdHorario);
            this.groupBox1.Controls.Add(this.lbHoraFinal);
            this.groupBox1.Controls.Add(this.txtDia);
            this.groupBox1.Controls.Add(this.txtIdHorario);
            this.groupBox1.Controls.Add(this.lbHoraInicio);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(558, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 446);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de Horarios";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAgregarTabla
            // 
            this.btnAgregarTabla.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarTabla.Enabled = false;
            this.btnAgregarTabla.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarTabla.FlatAppearance.BorderSize = 2;
            this.btnAgregarTabla.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnAgregarTabla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAgregarTabla.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTabla.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarTabla.Location = new System.Drawing.Point(144, 140);
            this.btnAgregarTabla.Name = "btnAgregarTabla";
            this.btnAgregarTabla.Size = new System.Drawing.Size(82, 54);
            this.btnAgregarTabla.TabIndex = 55;
            this.btnAgregarTabla.Text = "Agregar a tabla";
            this.btnAgregarTabla.UseVisualStyleBackColor = false;
            this.btnAgregarTabla.Click += new System.EventHandler(this.btnAgregarTabla_Click);
            // 
            // btnModifcarHorario
            // 
            this.btnModifcarHorario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnModifcarHorario.Enabled = false;
            this.btnModifcarHorario.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnModifcarHorario.FlatAppearance.BorderSize = 2;
            this.btnModifcarHorario.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnModifcarHorario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnModifcarHorario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifcarHorario.ForeColor = System.Drawing.Color.Black;
            this.btnModifcarHorario.Location = new System.Drawing.Point(13, 140);
            this.btnModifcarHorario.Name = "btnModifcarHorario";
            this.btnModifcarHorario.Size = new System.Drawing.Size(82, 54);
            this.btnModifcarHorario.TabIndex = 42;
            this.btnModifcarHorario.Text = "Modificar Horario";
            this.btnModifcarHorario.UseVisualStyleBackColor = false;
            this.btnModifcarHorario.Click += new System.EventHandler(this.btnModifcarHorario_Click);
            // 
            // lvHorarios
            // 
            this.lvHorarios.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvHorarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvHorarios.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvHorarios.ForeColor = System.Drawing.Color.Black;
            this.lvHorarios.GridLines = true;
            listViewItem2.Tag = "asdasdasd";
            this.lvHorarios.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lvHorarios.Location = new System.Drawing.Point(22, 209);
            this.lvHorarios.Name = "lvHorarios";
            this.lvHorarios.Size = new System.Drawing.Size(502, 200);
            this.lvHorarios.TabIndex = 54;
            this.lvHorarios.UseCompatibleStateImageBehavior = false;
            this.lvHorarios.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "idHorario";
            this.columnHeader1.Width = 98;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Día";
            this.columnHeader2.Width = 58;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hora de Inicio";
            this.columnHeader3.Width = 103;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Hora Final";
            this.columnHeader4.Width = 93;
            // 
            // txtHoraFinal
            // 
            this.txtHoraFinal.Location = new System.Drawing.Point(357, 40);
            this.txtHoraFinal.Name = "txtHoraFinal";
            this.txtHoraFinal.Size = new System.Drawing.Size(146, 26);
            this.txtHoraFinal.TabIndex = 53;
            // 
            // lbDia
            // 
            this.lbDia.AutoSize = true;
            this.lbDia.BackColor = System.Drawing.Color.Transparent;
            this.lbDia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDia.ForeColor = System.Drawing.Color.White;
            this.lbDia.Location = new System.Drawing.Point(4, 85);
            this.lbDia.Name = "lbDia";
            this.lbDia.Size = new System.Drawing.Size(32, 18);
            this.lbDia.TabIndex = 45;
            this.lbDia.Text = "Día";
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.Location = new System.Drawing.Point(357, 85);
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.Size = new System.Drawing.Size(146, 26);
            this.txtHoraInicio.TabIndex = 52;
            // 
            // lbIdHorario
            // 
            this.lbIdHorario.AutoSize = true;
            this.lbIdHorario.BackColor = System.Drawing.Color.Transparent;
            this.lbIdHorario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdHorario.ForeColor = System.Drawing.Color.White;
            this.lbIdHorario.Location = new System.Drawing.Point(10, 45);
            this.lbIdHorario.Name = "lbIdHorario";
            this.lbIdHorario.Size = new System.Drawing.Size(73, 18);
            this.lbIdHorario.TabIndex = 44;
            this.lbIdHorario.Text = "idHorario";
            this.lbIdHorario.Visible = false;
            // 
            // lbHoraFinal
            // 
            this.lbHoraFinal.AutoSize = true;
            this.lbHoraFinal.BackColor = System.Drawing.Color.Transparent;
            this.lbHoraFinal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoraFinal.ForeColor = System.Drawing.Color.White;
            this.lbHoraFinal.Location = new System.Drawing.Point(271, 48);
            this.lbHoraFinal.Name = "lbHoraFinal";
            this.lbHoraFinal.Size = new System.Drawing.Size(80, 18);
            this.lbHoraFinal.TabIndex = 47;
            this.lbHoraFinal.Text = "Hora Final";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(91, 83);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(146, 26);
            this.txtDia.TabIndex = 40;
            // 
            // txtIdHorario
            // 
            this.txtIdHorario.Enabled = false;
            this.txtIdHorario.Location = new System.Drawing.Point(91, 45);
            this.txtIdHorario.Name = "txtIdHorario";
            this.txtIdHorario.Size = new System.Drawing.Size(146, 26);
            this.txtIdHorario.TabIndex = 39;
            this.txtIdHorario.Visible = false;
            // 
            // lbHoraInicio
            // 
            this.lbHoraInicio.AutoSize = true;
            this.lbHoraInicio.BackColor = System.Drawing.Color.Transparent;
            this.lbHoraInicio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoraInicio.ForeColor = System.Drawing.Color.White;
            this.lbHoraInicio.Location = new System.Drawing.Point(269, 88);
            this.lbHoraInicio.Name = "lbHoraInicio";
            this.lbHoraInicio.Size = new System.Drawing.Size(82, 18);
            this.lbHoraInicio.TabIndex = 46;
            this.lbHoraInicio.Text = "Hora Inicio";
            // 
            // frmGrupoCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoCoordinacion.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 558);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lbIdGrupo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGrupoCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGrupoCurso";
            this.Load += new System.EventHandler(this.frmGrupoCurso_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCupoActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCupoMinimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCupoMaximo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbIdGrupo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.NumericUpDown numCupoActual;
        private System.Windows.Forms.NumericUpDown numCupoMinimo;
        private System.Windows.Forms.NumericUpDown numCupoMaximo;
        private System.Windows.Forms.Label lbCupoActual;
        private System.Windows.Forms.Label lbCupoMinimo;
        private System.Windows.Forms.Label lbCupoMaximo;
        private System.Windows.Forms.Label lbNumeroGrupo;
        private System.Windows.Forms.Label lbIdCurso;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNumeroGrupo;
        private System.Windows.Forms.TextBox txtIdGrupo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbHoraFinal;
        private System.Windows.Forms.Label lbHoraInicio;
        private System.Windows.Forms.Label lbDia;
        private System.Windows.Forms.Label lbIdHorario;
        private System.Windows.Forms.Button btnModifcarHorario;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtIdHorario;
        private System.Windows.Forms.TextBox txtHoraFinal;
        private System.Windows.Forms.TextBox txtHoraInicio;
        private System.Windows.Forms.ListView lvHorarios;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnAgregarTabla;
    }
}