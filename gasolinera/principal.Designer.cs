namespace gasolinera
{
    partial class principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteempleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportebombasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportetipodebombaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitacoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblidentificador = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mantenimientoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.mantenimientoUsuarioToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.bitacoraToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem1});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(122, 26);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.mantenimientoToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            this.mantenimientoToolStripMenuItem.Click += new System.EventHandler(this.MantenimientoToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteventasToolStripMenuItem,
            this.reporteempleadosToolStripMenuItem,
            this.reportebombasToolStripMenuItem,
            this.reportetipodebombaToolStripMenuItem,
            this.reporteProveedoresToolStripMenuItem});
            this.reportesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportesToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteventasToolStripMenuItem
            // 
            this.reporteventasToolStripMenuItem.Name = "reporteventasToolStripMenuItem";
            this.reporteventasToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.reporteventasToolStripMenuItem.Text = "Reporte ventas";
            this.reporteventasToolStripMenuItem.Click += new System.EventHandler(this.ReporteventasToolStripMenuItem_Click);
            // 
            // reporteempleadosToolStripMenuItem
            // 
            this.reporteempleadosToolStripMenuItem.Name = "reporteempleadosToolStripMenuItem";
            this.reporteempleadosToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.reporteempleadosToolStripMenuItem.Text = "Reporte empleados";
            this.reporteempleadosToolStripMenuItem.Click += new System.EventHandler(this.ReporteempleadosToolStripMenuItem_Click);
            // 
            // reportebombasToolStripMenuItem
            // 
            this.reportebombasToolStripMenuItem.Name = "reportebombasToolStripMenuItem";
            this.reportebombasToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.reportebombasToolStripMenuItem.Text = "Reporte bombas";
            this.reportebombasToolStripMenuItem.Click += new System.EventHandler(this.ReportebombasToolStripMenuItem_Click);
            // 
            // reportetipodebombaToolStripMenuItem
            // 
            this.reportetipodebombaToolStripMenuItem.Name = "reportetipodebombaToolStripMenuItem";
            this.reportetipodebombaToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.reportetipodebombaToolStripMenuItem.Text = "Reporte tipo de bomba";
            this.reportetipodebombaToolStripMenuItem.Click += new System.EventHandler(this.ReportetipodebombaToolStripMenuItem_Click);
            // 
            // reporteProveedoresToolStripMenuItem
            // 
            this.reporteProveedoresToolStripMenuItem.Name = "reporteProveedoresToolStripMenuItem";
            this.reporteProveedoresToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.reporteProveedoresToolStripMenuItem.Text = "Reporte Proveedores";
            this.reporteProveedoresToolStripMenuItem.Click += new System.EventHandler(this.ReporteProveedoresToolStripMenuItem_Click);
            // 
            // bitacoraToolStripMenuItem
            // 
            this.bitacoraToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bitacoraToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.bitacoraToolStripMenuItem.Name = "bitacoraToolStripMenuItem";
            this.bitacoraToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.bitacoraToolStripMenuItem.Text = "Bitacora";
            this.bitacoraToolStripMenuItem.Click += new System.EventHandler(this.BitacoraToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // lblidentificador
            // 
            this.lblidentificador.AutoSize = true;
            this.lblidentificador.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidentificador.ForeColor = System.Drawing.Color.Silver;
            this.lblidentificador.Location = new System.Drawing.Point(324, 226);
            this.lblidentificador.Name = "lblidentificador";
            this.lblidentificador.Size = new System.Drawing.Size(38, 42);
            this.lblidentificador.TabIndex = 1;
            this.lblidentificador.Text = "  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(211, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bienvenido";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // mantenimientoUsuarioToolStripMenuItem
            // 
            this.mantenimientoUsuarioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.mantenimientoUsuarioToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.mantenimientoUsuarioToolStripMenuItem.Name = "mantenimientoUsuarioToolStripMenuItem";
            this.mantenimientoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.mantenimientoUsuarioToolStripMenuItem.Text = "Mantenimiento usuario";
            this.mantenimientoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.MantenimientoUsuarioToolStripMenuItem_Click);
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblidentificador);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "principal";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label lblidentificador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem bitacoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteempleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportebombasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportetipodebombaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoUsuarioToolStripMenuItem;
    }
}