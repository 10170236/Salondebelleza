using System;
using System.Drawing;
using System.Windows.Forms;
using SalonDeBelleza.Data;
using System.Linq;

namespace SalonDeBelleza.Views
{
    public partial class FrmLogin : Form
    {
        private Button btnLogin;
        private Label lblUsuario;
        private GroupBox groupBox1;
        private Label label1;
        private Button button2;
        private Button button1;
        private Label lblPassword;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblUsuario = new Label();
            lblPassword = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Location = new Point(142, 54);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(200, 27);
            txtUsuario.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(142, 104);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LightPink;
            btnLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Location = new Point(82, 154);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 35);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Iniciar Sesión";
            btnLogin.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += BtnLogin_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblUsuario.Location = new Point(40, 61);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(67, 16);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario:";
            lblUsuario.Click += lblUsuario_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblPassword.Location = new Point(40, 111);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(96, 16);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Contraseña:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PaleVioletRed;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(lblPassword);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(lblUsuario);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Location = new Point(62, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(462, 213);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 24F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(117, 8);
            label1.Name = "label1";
            label1.Size = new Size(248, 43);
            label1.TabIndex = 7;
            label1.Text = "Salon de belleza";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightPink;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(294, 154);
            button2.Name = "button2";
            button2.Size = new Size(100, 35);
            button2.TabIndex = 6;
            button2.Text = "Limpiar";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightPink;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(188, 154);
            button1.Name = "button1";
            button1.Size = new Size(100, 35);
            button1.TabIndex = 5;
            button1.Text = "Cerrar";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FrmLogin
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(582, 298);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesión - Salón de Belleza";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        private void BtnLogin_Click(object? sender, EventArgs e)
        {
            Formmenu nuevoForm = new Formmenu();
            nuevoForm.Show();
            this.Hide();   // Oculta el formulario actual en vez de cerrarlo
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();   // Limpia el contenido del primer TextBox
            txtPassword.Clear();
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public TextBox txtUsuario;
        public TextBox txtPassword;

    }
}
