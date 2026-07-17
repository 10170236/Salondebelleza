namespace SalonDeBelleza.Views
{
    partial class Formmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formmenu));
            menuStrip1 = new MenuStrip();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            citasToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            empleadosToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem1 = new ToolStripMenuItem();
            serviciosToolStripMenuItem1 = new ToolStripMenuItem();
            cítasToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem1 = new ToolStripMenuItem();
            panelContenedor = new Panel();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AllowClickThrough = true;
            menuStrip1.BackColor = Color.Plum;
            menuStrip1.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, citasToolStripMenuItem, productosToolStripMenuItem, empleadosToolStripMenuItem, reportesToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(888, 36);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(97, 32);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // citasToolStripMenuItem
            // 
            citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            citasToolStripMenuItem.Size = new Size(73, 32);
            citasToolStripMenuItem.Text = "Citas";
            citasToolStripMenuItem.Click += citasToolStripMenuItem_Click;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(120, 32);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
            // 
            // empleadosToolStripMenuItem
            // 
            empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            empleadosToolStripMenuItem.Size = new Size(127, 32);
            empleadosToolStripMenuItem.Text = "Empleados";
            empleadosToolStripMenuItem.Click += empleadosToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productosToolStripMenuItem1, serviciosToolStripMenuItem1, cítasToolStripMenuItem, reportesToolStripMenuItem1 });
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(169, 32);
            reportesToolStripMenuItem.Text = "Administracion";
            reportesToolStripMenuItem.Click += reportesToolStripMenuItem_Click;
            // 
            // productosToolStripMenuItem1
            // 
            productosToolStripMenuItem1.Name = "productosToolStripMenuItem1";
            productosToolStripMenuItem1.Size = new Size(180, 32);
            productosToolStripMenuItem1.Text = "Productos";
            productosToolStripMenuItem1.Click += productosToolStripMenuItem1_Click;
            // 
            // serviciosToolStripMenuItem1
            // 
            serviciosToolStripMenuItem1.Name = "serviciosToolStripMenuItem1";
            serviciosToolStripMenuItem1.Size = new Size(180, 32);
            serviciosToolStripMenuItem1.Text = "Servicios";
            serviciosToolStripMenuItem1.Click += serviciosToolStripMenuItem1_Click;
            // 
            // cítasToolStripMenuItem
            // 
            cítasToolStripMenuItem.Name = "cítasToolStripMenuItem";
            cítasToolStripMenuItem.Size = new Size(180, 32);
            cítasToolStripMenuItem.Text = "Cítas";
            cítasToolStripMenuItem.Click += cítasToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem1
            // 
            reportesToolStripMenuItem1.Name = "reportesToolStripMenuItem1";
            reportesToolStripMenuItem1.Size = new Size(180, 32);
            reportesToolStripMenuItem1.Text = "Reportes";
            reportesToolStripMenuItem1.Click += reportesToolStripMenuItem1_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackgroundImage = (Image)resources.GetObject("panelContenedor.BackgroundImage");
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 36);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(888, 465);
            panelContenedor.TabIndex = 1;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(68, 32);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // Formmenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(888, 501);
            Controls.Add(panelContenedor);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Formmenu";
            Text = "Formmenu";
            Load += Formmenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem empleadosToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem citasToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private Panel panelContenedor;
        private ToolStripMenuItem productosToolStripMenuItem1;
        private ToolStripMenuItem serviciosToolStripMenuItem1;
        private ToolStripMenuItem cítasToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem1;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}