namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            btn = new Button();
            Datos = new GroupBox();
            Datos.SuspendLayout();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(28, 27);
            lbl.Name = "lbl";
            lbl.Size = new Size(67, 20);
            lbl.TabIndex = 0;
            lbl.Text = "Nombre:";
            lbl.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(101, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(119, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(101, 57);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(119, 27);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 60);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 2;
            label1.Text = "Apellido:";
            // 
            // btn
            // 
            btn.BackColor = Color.White;
            btn.Location = new Point(58, 105);
            btn.Name = "btn";
            btn.Size = new Size(94, 29);
            btn.TabIndex = 4;
            btn.Text = "Añadir";
            btn.UseVisualStyleBackColor = false;
            btn.Click += label1_Click;
            // 
            // Datos
            // 
            Datos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Datos.Controls.Add(textBox2);
            Datos.Controls.Add(btn);
            Datos.Controls.Add(lbl);
            Datos.Controls.Add(textBox1);
            Datos.Controls.Add(label1);
            Datos.Location = new Point(12, 12);
            Datos.Name = "Datos";
            Datos.Size = new Size(250, 149);
            Datos.TabIndex = 5;
            Datos.TabStop = false;
            Datos.Text = "Datos de usuario";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(688, 333);
            Controls.Add(Datos);
            Name = "Form1";
            Text = "PrimeraApp";
            Load += Form1_Load;
            Datos.ResumeLayout(false);
            Datos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lbl;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Button btn;
        private GroupBox groupBox1;
        private GroupBox Datos;
    }
}
