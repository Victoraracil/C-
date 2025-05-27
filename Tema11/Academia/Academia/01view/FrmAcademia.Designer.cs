namespace Academia._01view
{
    partial class FrmAcademia
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAcademia));
            btnMantenimientoAlumno = new Button();
            btnMantenimientoCurso = new Button();
            pictureBox1 = new PictureBox();
            btnMatriculacion = new Button();
            labelnombre = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnMantenimientoAlumno
            // 
            btnMantenimientoAlumno.Location = new Point(136, 660);
            btnMantenimientoAlumno.Margin = new Padding(5, 4, 5, 4);
            btnMantenimientoAlumno.Name = "btnMantenimientoAlumno";
            btnMantenimientoAlumno.Size = new Size(359, 53);
            btnMantenimientoAlumno.TabIndex = 0;
            btnMantenimientoAlumno.Text = "Mantenimiento de alumnos";
            btnMantenimientoAlumno.UseVisualStyleBackColor = true;
            btnMantenimientoAlumno.Click += btnAlumnos_Click;
            // 
            // btnMantenimientoCurso
            // 
            btnMantenimientoCurso.Location = new Point(555, 660);
            btnMantenimientoCurso.Margin = new Padding(5, 4, 5, 4);
            btnMantenimientoCurso.Name = "btnMantenimientoCurso";
            btnMantenimientoCurso.Size = new Size(359, 53);
            btnMantenimientoCurso.TabIndex = 1;
            btnMantenimientoCurso.Text = "Mantenimiento de cursos";
            btnMantenimientoCurso.UseVisualStyleBackColor = true;
            btnMantenimientoCurso.Click += btnCursos_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(254, 39);
            pictureBox1.Margin = new Padding(5, 4, 5, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(914, 563);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnMatriculacion
            // 
            btnMatriculacion.Location = new Point(993, 660);
            btnMatriculacion.Margin = new Padding(5, 4, 5, 4);
            btnMatriculacion.Name = "btnMatriculacion";
            btnMatriculacion.Size = new Size(359, 53);
            btnMatriculacion.TabIndex = 2;
            btnMatriculacion.Text = "Matriculacion";
            btnMatriculacion.UseVisualStyleBackColor = true;
            btnMatriculacion.Click += btnMatriculas_Click;
            // 
            // labelnombre
            // 
            labelnombre.AutoSize = true;
            labelnombre.Location = new Point(1259, 774);
            labelnombre.Margin = new Padding(5, 0, 5, 0);
            labelnombre.Name = "labelnombre";
            labelnombre.Size = new Size(200, 20);
            labelnombre.TabIndex = 4;
            labelnombre.Text = "Victor Aracil Gozalvez 1DAM";
            labelnombre.Click += labelnombre_Click;
            // 
            // FrmAcademia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1473, 803);
            Controls.Add(labelnombre);
            Controls.Add(pictureBox1);
            Controls.Add(btnMatriculacion);
            Controls.Add(btnMantenimientoCurso);
            Controls.Add(btnMantenimientoAlumno);
            HelpButton = true;
            Margin = new Padding(5, 4, 5, 4);
            Name = "FrmAcademia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAcademia";
            Load += FrmAcademia_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnMantenimientoAlumno;
        private System.Windows.Forms.Button btnMantenimientoCurso;
        private System.Windows.Forms.Button btnMatriculacion;
        private System.Windows.Forms.Label labelnombre;
        private PictureBox pictureBox1;
    }
}