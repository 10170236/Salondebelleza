using SalonDeBelleza.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SalonDeBelleza.Views
{
    public partial class Formmenu : Form
    {
        public Formmenu()
        {
            InitializeComponent();
        }

        private void Formmenu_Load(object sender, EventArgs e)
        {

        }

        // Cambiamos el parámetro para que reciba específicamente un UserControl
        private void AbrirControlEnPanel(UserControl controlHijo)
        {
            // 1. Validamos que el panel realmente exista en tu diseño
            if (this.panelContenedor == null)
            {
                MessageBox.Show("Error: El panel 'panelContenedor' no existe o tiene otro nombre en el diseño.");
                return;
            }

            // 2. Si ya hay un control dentro del panel, lo removemos para meter el nuevo
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }

            // 3. Hacemos que el UserControl se estire para ocupar todo el tamaño del panel
            controlHijo.Dock = DockStyle.Fill;

            // 4. Lo agregamos al panel y lo mostramos
            this.panelContenedor.Controls.Add(controlHijo);
            this.panelContenedor.Tag = controlHijo;
            controlHijo.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirControlEnPanel(new Clientes());
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirControlEnPanel(new Empleados());
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirControlEnPanel(new Servicios());
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirControlEnPanel(new Productos());
        }

        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirControlEnPanel(new Citas());
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirControlEnPanel(new());
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirControlEnPanel(new Adminproduc());
        }

        private void serviciosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirControlEnPanel(new Servicios());
        }

        private void cítasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirControlEnPanel(new Admincita());
        }

        private void reportesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirControlEnPanel(new Reportes());
        }

        private void reportesToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Oculta el menú actual
            this.Hide();

            // Crea una nueva instancia del formulario de login
            FrmLogin login = new FrmLogin();
            login.Show();

            // Cierra el menú para liberar recursos
            this.Close();
        }
    }
}
