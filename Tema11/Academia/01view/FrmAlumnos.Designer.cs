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
        //programar funcionalidad de los botones
        public void InitializeButtons()
        {
            btnFind.Click += new EventHandler(btnFind_Click);
            btnRemo.Click += new EventHandler(btnRemo_Click);
            btnIns.Click += new EventHandler(btnIns_Click);
            btnEdit.Click += new EventHandler(btnEdit_Click);
            btnDR.Click += new EventHandler(btnDR_Click);
            btnR.Click += new EventHandler(btnR_Click);
            btnL.Click += new EventHandler(btnL_Click);
            btnDL.Click += new EventHandler(btnDL_Click);
            btnClear.Click += new EventHandler(btnClear_Click);
            dgvAlumno.DataSource = this.GestionAlumnos.GetAll();

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
            dgvAlumno = new DataGridView();
            btnFind = new Button();
            btnRemo = new Button();
            btnIns = new Button();
            btnEdit = new Button();
            btnDR = new Button();
            btnR = new Button();
            btnL = new Button();
            btnDL = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAlumno).BeginInit();
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
            lblDNI.Location = new Point(74, 59);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(38, 20);
            lblDNI.TabIndex = 1;
            lblDNI.Text = "DNI:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(74, 109);
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
            textBox3.Location = new Point(150, 163);
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
            // dgvAlumno
            // 
            dgvAlumno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumno.Location = new Point(325, 55);
            dgvAlumno.Name = "dgvAlumno";
            dgvAlumno.RowHeadersWidth = 51;
            dgvAlumno.Size = new Size(433, 249);
            dgvAlumno.TabIndex = 10;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(598, 373);
            btnFind.Margin = new Padding(3, 4, 3, 4);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(72, 31);
            btnFind.TabIndex = 46;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            // 
            // btnRemo
            // 
            btnRemo.Location = new Point(519, 373);
            btnRemo.Margin = new Padding(3, 4, 3, 4);
            btnRemo.Name = "btnRemo";
            btnRemo.Size = new Size(72, 31);
            btnRemo.TabIndex = 45;
            btnRemo.Text = "Remove";
            btnRemo.UseVisualStyleBackColor = true;
            // 
            // btnIns
            // 
            btnIns.Location = new Point(440, 373);
            btnIns.Margin = new Padding(3, 4, 3, 4);
            btnIns.Name = "btnIns";
            btnIns.Size = new Size(72, 31);
            btnIns.TabIndex = 44;
            btnIns.Text = "Insert";
            btnIns.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(361, 373);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(72, 31);
            btnEdit.TabIndex = 43;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDR
            // 
            btnDR.Location = new Point(282, 373);
            btnDR.Margin = new Padding(3, 4, 3, 4);
            btnDR.Name = "btnDR";
            btnDR.Size = new Size(72, 31);
            btnDR.TabIndex = 42;
            btnDR.Text = ">>";
            btnDR.UseVisualStyleBackColor = true;
            // 
            // btnR
            // 
            btnR.Location = new Point(203, 373);
            btnR.Margin = new Padding(3, 4, 3, 4);
            btnR.Name = "btnR";
            btnR.Size = new Size(72, 31);
            btnR.TabIndex = 41;
            btnR.Text = ">";
            btnR.UseVisualStyleBackColor = true;
            // 
            // btnL
            // 
            btnL.Location = new Point(125, 373);
            btnL.Margin = new Padding(3, 4, 3, 4);
            btnL.Name = "btnL";
            btnL.Size = new Size(72, 31);
            btnL.TabIndex = 40;
            btnL.Text = "<";
            btnL.UseVisualStyleBackColor = true;
            // 
            // btnDL
            // 
            btnDL.AutoSize = true;
            btnDL.Location = new Point(46, 373);
            btnDL.Margin = new Padding(3, 4, 3, 4);
            btnDL.Name = "btnDL";
            btnDL.Size = new Size(72, 33);
            btnDL.TabIndex = 39;
            btnDL.Text = "<<";
            btnDL.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(677, 373);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(72, 31);
            btnClear.TabIndex = 47;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // FrmAlumnos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
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
            Controls.Add(dgvAlumno);
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
            ((System.ComponentModel.ISupportInitialize)dgvAlumno).EndInit();
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
        private DataGridView dgvAlumno;
        private Button btnFind;
        private Button btnRemo;
        private Button btnIns;
        private Button btnEdit;
        private Button btnDR;
        private Button btnR;
        private Button btnL;
        private Button btnDL;
        private Button btnClear;
        private MySqlConnector.MySqlCommandBuilder mySqlCommandBuilder1;


        private void MapearNegocioPresentacion()//del objeto alumno a los textbox
        {
            textBox1.Text = Alumno.Dni;
            textBox2.Text = Alumno.Nombre;
            textBox3.Text = Alumno.Apellidos;
            textBox4.Text = Alumno.Telefono;
            textBox5.Text = Alumno.Poblacion;
        }
        private void MapearPresentacionNegocio()//de los textbox al objeto alumno
        {
            Alumno.Dni = textBox1.Text;
            Alumno.Nombre = textBox2.Text;
            Alumno.Apellidos = textBox3.Text;
            Alumno.Telefono = textBox4.Text;
            Alumno.Poblacion = textBox5.Text;
        }
    }
}