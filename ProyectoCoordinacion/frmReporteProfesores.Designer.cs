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
            this.txtNombreProf = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
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
            this.dgvReporteProfesor.Location = new System.Drawing.Point(64, 105);
            this.dgvReporteProfesor.Name = "dgvReporteProfesor";
            this.dgvReporteProfesor.ReadOnly = true;
            this.dgvReporteProfesor.Size = new System.Drawing.Size(746, 399);
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
            this.lbNombreProfesor.Location = new System.Drawing.Point(32, 37);
            this.lbNombreProfesor.Name = "lbNombreProfesor";
            this.lbNombreProfesor.Size = new System.Drawing.Size(151, 18);
            this.lbNombreProfesor.TabIndex = 45;
            this.lbNombreProfesor.Text = "Nombre del profesor";
            // 
            // txtNombreProf
            // 
            this.txtNombreProf.Location = new System.Drawing.Point(211, 37);
            this.txtNombreProf.Name = "txtNombreProf";
            this.txtNombreProf.Size = new System.Drawing.Size(159, 20);
            this.txtNombreProf.TabIndex = 46;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(766, 540);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 41);
            this.btnSalir.TabIndex = 47;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(398, 31);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(81, 31);
            this.btnBuscar.TabIndex = 48;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmReporteProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoCoordinacion.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(868, 593);
            this.ControlBox = false;
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtNombreProf);
            this.Controls.Add(this.lbNombreProfesor);
            this.Controls.Add(this.dgvReporteProfesor);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReporteProfesores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.TextBox txtNombreProf;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBuscar;
    }
}