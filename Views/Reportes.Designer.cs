namespace SalonDeBelleza.Views
{
    partial class Reportes
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes));
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PaleVioletRed;
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(79, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(730, 378);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Facturas";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(43, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 23);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(43, 31);
            label1.Name = "label1";
            label1.Size = new Size(186, 16);
            label1.TabIndex = 1;
            label1.Text = "Identificacion de servicio";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightPink;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(687, 238);
            dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(262, 31);
            label2.Name = "label2";
            label2.Size = new Size(156, 16);
            label2.TabIndex = 8;
            label2.Text = "Identificacion de cita";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(468, 31);
            label3.Name = "label3";
            label3.Size = new Size(168, 16);
            label3.TabIndex = 9;
            label3.Text = "Nombre de comprador";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(262, 50);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 23);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(468, 50);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(186, 23);
            textBox3.TabIndex = 11;
            // 
            // button2
            // 
            button2.BackColor = Color.LightPink;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(25, 335);
            button2.Name = "button2";
            button2.Size = new Size(111, 37);
            button2.TabIndex = 12;
            button2.Text = "Generar Reporte";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LightPink;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(145, 335);
            button1.Name = "button1";
            button1.Size = new Size(111, 37);
            button1.TabIndex = 13;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LightPink;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(262, 335);
            button3.Name = "button3";
            button3.Size = new Size(111, 37);
            button3.TabIndex = 14;
            button3.Text = "Enbiar Correo";
            button3.UseVisualStyleBackColor = false;
            // 
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Name = "Reportes";
            Size = new Size(888, 472);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button3;
        private Button button1;
        private Button button2;
    }
}
