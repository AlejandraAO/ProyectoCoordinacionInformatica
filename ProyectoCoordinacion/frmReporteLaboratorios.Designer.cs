namespace Vista
{
    partial class frmReporteLaboratorios
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
            this.dgvLaboratorio = new System.Windows.Forms.DataGridView();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lunes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Martes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miércoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jueves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Viernes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sábado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbLaboratorio = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblLugar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaboratorio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLaboratorio
            // 
            this.dgvLaboratorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaboratorio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hora,
            this.Lunes,
            this.Martes,
            this.Miércoles,
            this.Jueves,
            this.Viernes,
            this.Sábado});
            this.dgvLaboratorio.Location = new System.Drawing.Point(64, 105);
            this.dgvLaboratorio.Name = "dgvLaboratorio";
            this.dgvLaboratorio.ReadOnly = true;
            this.dgvLaboratorio.Size = new System.Drawing.Size(746, 399);
            this.dgvLaboratorio.TabIndex = 0;

            // 
            // hora
            // 
            this.hora.HeaderText = "Hora";
            this.hora.Name = "hora";
            this.hora.ReadOnly = true;
            // 
            // Lunes
            // 
            this.Lunes.HeaderText = "Lunes";
            this.Lunes.Name = "Lunes";
            this.Lunes.ReadOnly = true;
            // 
            // Martes
            // 
            this.Martes.HeaderText = "Martes";
            this.Martes.Name = "Martes";
            this.Martes.ReadOnly = true;
            // 
            // Miércoles
            // 
            this.Miércoles.HeaderText = "Miércoles";
            this.Miércoles.Name = "Miércoles";
            this.Miércoles.ReadOnly = true;
            // 
            // Jueves
            // 
            this.Jueves.HeaderText = "Jueves";
            this.Jueves.Name = "Jueves";
            this.Jueves.ReadOnly = true;
            // 
            // Viernes
            // 
            this.Viernes.HeaderText = "Viernes";
            this.Viernes.Name = "Viernes";
            this.Viernes.ReadOnly = true;
            // 
            // Sábado
            // 
            this.Sábado.HeaderText = "Sábado";
            this.Sábado.Name = "Sábado";
            this.Sábado.ReadOnly = true;
            // 
            // cbLaboratorio
            // 
            this.cbLaboratorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLaboratorio.FormattingEnabled = true;
            this.cbLaboratorio.Items.AddRange(new object[] {
            "Laboratorio1",
            "Laboratorio2"});
            this.cbLaboratorio.Location = new System.Drawing.Point(131, 33);
            this.cbLaboratorio.Name = "cbLaboratorio";
            this.cbLaboratorio.Size = new System.Drawing.Size(121, 21);
            this.cbLaboratorio.TabIndex = 1;
            this.cbLaboratorio.SelectedIndexChanged += new System.EventHandler(this.cbLaboratorio_SelectedIndexChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(766, 540);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 41);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.BackColor = System.Drawing.Color.Transparent;
            this.lblLugar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugar.ForeColor = System.Drawing.Color.White;
            this.lblLugar.Location = new System.Drawing.Point(61, 32);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(44, 18);
            this.lblLugar.TabIndex = 43;
            this.lblLugar.Text = "Sigla";
            // 
            // frmReporteLaboratorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoCoordinacion.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(868, 593);
            this.ControlBox = false;
            this.Controls.Add(this.lblLugar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cbLaboratorio);
            this.Controls.Add(this.dgvLaboratorio);
            this.DoubleBuffered = true;
            this.Name = "frmReporteLaboratorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReporteLaboratorios";
            this.Load += new System.EventHandler(this.frmReporteLaboratorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaboratorio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLaboratorio;
        private System.Windows.Forms.ComboBox cbLaboratorio;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lunes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Martes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miércoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jueves;
        private System.Windows.Forms.DataGridViewTextBoxColumn Viernes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sábado;
        private System.Windows.Forms.Label lblLugar;
    }
}