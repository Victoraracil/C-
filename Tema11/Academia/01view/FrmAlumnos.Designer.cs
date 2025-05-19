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
            dgvALUMNOS = new DataGridView();
            lblDni = new Label();
            lblNombre = new Label();
            lblApellidos = new Label();
            lblTelefono = new Label();
            lblPoblacion = new Label();
            txtDni = new TextBox();
            txtNombre = new TextBox();
            txtApellidos = new TextBox();
            txtTelefono = new TextBox();
            txtPoblacion = new TextBox();
            btnClear = new Button();
            btnFind = new Button();
            btnRemove = new Button();
            btnEdit = new Button();
            btnEnd = new Button();
            btnRight = new Button();
            btnLeft = new Button();
            btnStart = new Button();
            btnInsert = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvALUMNOS).BeginInit();
            SuspendLayout();
            // 
            // dgvALUMNOS
            // 
            dgvALUMNOS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvALUMNOS.Location = new Point(288, 12);
            dgvALUMNOS.Name = "dgvALUMNOS";
            dgvALUMNOS.RowHeadersWidth = 51;
            dgvALUMNOS.Size = new Size(481, 312);
            dgvALUMNOS.TabIndex = 0;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(40, 46);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(38, 20);
            lblDni.TabIndex = 1;
            lblDni.Text = "DNI:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(40, 99);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(40, 163);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(75, 20);
            lblApellidos.TabIndex = 3;
            lblApellidos.Text = "Apellidos:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(40, 232);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "Telefono:";
            // 
            // lblPoblacion
            // 
            lblPoblacion.AutoSize = true;
            lblPoblacion.Location = new Point(40, 293);
            lblPoblacion.Name = "lblPoblacion";
            lblPoblacion.Size = new Size(77, 20);
            lblPoblacion.TabIndex = 5;
            lblPoblacion.Text = "Población:";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(122, 46);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(125, 27);
            txtDni.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(122, 99);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 7;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(122, 163);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(125, 27);
            txtApellidos.TabIndex = 8;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(122, 232);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 9;
            // 
            // txtPoblacion
            // 
            txtPoblacion.Location = new Point(122, 293);
            txtPoblacion.Name = "txtPoblacion";
            txtPoblacion.Size = new Size(125, 27);
            txtPoblacion.TabIndex = 10;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(681, 378);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(72, 31);
            btnClear.TabIndex = 56;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(602, 378);
            btnFind.Margin = new Padding(3, 4, 3, 4);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(72, 31);
            btnFind.TabIndex = 55;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(523, 378);
            btnRemove.Margin = new Padding(3, 4, 3, 4);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(72, 31);
            btnRemove.TabIndex = 54;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(367, 378);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(72, 31);
            btnEdit.TabIndex = 53;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnEnd
            // 
            btnEnd.Location = new Point(288, 378);
            btnEnd.Margin = new Padding(3, 4, 3, 4);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(72, 31);
            btnEnd.TabIndex = 52;
            btnEnd.Text = ">>";
            btnEnd.UseVisualStyleBackColor = true;
            btnEnd.Click += btnEnd_Click;
            // 
            // btnRight
            // 
            btnRight.Location = new Point(210, 378);
            btnRight.Margin = new Padding(3, 4, 3, 4);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(72, 31);
            btnRight.TabIndex = 51;
            btnRight.Text = ">";
            btnRight.UseVisualStyleBackColor = true;
            btnRight.Click += btnRight_Click;
            // 
            // btnLeft
            // 
            btnLeft.Location = new Point(131, 378);
            btnLeft.Margin = new Padding(3, 4, 3, 4);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(72, 31);
            btnLeft.TabIndex = 50;
            btnLeft.Text = "<";
            btnLeft.UseVisualStyleBackColor = true;
            btnLeft.Click += btnLeft_Click;
            // 
            // btnStart
            // 
            btnStart.AutoSize = true;
            btnStart.Location = new Point(52, 378);
            btnStart.Margin = new Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(72, 33);
            btnStart.TabIndex = 49;
            btnStart.Text = "<<";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(445, 378);
            btnInsert.Margin = new Padding(3, 4, 3, 4);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(72, 31);
            btnInsert.TabIndex = 57;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // FrmAlumnos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInsert);
            Controls.Add(btnClear);
            Controls.Add(btnFind);
            Controls.Add(btnRemove);
            Controls.Add(btnEdit);
            Controls.Add(btnEnd);
            Controls.Add(btnRight);
            Controls.Add(btnLeft);
            Controls.Add(btnStart);
            Controls.Add(txtPoblacion);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombre);
            Controls.Add(txtDni);
            Controls.Add(lblPoblacion);
            Controls.Add(lblTelefono);
            Controls.Add(lblApellidos);
            Controls.Add(lblNombre);
            Controls.Add(lblDni);
            Controls.Add(dgvALUMNOS);
            Name = "FrmAlumnos";
            Text = "FrmAlumnos";
            Load += FrmAlumnos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvALUMNOS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvALUMNOS;
        private Label lblDni;
        private Label lblNombre;
        private Label lblApellidos;
        private Label lblTelefono;
        private Label lblPoblacion;
        private TextBox txtDni;
        private TextBox txtNombre;
        private TextBox txtApellidos;
        private TextBox txtTelefono;
        private TextBox txtPoblacion;
        private Button btnClear;
        private Button btnFind;
        private Button btnRemove;
        private Button btnEdit;
        private Button btnEnd;
        private Button btnRight;
        private Button btnLeft;
        private Button btnStart;
        private Button btnInsert;

    }
    
}