namespace Academia._01view
{
    partial class FrmAcademia
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
            btnAlum = new Button();
            btnCurso = new Button();
            mySqlCommandBuilder1 = new MySqlConnector.MySqlCommandBuilder();
            SuspendLayout();
            // 
            // btnAlum
            // 
            btnAlum.AutoSize = true;
            btnAlum.Location = new Point(174, 298);
            btnAlum.Name = "btnAlum";
            btnAlum.Size = new Size(201, 33);
            btnAlum.TabIndex = 0;
            btnAlum.Text = "Mantenimiento de alumnos";
            btnAlum.UseVisualStyleBackColor = true;
            btnAlum.Click += btnAlum_Click;
            // 
            // btnCurso
            // 
            btnCurso.AutoSize = true;
            btnCurso.Location = new Point(422, 298);
            btnCurso.Name = "btnCurso";
            btnCurso.Size = new Size(186, 33);
            btnCurso.TabIndex = 1;
            btnCurso.Text = "Mantenimiento de cursos";
            btnCurso.UseVisualStyleBackColor = true;
            btnCurso.Click += btnCurso_Click;
            // 
            // mySqlCommandBuilder1
            // 
            mySqlCommandBuilder1.DataAdapter = null;
            mySqlCommandBuilder1.QuotePrefix = "`";
            mySqlCommandBuilder1.QuoteSuffix = "`";
            // 
            // FrmAcademia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(btnCurso);
            Controls.Add(btnAlum);
            Name = "FrmAcademia";
            Text = "FrmAcademia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAlum;
        private Button btnCurso;
        private MySqlConnector.MySqlCommandBuilder mySqlCommandBuilder1;
        private void btnAlum_Click(object sender, EventArgs e)
        {
            FrmAlumnos frmAlumnos = new FrmAlumnos();
            frmAlumnos.ShowDialog();

        }
        private void btnCurso_Click(object sender, EventArgs e)
        {
            FrmCursos frmCursos = new FrmCursos();
            frmCursos.ShowDialog();
        }
    }
}