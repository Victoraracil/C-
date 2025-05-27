using System;
using System.Windows.Forms;

namespace Academia._01view
{
    partial class FrmMatriculas
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

      
        private void InitializeComponent()
        {
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.dgvMatriculados = new System.Windows.Forms.DataGridView();
            this.btnVerTodoCurso = new System.Windows.Forms.Button();
            this.btnAlumnosCurso = new System.Windows.Forms.Button();
            this.btnVerTodoAlumno = new System.Windows.Forms.Button();
            this.btnVerCursos = new System.Windows.Forms.Button();
            this.btnDesmatricular = new System.Windows.Forms.Button();
            this.btnMostrarAlumno = new System.Windows.Forms.Button();
            this.txtCodigoMatricula = new System.Windows.Forms.TextBox();
            this.txtDniAlumno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriculados)).BeginInit();
            this.SuspendLayout();
           
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Location = new System.Drawing.Point(27, 70);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.Size = new System.Drawing.Size(444, 355);
            this.dgvCursos.TabIndex = 0;
            this.dgvCursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCursos_CellContentClick);
           
            this.dgvMatriculados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriculados.Location = new System.Drawing.Point(632, 70);
            this.dgvMatriculados.Name = "dgvMatriculados";
            this.dgvMatriculados.Size = new System.Drawing.Size(444, 355);
            this.dgvMatriculados.TabIndex = 1;
            this.dgvMatriculados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatriculados_CellContentClick);
            this.dgvMatriculados.Click += new System.EventHandler(this.btnViewCursosAlumno_Click);
             
            this.btnVerTodoCurso.Location = new System.Drawing.Point(27, 442);
            this.btnVerTodoCurso.Name = "btnVerTodoCurso";
            this.btnVerTodoCurso.Size = new System.Drawing.Size(156, 35);
            this.btnVerTodoCurso.TabIndex = 2;
            this.btnVerTodoCurso.Text = "Ver todos";
            this.btnVerTodoCurso.UseVisualStyleBackColor = true;
            this.btnVerTodoCurso.Click += new System.EventHandler(this.btnViewAllCourses_Click);
            
            this.btnAlumnosCurso.Location = new System.Drawing.Point(315, 442);
            this.btnAlumnosCurso.Name = "btnAlumnosCurso";
            this.btnAlumnosCurso.Size = new System.Drawing.Size(156, 35);
            this.btnAlumnosCurso.TabIndex = 3;
            this.btnAlumnosCurso.Text = "Ver alumnos del curso";
            this.btnAlumnosCurso.UseVisualStyleBackColor = true;
            this.btnAlumnosCurso.Click += new System.EventHandler(this.btnViewAlumnosCurso_Click);
            
            this.btnVerTodoAlumno.Location = new System.Drawing.Point(920, 442);
            this.btnVerTodoAlumno.Name = "btnVerTodoAlumno";
            this.btnVerTodoAlumno.Size = new System.Drawing.Size(156, 35);
            this.btnVerTodoAlumno.TabIndex = 5;
            this.btnVerTodoAlumno.Text = "Ver todos";
            this.btnVerTodoAlumno.UseVisualStyleBackColor = true;
            this.btnVerTodoAlumno.Click += new System.EventHandler(this.btnViewAll_Click);
            
            this.btnVerCursos.Location = new System.Drawing.Point(632, 442);
            this.btnVerCursos.Name = "btnVerCursos";
            this.btnVerCursos.Size = new System.Drawing.Size(156, 35);
            this.btnVerCursos.TabIndex = 4;
            this.btnVerCursos.Text = "Ver cursos del Alumno";
            this.btnVerCursos.UseVisualStyleBackColor = true;
            this.btnVerCursos.Click += new System.EventHandler(this.btnViewCursosAlumno_Click);
             
            this.btnDesmatricular.Location = new System.Drawing.Point(920, 29);
            this.btnDesmatricular.Name = "btnDesmatricular";
            this.btnDesmatricular.Size = new System.Drawing.Size(156, 35);
            this.btnDesmatricular.TabIndex = 7;
            this.btnDesmatricular.Text = "Desmatricular Alumno";
            this.btnDesmatricular.UseVisualStyleBackColor = true;
            this.btnDesmatricular.Click += new System.EventHandler(this.btnUneroll_Click);
            
            this.btnMostrarAlumno.Location = new System.Drawing.Point(758, 29);
            this.btnMostrarAlumno.Name = "btnMostrarAlumno";
            this.btnMostrarAlumno.Size = new System.Drawing.Size(156, 35);
            this.btnMostrarAlumno.TabIndex = 6;
            this.btnMostrarAlumno.Text = "Matricular Alumno";
            this.btnMostrarAlumno.UseVisualStyleBackColor = true;
            this.btnMostrarAlumno.Click += new System.EventHandler(this.btnInsert_Click);
             
            this.txtCodigoMatricula.Location = new System.Drawing.Point(371, 44);
            this.txtCodigoMatricula.Name = "txtCodigoMatricula";
            this.txtCodigoMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoMatricula.TabIndex = 8;
           
            this.txtDniAlumno.Location = new System.Drawing.Point(632, 44);
            this.txtDniAlumno.Name = "txtDniAlumno";
            this.txtDniAlumno.Size = new System.Drawing.Size(100, 20);
            this.txtDniAlumno.TabIndex = 9;
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 521);
            
            this.Controls.Add(this.txtDniAlumno);
            this.Controls.Add(this.txtCodigoMatricula);
            this.Controls.Add(this.btnDesmatricular);
            this.Controls.Add(this.btnMostrarAlumno);
            this.Controls.Add(this.btnVerTodoAlumno);
            this.Controls.Add(this.btnVerCursos);
            this.Controls.Add(this.btnAlumnosCurso);
            this.Controls.Add(this.btnVerTodoCurso);
            this.Controls.Add(this.dgvMatriculados);
            this.Controls.Add(this.dgvCursos);
            this.Name = "frmMatriculas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmMatriculas";
            this.Load += new System.EventHandler(this.frmMatriculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriculados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmMatriculas_Load(object sender, EventArgs e)
        {

        }


       

        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.DataGridView dgvMatriculados;
        private System.Windows.Forms.Button btnVerTodoCurso;
        private System.Windows.Forms.Button btnAlumnosCurso;
        private System.Windows.Forms.Button btnVerTodoAlumno;
        private System.Windows.Forms.Button btnVerCursos;
        private System.Windows.Forms.Button btnDesmatricular;
        private System.Windows.Forms.Button btnMostrarAlumno;
        private System.Windows.Forms.TextBox txtCodigoMatricula;
        private System.Windows.Forms.TextBox txtDniAlumno;
 
    }
}