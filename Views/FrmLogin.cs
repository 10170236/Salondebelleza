using System;
using System.Drawing;
using System.Windows.Forms;
using SalonDeBelleza.Data;
using System.Linq;

namespace SalonDeBelleza.Views
{
    public partial class FrmLogin : Form
    {
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblUsuario;
        private Label lblPassword;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.txtUsuario = new TextBox();
            this.txtPassword = new TextBox();
            this.btnLogin = new Button();
            this.lblUsuario = new Label();
            this.lblPassword = new Label();
            
            this.SuspendLayout();
            
            // lblUsuario
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new Point(50, 40);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new Size(60, 20);
            this.lblUsuario.Text = "Usuario:";
            
            // txtUsuario
            this.txtUsuario.Location = new Point(130, 37);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new Size(200, 27);
            
            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new Point(50, 90);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new Size(86, 20);
            this.lblPassword.Text = "Contraseña:";
            
            // txtPassword
            this.txtPassword.Location = new Point(130, 87);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new Size(200, 27);
            
            // btnLogin
            this.btnLogin.Location = new Point(130, 140);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new Size(100, 35);
            this.btnLogin.Text = "Iniciar Sesión";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new EventHandler(this.BtnLogin_Click);
            
            // FrmLogin
            this.ClientSize = new Size(400, 230);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Name = "FrmLogin";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesión - Salón de Belleza";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void BtnLogin_Click(object? sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor ingrese usuario y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new SalonContext())
            {
                var user = context.Usuarios.FirstOrDefault(u => u.NombreUsuario == usuario && u.Password == password);

                if (user != null)
                {
                    // Login exitoso
                    MessageBox.Show($"Bienvenido {user.NombreUsuario} ({user.Rol})", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    FrmMenuPrincipal menu = new FrmMenuPrincipal(user.Rol);
                    this.Hide();
                    menu.ShowDialog();
                    this.Close(); // Cerrar aplicación después del menú
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
