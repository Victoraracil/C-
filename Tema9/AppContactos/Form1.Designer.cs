namespace AppContactos
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
            nameLabel = new Label();
            edadLabel = new Label();
            phoneLabel = new Label();
            nameBox = new TextBox();
            phoneBox = new TextBox();
            ageBox = new TextBox();
            addButton = new Button();
            contactosBox = new ListBox();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(84, 58);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(67, 20);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Nombre:";
            nameLabel.Click += label1_Click;
            // 
            // edadLabel
            // 
            edadLabel.AutoSize = true;
            edadLabel.Location = new Point(84, 123);
            edadLabel.Name = "edadLabel";
            edadLabel.Size = new Size(46, 20);
            edadLabel.TabIndex = 1;
            edadLabel.Text = "Edad:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(84, 193);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(147, 20);
            phoneLabel.TabIndex = 2;
            phoneLabel.Text = "Numero de telefono:";
            phoneLabel.Click += label1_Click_1;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(157, 58);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(125, 27);
            nameBox.TabIndex = 3;
            // 
            // phoneBox
            // 
            phoneBox.Location = new Point(237, 186);
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(125, 27);
            phoneBox.TabIndex = 4;
            // 
            // ageBox
            // 
            ageBox.Location = new Point(136, 120);
            ageBox.Name = "ageBox";
            ageBox.Size = new Size(125, 27);
            ageBox.TabIndex = 5;
            // 
            // addButton
            // 
            addButton.Location = new Point(148, 270);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 7;
            addButton.Text = "Añadir";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += button2_Click;
            // 
            // contactosBox
            // 
            contactosBox.FormattingEnabled = true;
            contactosBox.Location = new Point(407, 58);
            contactosBox.Name = "contactosBox";
            contactosBox.Size = new Size(342, 184);
            contactosBox.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(contactosBox);
            Controls.Add(addButton);
            Controls.Add(ageBox);
            Controls.Add(phoneBox);
            Controls.Add(nameBox);
            Controls.Add(phoneLabel);
            Controls.Add(edadLabel);
            Controls.Add(nameLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Label edadLabel;
        private Label phoneLabel;
        private TextBox nameBox;
        private TextBox phoneBox;
        private TextBox ageBox;
        private Button addButton;
        private ListBox contactosBox;
    }
}
