namespace Vista
{
    partial class frmReporteMiembros
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
            this.dgvMiembros = new System.Windows.Forms.DataGridView();
            this.Carnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoUno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lbConsultarPor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvProyecto = new System.Windows.Forms.ListView();
            this.codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiembros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMiembros
            // 
            this.dgvMiembros.AllowUserToOrderColumns = true;
            this.dgvMiembros.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMiembros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMiembros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Carnet,
            this.Nombre,
            this.apellidoUno,
            this.apellidoDos,
            this.carrera,
            this.tipo});
            this.dgvMiembros.Location = new System.Drawing.Point(502, 112);
            this.dgvMiembros.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMiembros.Name = "dgvMiembros";
            this.dgvMiembros.Size = new System.Drawing.Size(879, 391);
            this.dgvMiembros.TabIndex = 35;
            // 
            // Carnet
            // 
            this.Carnet.HeaderText = "Carnet";
            this.Carnet.Name = "Carnet";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // apellidoUno
            // 
            this.apellidoUno.HeaderText = "1mer Apellido";
            this.apellidoUno.Name = "apellidoUno";
            // 
            // apellidoDos
            // 
            this.apellidoDos.HeaderText = "2do Apellido";
            this.apellidoDos.Name = "apellidoDos";
            // 
            // carrera
            // 
            this.carrera.HeaderText = "Carrera";
            this.carrera.Name = "carrera";
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
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
            this.btnSalir.Location = new System.Drawing.Point(1278, 562);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 46);
            this.btnSalir.TabIndex = 36;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lbConsultarPor
            // 
            this.lbConsultarPor.AutoSize = true;
            this.lbConsultarPor.BackColor = System.Drawing.Color.Transparent;
            this.lbConsultarPor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsultarPor.ForeColor = System.Drawing.Color.White;
            this.lbConsultarPor.Location = new System.Drawing.Point(26, 46);
            this.lbConsultarPor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbConsultarPor.Name = "lbConsultarPor";
            this.lbConsultarPor.Size = new System.Drawing.Size(213, 23);
            this.lbConsultarPor.TabIndex = 37;
            this.lbConsultarPor.Text = "Consultar por Proyecto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(498, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 41;
            this.label1.Text = "Miembros";
            // 
            // lvProyecto
            // 
            this.lvProyecto.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvProyecto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codigo,
            this.columnHeader1});
            this.lvProyecto.FullRowSelect = true;
            this.lvProyecto.GridLines = true;
            this.lvProyecto.Location = new System.Drawing.Point(30, 112);
            this.lvProyecto.Name = "lvProyecto";
            this.lvProyecto.Size = new System.Drawing.Size(359, 391);
            this.lvProyecto.TabIndex = 42;
            this.lvProyecto.UseCompatibleStateImageBehavior = false;
            this.lvProyecto.View = System.Windows.Forms.View.Details;
            this.lvProyecto.SelectedIndexChanged += new System.EventHandler(this.lvProyecto_SelectedIndexChanged);
            // 
            // codigo
            // 
            this.codigo.Text = "Codigo";
            this.codigo.Width = 110;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre Proyecto";
            this.columnHeader1.Width = 234;
            // 
            // frmReporteMiembros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoCoordinacion.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1477, 635);
            this.Controls.Add(this.lvProyecto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbConsultarPor);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvMiembros);
            this.DoubleBuffered = true;
            this.Name = "frmReporteMiembros";
            this.Text = "frmReporteMiembros";
            this.Load += new System.EventHandler(this.frmReporteMiembros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiembros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMiembros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carnet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoUno;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDos;
        private System.Windows.Forms.DataGridViewTextBoxColumn carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lbConsultarPor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvProyecto;
        private System.Windows.Forms.ColumnHeader codigo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}