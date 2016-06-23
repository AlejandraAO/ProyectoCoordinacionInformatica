namespace Vista
{
    partial class frmConsultarProyectos
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lvProyectos = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(67, 293);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(71, 24);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lvProyectos
            // 
            this.lvProyectos.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvProyectos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.nombre});
            this.lvProyectos.FullRowSelect = true;
            this.lvProyectos.GridLines = true;
            this.lvProyectos.Location = new System.Drawing.Point(12, 12);
            this.lvProyectos.Name = "lvProyectos";
            this.lvProyectos.Size = new System.Drawing.Size(179, 264);
            this.lvProyectos.TabIndex = 2;
            this.lvProyectos.UseCompatibleStateImageBehavior = false;
            this.lvProyectos.View = System.Windows.Forms.View.Details;
            this.lvProyectos.SelectedIndexChanged += new System.EventHandler(this.lvProyectos_SelectedIndexChanged);
            this.lvProyectos.DoubleClick += new System.EventHandler(this.lvProyectos_DoubleClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 88;
            // 
            // nombre
            // 
            this.nombre.Text = "Nombre";
            this.nombre.Width = 87;
            // 
            // frmConsultarProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoCoordinacion.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(203, 329);
            this.ControlBox = false;
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lvProyectos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultarProyectos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consultar Proyectos";
            this.Load += new System.EventHandler(this.frmConsultarProyectos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ListView lvProyectos;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader nombre;
    }
}