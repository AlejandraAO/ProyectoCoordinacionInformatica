﻿namespace Vista
{
    partial class menuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónSwProyectosDeSoftwareLibreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.empresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gestiónDeProyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeMiembrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miembrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeCursosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.viewMenu,
            this.toolsMenu,
            this.empresasToolStripMenuItem,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(649, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(60, 20);
            this.fileMenu.Text = "&Archivo";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.exitToolStripMenuItem.Text = "&Salir";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónSwProyectosDeSoftwareLibreToolStripMenuItem,
            this.gestiónDeCursosToolStripMenuItem,
            this.gestiónDeCursosToolStripMenuItem1});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(91, 20);
            this.editMenu.Text = "&Coordinación";
            // 
            // gestiónSwProyectosDeSoftwareLibreToolStripMenuItem
            // 
            this.gestiónSwProyectosDeSoftwareLibreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónDeProyectosToolStripMenuItem,
            this.gestiónDeMiembrosToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.gestiónSwProyectosDeSoftwareLibreToolStripMenuItem.Name = "gestiónSwProyectosDeSoftwareLibreToolStripMenuItem";
            this.gestiónSwProyectosDeSoftwareLibreToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.gestiónSwProyectosDeSoftwareLibreToolStripMenuItem.Text = "Gestión de Proyectos de Software Libre";
            this.gestiónSwProyectosDeSoftwareLibreToolStripMenuItem.Click += new System.EventHandler(this.gestiónSwProyectosDeSoftwareLibreToolStripMenuItem_Click);
            // 
            // gestiónDeCursosToolStripMenuItem
            // 
            this.gestiónDeCursosToolStripMenuItem.Name = "gestiónDeCursosToolStripMenuItem";
            this.gestiónDeCursosToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.gestiónDeCursosToolStripMenuItem.Text = "Gestión de Cursos Libres";
            // 
            // viewMenu
            // 
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(79, 20);
            this.viewMenu.Text = "&Estudiantes";
            // 
            // toolsMenu
            // 
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(74, 20);
            this.toolsMenu.Text = "&Profesores";
            // 
            // empresasToolStripMenuItem
            // 
            this.empresasToolStripMenuItem.Name = "empresasToolStripMenuItem";
            this.empresasToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.empresasToolStripMenuItem.Text = "Empresas";
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(53, 20);
            this.helpMenu.Text = "Ay&uda";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(144, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.aboutToolStripMenuItem.Text = "&Acerca de... ...";
            // 
            // gestiónDeProyectosToolStripMenuItem
            // 
            this.gestiónDeProyectosToolStripMenuItem.Name = "gestiónDeProyectosToolStripMenuItem";
            this.gestiónDeProyectosToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.gestiónDeProyectosToolStripMenuItem.Text = "Gestión de Proyectos";
            // 
            // gestiónDeMiembrosToolStripMenuItem
            // 
            this.gestiónDeMiembrosToolStripMenuItem.Name = "gestiónDeMiembrosToolStripMenuItem";
            this.gestiónDeMiembrosToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.gestiónDeMiembrosToolStripMenuItem.Text = "Gestión de Miembros";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miembrosToolStripMenuItem,
            this.proyectosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // miembrosToolStripMenuItem
            // 
            this.miembrosToolStripMenuItem.Name = "miembrosToolStripMenuItem";
            this.miembrosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.miembrosToolStripMenuItem.Text = "Miembros";
            // 
            // proyectosToolStripMenuItem
            // 
            this.proyectosToolStripMenuItem.Name = "proyectosToolStripMenuItem";
            this.proyectosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.proyectosToolStripMenuItem.Text = "Proyectos";
            // 
            // gestiónDeCursosToolStripMenuItem1
            // 
            this.gestiónDeCursosToolStripMenuItem1.Name = "gestiónDeCursosToolStripMenuItem1";
            this.gestiónDeCursosToolStripMenuItem1.Size = new System.Drawing.Size(279, 22);
            this.gestiónDeCursosToolStripMenuItem1.Text = "Gestión de Cursos";
            // 
            // menuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 453);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "menuPrincipal";
            this.Text = "Coordinación de InformáticaEmpresarial  UCR";
            this.Load += new System.EventHandler(this.menuPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem empresasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónSwProyectosDeSoftwareLibreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeCursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeProyectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeMiembrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miembrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proyectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeCursosToolStripMenuItem1;
    }
}


