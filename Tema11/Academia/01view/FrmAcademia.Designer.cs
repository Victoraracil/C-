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
            btnMatri = new Button();
            mySqlCommandBuilder1 = new MySqlConnector.MySqlCommandBuilder();
            SuspendLayout();
            // 
            // btnAlum
            // 
            btnAlum.AutoSize = true;
            btnAlum.Location = new Point(82, 209);
            btnAlum.Margin = new Padding(3, 2, 3, 2);
            btnAlum.Name = "btnAlum";
            btnAlum.Size = new Size(164, 25);
            btnAlum.TabIndex = 0;
            btnAlum.Text = "Mantenimiento de alumnos";
            btnAlum.UseVisualStyleBackColor = true;
            btnAlum.Click += button1_Click;
            // 
            // btnCurso
            // 
            btnCurso.AutoSize = true;
            btnCurso.Location = new Point(299, 209);
            btnCurso.Margin = new Padding(3, 2, 3, 2);
            btnCurso.Name = "btnCurso";
            btnCurso.Size = new Size(152, 25);
            btnCurso.TabIndex = 1;
            btnCurso.Text = "Mantenimiento de cursos";
            btnCurso.UseVisualStyleBackColor = true;
            // 
            // btnMatri
            // 
            btnMatri.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMatri.AutoSize = true;
            btnMatri.Location = new Point(507, 209);
            btnMatri.Margin = new Padding(3, 2, 3, 2);
            btnMatri.Name = "btnMatri";
            btnMatri.Size = new Size(90, 25);
            btnMatri.TabIndex = 2;
            btnMatri.Text = "Matriculación";
            btnMatri.UseVisualStyleBackColor = true;
            // 
            // mySqlCommandBuilder1
            // 
            mySqlCommandBuilder1.DataAdapter = null;
            mySqlCommandBuilder1.QuotePrefix = "`";
            mySqlCommandBuilder1.QuoteSuffix = "`";
            // 
            // FrmAcademia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnMatri);
            Controls.Add(btnCurso);
            Controls.Add(btnAlum);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmAcademia";
            Text = "FrmAcademia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAlum;
        private Button btnCurso;
        private Button btnMatri;
        private MySqlConnector.MySqlCommandBuilder mySqlCommandBuilder1;
    }
}