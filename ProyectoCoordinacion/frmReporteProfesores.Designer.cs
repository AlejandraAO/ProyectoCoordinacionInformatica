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
            this.dgvReporteProfesor.Location = new System.Drawing.Point(149, 88);
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
            // frmReporteProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoCoordinacion.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(904, 401);
            this.Controls.Add(this.dgvReporteProfesor);
            this.Name = "frmReporteProfesores";
            this.Text = "frmReporteProfesores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteProfesor)).EndInit();
            this.ResumeLayout(false);

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
    }
}