namespace Vista
{
    partial class frmDatosProfesores
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
            this.dgvProfesor = new System.Windows.Forms.DataGridView();
            this.idProfesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProfesor
            // 
            this.dgvProfesor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProfesor,
            this.nombre,
            this.apellido1,
            this.apellido2});
            this.dgvProfesor.Location = new System.Drawing.Point(12, 27);
            this.dgvProfesor.Name = "dgvProfesor";
            this.dgvProfesor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProfesor.Size = new System.Drawing.Size(766, 296);
            this.dgvProfesor.TabIndex = 0;
            this.dgvProfesor.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProfesor_RowHeaderMouseClick);
            // 
            // idProfesor
            // 
            this.idProfesor.HeaderText = "ID";
            this.idProfesor.Name = "idProfesor";
            this.idProfesor.Visible = false;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // apellido1
            // 
            this.apellido1.HeaderText = "Primer Apellido";
            this.apellido1.Name = "apellido1";
            // 
            // apellido2
            // 
            this.apellido2.HeaderText = "Segundo Apellido";
            this.apellido2.Name = "apellido2";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(681, 355);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 38);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmDatosProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoCoordinacion.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(790, 405);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvProfesor);
            this.Name = "frmDatosProfesores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDatosProfesores";
            this.Load += new System.EventHandler(this.frmDatosProfesores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProfesor;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProfesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido2;
    }
}