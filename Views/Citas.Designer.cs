namespace SalonDeBelleza.Views
{
    partial class Citas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Citas));
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            label5 = new Label();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            dataGridView2 = new DataGridView();
            label2 = new Label();
            button2 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PaleVioletRed;
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(33, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(378, 441);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Servicio";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = Color.LightPink;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(331, 302);
            dataGridView1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(81, 36);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(273, 22);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(19, 38);
            label1.Name = "label1";
            label1.Size = new Size(56, 16);
            label1.TabIndex = 0;
            label1.Text = "Buscar";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.PaleVioletRed;
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(417, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(436, 441);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dato de la cita";
            // 
            // button1
            // 
            button1.BackColor = Color.LightPink;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(161, 394);
            button1.Name = "button1";
            button1.Size = new Size(111, 37);
            button1.TabIndex = 9;
            button1.Text = "Agendar";
            button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(11, 398);
            label5.Name = "label5";
            label5.Size = new Size(144, 23);
            label5.TabIndex = 8;
            label5.Text = "Total: $0:00";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(87, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(267, 23);
            textBox2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(88, 58);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(266, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(19, 92);
            label4.Name = "label4";
            label4.Size = new Size(42, 16);
            label4.TabIndex = 5;
            label4.Text = "Hora";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(19, 61);
            label3.Name = "label3";
            label3.Size = new Size(49, 16);
            label3.TabIndex = 4;
            label3.Text = "Fecha";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(88, 28);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(266, 23);
            comboBox1.TabIndex = 3;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.BackgroundColor = Color.LightPink;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(23, 119);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(397, 258);
            dataGridView2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(19, 32);
            label2.Name = "label2";
            label2.Size = new Size(58, 16);
            label2.TabIndex = 0;
            label2.Text = "Cliente";
            // 
            // button2
            // 
            button2.BackColor = Color.LightPink;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(278, 394);
            button2.Name = "button2";
            button2.Size = new Size(111, 37);
            button2.TabIndex = 10;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = false;
            // 
            // Citas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Name = "Citas";
            Size = new Size(888, 472);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private DataGridView dataGridView2;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label3;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Label label5;
        private Button button1;
        private Button button2;
    }
}
