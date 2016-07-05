namespace Vista
{
    partial class frmReporteProfesores
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
            this.dgvReporteProfesor = new System.Windows.Forms.DataGridView();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lunes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.martes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miercoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jueves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viernes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sabado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbNombreProfesor = new System.Windows.Forms.Label();
            this.cbProfesor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteProfesor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReporteProfesor
            // 
            this.dgvReporteProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteProfesor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hora,
            this.lunes,
            this.martes,
            this.miercoles,
            this.jueves,
            this.viernes,
            this.sabado});
            this.dgvReporteProfesor.Location = new System.Drawing.Point(35, 66);
            this.dgvReporteProfesor.Name = "dgvReporteProfesor";
            this.dgvReporteProfesor.ReadOnly = true;
            this.dgvReporteProfesor.Size = new System.Drawing.Size(743, 301);
            this.dgvReporteProfesor.TabIndex = 0;
            this.dgvReporteProfesor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReporteProfesor_CellContentClick);
            // 
            // hora
            // 
            this.hora.HeaderText = "Hora";
            this.hora.Name = "hora";
            this.hora.ReadOnly = true;
            // 
            // lunes
            // 
            this.lunes.HeaderText = "Lunes";
            this.lunes.Name = "lunes";
            this.lunes.ReadOnly = true;
            // 
            // martes
            // 
            this.martes.HeaderText = "Martes";
            this.martes.Name = "martes";
            this.martes.ReadOnly = true;
            // 
            // miercoles
            // 
            this.miercoles.HeaderText = "Miercoles";
            this.miercoles.Name = "miercoles";
            this.miercoles.ReadOnly = true;
            // 
            // jueves
            // 
            this.jueves.HeaderText = "Jueves";
            this.jueves.Name = "jueves";
            this.jueves.ReadOnly = true;
            // 
            // viernes
            // 
            this.viernes.HeaderText = "Viernes";
            this.viernes.Name = "viernes";
            this.viernes.ReadOnly = true;
            // 
            // sabado
            // 
            this.sabado.HeaderText = "Sabado";
            this.sabado.Name = "sabado";
            this.sabado.ReadOnly = true;
            // 
            // lbNombreProfesor
            // 
            this.lbNombreProfesor.AutoSize = true;
            this.lbNombreProfesor.BackColor = System.Drawing.Color.Transparent;
            this.lbNombreProfesor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreProfesor.ForeColor = System.Drawing.Color.White;
            this.lbNombreProfesor.Location = new System.Drawing.Point(32, 24);
            this.lbNombreProfesor.Name = "lbNombreProfesor";
            this.lbNombreProfesor.Size = new System.Drawing.Size(151, 18);
            this.lbNombreProfesor.TabIndex = 45;
            this.lbNombreProfesor.Text = "Nombre del profesor";
            // 
            // cbProfesor
            // 
            this.cbProfesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfesor.FormattingEnabled = true;
            this.cbProfesor.Location = new System.Drawing.Point(189, 24);
            this.cbProfesor.Name = "cbProfesor";
            this.cbProfesor.Size = new System.Drawing.Size(121, 21);
            this.cbProfesor.TabIndex = 44;
            // 
            // frmReporteProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoCoordinacion.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(851, 390);
            this.Controls.Add(this.lbNombreProfesor);
            this.Controls.Add(this.cbProfesor);
            this.Controls.Add(this.dgvReporteProfesor);
            this.Name = "frmReporteProfesores";
            this.Text = "frmReporteProfesores";
            this.Load += new System.EventHandler(this.frmReporteProfesores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteProfesor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReporteProfesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn lunes;
        private System.Windows.Forms.DataGridViewTextBoxColumn martes;
        private System.Windows.Forms.DataGridViewTextBoxColumn miercoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn jueves;
        private System.Windows.Forms.DataGridViewTextBoxColumn viernes;
        private System.Windows.Forms.DataGridViewTextBoxColumn sabado;
        private System.Windows.Forms.Label lbNombreProfesor;
        private System.Windows.Forms.ComboBox cbProfesor;
    }
}