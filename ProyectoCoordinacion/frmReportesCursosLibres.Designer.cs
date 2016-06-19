namespace Vista
{
    partial class frmReportesCursosLibres
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
            this.dgvCursosLibres = new System.Windows.Forms.DataGridView();
            this.txtDatoConsulta = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cbConsultarPor = new System.Windows.Forms.ComboBox();
            this.lbConsultarPor = new System.Windows.Forms.Label();
            this.IdCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosLibres)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCursosLibres
            // 
            this.dgvCursosLibres.AllowUserToOrderColumns = true;
            this.dgvCursosLibres.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCursosLibres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursosLibres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCurso,
            this.Profesor,
            this.Nombre,
            this.descripcion,
            this.estado,
            this.lugar,
            this.cupo,
            this.programa});
            this.dgvCursosLibres.Location = new System.Drawing.Point(35, 93);
            this.dgvCursosLibres.Name = "dgvCursosLibres";
            this.dgvCursosLibres.Size = new System.Drawing.Size(767, 295);
            this.dgvCursosLibres.TabIndex = 39;
            this.dgvCursosLibres.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCursosLibres_CellContentClick);
            // 
            // txtDatoConsulta
            // 
            this.txtDatoConsulta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDatoConsulta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatoConsulta.ForeColor = System.Drawing.Color.Black;
            this.txtDatoConsulta.Location = new System.Drawing.Point(502, 48);
            this.txtDatoConsulta.Name = "txtDatoConsulta";
            this.txtDatoConsulta.Size = new System.Drawing.Size(128, 26);
            this.txtDatoConsulta.TabIndex = 46;
            this.txtDatoConsulta.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDatoConsulta_KeyUp);
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
            this.btnConsultar.Location = new System.Drawing.Point(679, 42);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(86, 37);
            this.btnConsultar.TabIndex = 45;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
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
            "Profesor",
            "Lugar"});
            this.cbConsultarPor.Location = new System.Drawing.Point(41, 49);
            this.cbConsultarPor.Name = "cbConsultarPor";
            this.cbConsultarPor.Size = new System.Drawing.Size(121, 25);
            this.cbConsultarPor.TabIndex = 44;
            // 
            // lbConsultarPor
            // 
            this.lbConsultarPor.AutoSize = true;
            this.lbConsultarPor.BackColor = System.Drawing.Color.Transparent;
            this.lbConsultarPor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsultarPor.ForeColor = System.Drawing.Color.White;
            this.lbConsultarPor.Location = new System.Drawing.Point(38, 20);
            this.lbConsultarPor.Name = "lbConsultarPor";
            this.lbConsultarPor.Size = new System.Drawing.Size(105, 18);
            this.lbConsultarPor.TabIndex = 43;
            this.lbConsultarPor.Text = "Consultar por:";
            // 
            // IdCurso
            // 
            this.IdCurso.HeaderText = "idCurso";
            this.IdCurso.Name = "IdCurso";
            this.IdCurso.Visible = false;
            // 
            // Profesor
            // 
            this.Profesor.HeaderText = "Profesor";
            this.Profesor.Name = "Profesor";
            this.Profesor.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // lugar
            // 
            this.lugar.HeaderText = "Lugar";
            this.lugar.Name = "lugar";
            this.lugar.ReadOnly = true;
            // 
            // cupo
            // 
            this.cupo.HeaderText = "Cupo";
            this.cupo.Name = "cupo";
            this.cupo.ReadOnly = true;
            // 
            // programa
            // 
            this.programa.HeaderText = "Programa";
            this.programa.Name = "programa";
            this.programa.ReadOnly = true;
            // 
            // frmReportesCursosLibres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoCoordinacion.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(835, 445);
            this.Controls.Add(this.txtDatoConsulta);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.cbConsultarPor);
            this.Controls.Add(this.lbConsultarPor);
            this.Controls.Add(this.dgvCursosLibres);
            this.DoubleBuffered = true;
            this.Name = "frmReportesCursosLibres";
            this.Text = "frmReportesCursosLibres";
            this.Load += new System.EventHandler(this.frmReportesCursosLibres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosLibres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCursosLibres;
        private System.Windows.Forms.TextBox txtDatoConsulta;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cbConsultarPor;
        private System.Windows.Forms.Label lbConsultarPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn lugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn programa;
    }
}