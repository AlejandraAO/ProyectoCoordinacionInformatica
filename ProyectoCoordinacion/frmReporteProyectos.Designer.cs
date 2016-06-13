namespace Vista
{
    partial class frmReporteProyectos
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvProyecto = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.informacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbConsultarPor = new System.Windows.Forms.ComboBox();
            this.lbConsultarPor = new System.Windows.Forms.Label();
            this.txtDatoConsulta = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyecto)).BeginInit();
            this.SuspendLayout();
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
            this.btnSalir.Location = new System.Drawing.Point(861, 554);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 46);
            this.btnSalir.TabIndex = 37;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvProyecto
            // 
            this.dgvProyecto.AllowUserToOrderColumns = true;
            this.dgvProyecto.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProyecto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.descripcion,
            this.estado,
            this.tipo,
            this.informacion});
            this.dgvProyecto.Location = new System.Drawing.Point(85, 155);
            this.dgvProyecto.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProyecto.Name = "dgvProyecto";
            this.dgvProyecto.Size = new System.Drawing.Size(879, 391);
            this.dgvProyecto.TabIndex = 38;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            // 
            // informacion
            // 
            this.informacion.HeaderText = "Informacion";
            this.informacion.Name = "informacion";
            // 
            // cbConsultarPor
            // 
            this.cbConsultarPor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbConsultarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConsultarPor.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbConsultarPor.ForeColor = System.Drawing.Color.Black;
            this.cbConsultarPor.FormattingEnabled = true;
            this.cbConsultarPor.Items.AddRange(new object[] {
            "Nombre",
            "Coordinador",
            "Colaborador"});
            this.cbConsultarPor.Location = new System.Drawing.Point(85, 79);
            this.cbConsultarPor.Margin = new System.Windows.Forms.Padding(4);
            this.cbConsultarPor.Name = "cbConsultarPor";
            this.cbConsultarPor.Size = new System.Drawing.Size(160, 30);
            this.cbConsultarPor.TabIndex = 40;
            // 
            // lbConsultarPor
            // 
            this.lbConsultarPor.AutoSize = true;
            this.lbConsultarPor.BackColor = System.Drawing.Color.Transparent;
            this.lbConsultarPor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsultarPor.ForeColor = System.Drawing.Color.White;
            this.lbConsultarPor.Location = new System.Drawing.Point(81, 35);
            this.lbConsultarPor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbConsultarPor.Name = "lbConsultarPor";
            this.lbConsultarPor.Size = new System.Drawing.Size(134, 23);
            this.lbConsultarPor.TabIndex = 39;
            this.lbConsultarPor.Text = "Consultar por:";
            // 
            // txtDatoConsulta
            // 
            this.txtDatoConsulta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDatoConsulta.Enabled = false;
            this.txtDatoConsulta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatoConsulta.ForeColor = System.Drawing.Color.Black;
            this.txtDatoConsulta.Location = new System.Drawing.Point(621, 71);
            this.txtDatoConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatoConsulta.Name = "txtDatoConsulta";
            this.txtDatoConsulta.Size = new System.Drawing.Size(169, 30);
            this.txtDatoConsulta.TabIndex = 42;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnConsultar.Enabled = false;
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConsultar.FlatAppearance.BorderSize = 2;
            this.btnConsultar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConsultar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.Black;
            this.btnConsultar.Location = new System.Drawing.Point(849, 63);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(115, 46);
            this.btnConsultar.TabIndex = 41;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            // 
            // frmReporteProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoCoordinacion.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1108, 644);
            this.Controls.Add(this.txtDatoConsulta);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.cbConsultarPor);
            this.Controls.Add(this.lbConsultarPor);
            this.Controls.Add(this.dgvProyecto);
            this.Controls.Add(this.btnSalir);
            this.DoubleBuffered = true;
            this.Name = "frmReporteProyectos";
            this.Text = "frmReporteProyectos";
            this.Load += new System.EventHandler(this.frmReporteProyectos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyecto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvProyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn informacion;
        private System.Windows.Forms.ComboBox cbConsultarPor;
        private System.Windows.Forms.Label lbConsultarPor;
        private System.Windows.Forms.TextBox txtDatoConsulta;
        private System.Windows.Forms.Button btnConsultar;
    }
}