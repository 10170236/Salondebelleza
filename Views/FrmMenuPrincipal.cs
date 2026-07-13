using System;
using System.Drawing;
using System.Windows.Forms;

namespace SalonDeBelleza.Views
{
    public partial class FrmMenuPrincipal : Form
    {
        private MenuStrip menuStrip;
        private ToolStripMenuItem menuArchivo;
        private ToolStripMenuItem menuCerrarSesion;
        private ToolStripMenuItem menuSalir;
        private ToolStripMenuItem menuCatalogos;
        private ToolStripMenuItem menuClientes;
        private ToolStripMenuItem menuEmpleados;
        private ToolStripMenuItem menuServicios;
        private ToolStripMenuItem menuProductos;
        private ToolStripMenuItem menuCitas;
        private ToolStripMenuItem menuPagos;
        private ToolStripMenuItem menuReportes;
        
        private string rolUsuario;

        public FrmMenuPrincipal(string rol)
        {
            rolUsuario = rol;
            InitializeComponent();
            ConfigurarPermisos();
        }

        private void InitializeComponent()
        {
            this.menuStrip = new MenuStrip();
            this.menuArchivo = new ToolStripMenuItem("Archivo");
            this.menuCerrarSesion = new ToolStripMenuItem("Cerrar Sesión");
            this.menuSalir = new ToolStripMenuItem("Salir");
            
            this.menuCatalogos = new ToolStripMenuItem("Catálogos");
            this.menuClientes = new ToolStripMenuItem("Clientes");
            this.menuEmpleados = new ToolStripMenuItem("Empleados");
            this.menuServicios = new ToolStripMenuItem("Servicios");
            this.menuProductos = new ToolStripMenuItem("Productos");
            
            this.menuCitas = new ToolStripMenuItem("Citas");
            this.menuPagos = new ToolStripMenuItem("Pagos");
            this.menuReportes = new ToolStripMenuItem("Reportes");

            // Construir menú Archivo
            this.menuArchivo.DropDownItems.Add(this.menuCerrarSesion);
            this.menuArchivo.DropDownItems.Add(this.menuSalir);
            
            // Construir menú Catálogos
            this.menuCatalogos.DropDownItems.Add(this.menuClientes);
            this.menuCatalogos.DropDownItems.Add(this.menuEmpleados);
            this.menuCatalogos.DropDownItems.Add(this.menuServicios);
            this.menuCatalogos.DropDownItems.Add(this.menuProductos);

            // Agregar a MenuStrip
            this.menuStrip.Items.Add(this.menuArchivo);
            this.menuStrip.Items.Add(this.menuCatalogos);
            this.menuStrip.Items.Add(this.menuCitas);
            this.menuStrip.Items.Add(this.menuPagos);
            this.menuStrip.Items.Add(this.menuReportes);

            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;

            // Eventos
            this.menuSalir.Click += (s, e) => Application.Exit();
            this.menuCerrarSesion.Click += (s, e) => {
                this.Hide();
                var login = new FrmLogin();
                login.ShowDialog();
                this.Close();
            };

            // Formulario principal
            this.IsMdiContainer = true;
            this.ClientSize = new Size(800, 600);
            this.Name = "FrmMenuPrincipal";
            this.Text = "Sistema de Gestión - Salón de Belleza";
            this.WindowState = FormWindowState.Maximized;
        }

        private void ConfigurarPermisos()
        {
            if (rolUsuario == "Recepcionista")
            {
                // Un recepcionista puede que no deba gestionar empleados ni servicios/productos nuevos, solo verlos.
                // Ajustar según reglas de negocio. Por ahora, bloqueamos empleados para ejemplo.
                menuEmpleados.Enabled = false;
            }
        }
    }
}
