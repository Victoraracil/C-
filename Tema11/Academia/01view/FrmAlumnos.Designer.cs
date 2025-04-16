namespace Academia._01view
{
    partial class FrmAlumnos
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
            textBox1 = new TextBox();
            lblDNI = new Label();
            lblNombre = new Label();
            textBox2 = new TextBox();
            lblApellidos = new Label();
            textBox3 = new TextBox();
            lblTelefono = new Label();
            textBox4 = new TextBox();
            lblPoblacion = new Label();
            textBox5 = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(74, 58);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(38, 20);
            lblDNI.TabIndex = 1;
            lblDNI.Text = "DNI:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(74, 110);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(150, 103);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 2;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(74, 165);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(75, 20);
            lblApellidos.TabIndex = 5;
            lblApellidos.Text = "Apellidos:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(150, 162);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 4;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(74, 223);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 7;
            lblTelefono.Text = "Teléfono:";
            lblTelefono.Click += label4_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(150, 220);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 6;
            // 
            // lblPoblacion
            // 
            lblPoblacion.AutoSize = true;
            lblPoblacion.Location = new Point(74, 280);
            lblPoblacion.Name = "lblPoblacion";
            lblPoblacion.Size = new Size(77, 20);
            lblPoblacion.TabIndex = 9;
            lblPoblacion.Text = "Población:";
            lblPoblacion.Click += label5_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(150, 277);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(325, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(433, 249);
            dataGridView1.TabIndex = 10;
            // 
            // FrmAlumnos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(dataGridView1);
            Controls.Add(lblPoblacion);
            Controls.Add(textBox5);
            Controls.Add(lblTelefono);
            Controls.Add(textBox4);
            Controls.Add(lblApellidos);
            Controls.Add(textBox3);
            Controls.Add(lblNombre);
            Controls.Add(textBox2);
            Controls.Add(lblDNI);
            Controls.Add(textBox1);
            Name = "FrmAlumnos";
            Text = "FrmAlumnos";
            Load += FrmAlumnos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label lblDNI;
        private Label lblNombre;
        private TextBox textBox2;
        private Label lblApellidos;
        private TextBox textBox3;
        private Label lblTelefono;
        private TextBox textBox4;
        private Label lblPoblacion;
        private TextBox textBox5;
        private DataGridView dataGridView1;
    }
}