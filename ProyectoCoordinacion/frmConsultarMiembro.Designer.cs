namespace Vista
{
    partial class frmConsultarMiembro
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.idMiembro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.apellido1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.apellido2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Proyecto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
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
            this.btnCerrar.Location = new System.Drawing.Point(584, 280);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(77, 37);
            this.btnCerrar.TabIndex = 32;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listView1.BackgroundImage = global::ProyectoCoordinacion.Properties.Resources.fondo;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idMiembro,
            this.nombre,
            this.apellido1,
            this.apellido2,
            this.Proyecto});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, -7);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(671, 271);
            this.listView1.TabIndex = 33;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // idMiembro
            // 
            this.idMiembro.Text = "IdMiembro";
            this.idMiembro.Width = 104;
            // 
            // nombre
            // 
            this.nombre.Text = "Nombre";
            this.nombre.Width = 115;
            // 
            // apellido1
            // 
            this.apellido1.Text = "Apellido1";
            this.apellido1.Width = 143;
            // 
            // apellido2
            // 
            this.apellido2.Text = "Apellido2";
            this.apellido2.Width = 146;
            // 
            // Proyecto
            // 
            this.Proyecto.Text = "Proyecto";
            this.Proyecto.Width = 330;
            // 
            // frmConsultarMiembro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoCoordinacion.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(673, 319);
            this.ControlBox = false;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnCerrar);
            this.Name = "frmConsultarMiembro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Rapida Miembro";
            this.Load += new System.EventHandler(this.frmConsultarMiembro_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader idMiembro;
        private System.Windows.Forms.ColumnHeader nombre;
        private System.Windows.Forms.ColumnHeader apellido1;
        private System.Windows.Forms.ColumnHeader apellido2;
        private System.Windows.Forms.ColumnHeader Proyecto;
    }
}