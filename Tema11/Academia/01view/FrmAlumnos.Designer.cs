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
            btnFind = new Button();
            btnRemo = new Button();
            btnIns = new Button();
            btnEdit = new Button();
            btnDR = new Button();
            btnR = new Button();
            btnL = new Button();
            btnDL = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(131, 41);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(65, 44);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(30, 15);
            lblDNI.TabIndex = 1;
            lblDNI.Text = "DNI:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(65, 82);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(131, 77);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 23);
            textBox2.TabIndex = 2;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(65, 124);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(59, 15);
            lblApellidos.TabIndex = 5;
            lblApellidos.Text = "Apellidos:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(131, 122);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(110, 23);
            textBox3.TabIndex = 4;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(65, 167);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(56, 15);
            lblTelefono.TabIndex = 7;
            lblTelefono.Text = "Teléfono:";
            lblTelefono.Click += label4_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(131, 165);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(110, 23);
            textBox4.TabIndex = 6;
            // 
            // lblPoblacion
            // 
            lblPoblacion.AutoSize = true;
            lblPoblacion.Location = new Point(65, 210);
            lblPoblacion.Name = "lblPoblacion";
            lblPoblacion.Size = new Size(63, 15);
            lblPoblacion.TabIndex = 9;
            lblPoblacion.Text = "Población:";
            lblPoblacion.Click += label5_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(131, 208);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(110, 23);
            textBox5.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(284, 41);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(379, 187);
            dataGridView1.TabIndex = 10;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(523, 280);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(63, 23);
            btnFind.TabIndex = 46;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            // 
            // btnRemo
            // 
            btnRemo.Location = new Point(454, 280);
            btnRemo.Name = "btnRemo";
            btnRemo.Size = new Size(63, 23);
            btnRemo.TabIndex = 45;
            btnRemo.Text = "Remove";
            btnRemo.UseVisualStyleBackColor = true;
            // 
            // btnIns
            // 
            btnIns.Location = new Point(385, 280);
            btnIns.Name = "btnIns";
            btnIns.Size = new Size(63, 23);
            btnIns.TabIndex = 44;
            btnIns.Text = "Insert";
            btnIns.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(316, 280);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(63, 23);
            btnEdit.TabIndex = 43;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDR
            // 
            btnDR.Location = new Point(247, 280);
            btnDR.Name = "btnDR";
            btnDR.Size = new Size(63, 23);
            btnDR.TabIndex = 42;
            btnDR.Text = ">>";
            btnDR.UseVisualStyleBackColor = true;
            // 
            // btnR
            // 
            btnR.Location = new Point(178, 280);
            btnR.Name = "btnR";
            btnR.Size = new Size(63, 23);
            btnR.TabIndex = 41;
            btnR.Text = ">";
            btnR.UseVisualStyleBackColor = true;
            // 
            // btnL
            // 
            btnL.Location = new Point(109, 280);
            btnL.Name = "btnL";
            btnL.Size = new Size(63, 23);
            btnL.TabIndex = 40;
            btnL.Text = "<";
            btnL.UseVisualStyleBackColor = true;
            // 
            // btnDL
            // 
            btnDL.AutoSize = true;
            btnDL.Location = new Point(40, 280);
            btnDL.Name = "btnDL";
            btnDL.Size = new Size(63, 25);
            btnDL.TabIndex = 39;
            btnDL.Text = "<<";
            btnDL.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(592, 280);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(63, 23);
            btnClear.TabIndex = 47;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // FrmAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            ControlBox = false;
            Controls.Add(btnClear);
            Controls.Add(btnFind);
            Controls.Add(btnRemo);
            Controls.Add(btnIns);
            Controls.Add(btnEdit);
            Controls.Add(btnDR);
            Controls.Add(btnR);
            Controls.Add(btnL);
            Controls.Add(btnDL);
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
            Margin = new Padding(3, 2, 3, 2);
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
        private Button btnFind;
        private Button btnRemo;
        private Button btnIns;
        private Button btnEdit;
        private Button btnDR;
        private Button btnR;
        private Button btnL;
        private Button btnDL;
        private Button btnClear;
    }
}