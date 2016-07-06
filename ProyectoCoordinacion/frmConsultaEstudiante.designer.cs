namespace Vista
{
    partial class frmConsultaEstudiante
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
            this.lvEstudiantes = new System.Windows.Forms.ListView();
            this.nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.carnet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvEstudiantes
            // 
            this.lvEstudiantes.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvEstudiantes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nombre,
            this.carnet});
            this.lvEstudiantes.FullRowSelect = true;
            this.lvEstudiantes.GridLines = true;
            this.lvEstudiantes.Location = new System.Drawing.Point(16, 15);
            this.lvEstudiantes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvEstudiantes.Name = "lvEstudiantes";
            this.lvEstudiantes.Size = new System.Drawing.Size(344, 228);
            this.lvEstudiantes.TabIndex = 0;
            this.lvEstudiantes.UseCompatibleStateImageBehavior = false;
            this.lvEstudiantes.View = System.Windows.Forms.View.Details;
            this.lvEstudiantes.SelectedIndexChanged += new System.EventHandler(this.lvEstudiantes_SelectedIndexChanged);
            this.lvEstudiantes.DoubleClick += new System.EventHandler(this.lvEstudiantes_DoubleClick);
            // 
            // nombre
            // 
            this.nombre.Text = "Nombre";
            // 
            // carnet
            // 
            this.carnet.Text = "Carnet";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCerrar.FlatAppearance.BorderSize = 2;
            this.btnCerrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCerrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.Black;
            this.btnCerrar.Location = new System.Drawing.Point(251, 262);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(111, 46);
            this.btnCerrar.TabIndex = 29;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // frmConsultaEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoCoordinacion.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(379, 322);
            this.ControlBox = false;
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lvEstudiantes);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmConsultaEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta de los Estudiantes";
            this.Load += new System.EventHandler(this.frmConRapEstud_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvEstudiantes;
        private System.Windows.Forms.ColumnHeader nombre;
        private System.Windows.Forms.ColumnHeader carnet;
        private System.Windows.Forms.Button btnCerrar;
    }
}