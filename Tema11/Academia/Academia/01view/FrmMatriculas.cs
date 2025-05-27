
using System;
using System.Windows.Forms;
using Academia._02aplication;
using Academia._03data;


namespace Academia._01view
{
    public partial class FrmMatriculas : Form
    {
        private GestionMatriculas gestionMatri;
        private GestionCursos gestionCursos;

        public FrmMatriculas()
        {
            InitializeComponent();
            gestionMatri = new GestionMatriculas();
            gestionCursos = new GestionCursos();
            CargarDatos();

        }

        private void CargarDatos()
        {
            dgvCursos.DataSource = null;
           
            dgvCursos.DataSource = gestionCursos.GetAll();
        }

        private void MapearNegocioPresentacion()
        {
            txtCodigoMatricula.Text = gestionMatri.Matricula.CodigoCurso;
            txtDniAlumno.Text = gestionMatri.Matricula.Dni;
            MessageBox.Show(gestionMatri.Error(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void MapearPresentacionNegocio()
        {
            if (gestionMatri.Matricula == null) gestionMatri.Matricula = new Matricula();
            gestionMatri.Matricula.Dni = txtDniAlumno.Text.Trim();
            gestionMatri.Matricula.CodigoCurso = txtCodigoMatricula.Text.Trim();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            dgvMatriculados.DataSource = gestionMatri.GetAllNames();
        }

        private void btnViewAllCourses_Click(object sender, EventArgs e)
        {
            dgvCursos.DataSource = gestionCursos.GetAll();
        }

        private void btnViewAlumnosCurso_Click(object sender, EventArgs e)
        {
            var codigo = txtCodigoMatricula.Text.Trim();
            dgvMatriculados.DataSource = gestionMatri.GetAlumnosPorCurso(codigo);

        }

        private void btnViewCursosAlumno_Click(object sender, EventArgs e)
        {
            var dni = txtDniAlumno.Text.Trim();
            dgvCursos.DataSource = gestionMatri.GetCursosPorAlumno(dni);

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            MapearPresentacionNegocio();
            var resultado = gestionMatri.Insert();

            if (resultado > 0)
            {
                
                dgvMatriculados.DataSource = gestionMatri.GetAlumnosPorCurso(txtCodigoMatricula.Text.Trim());
                MessageBox.Show("Alumno matriculado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo matricular (puede que ya esté matriculado)", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            MessageBox.Show(gestionMatri.Error(), "Detalle del error", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void btnUneroll_Click(object sender, EventArgs e)
        {
            MapearPresentacionNegocio();
            var resultado = gestionMatri.Remove();
            if (resultado > 0)
                CargarDatos();
            else
                MessageBox.Show("Error al desmatricular", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show(gestionMatri.Error(), "Detalle del error", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dgvCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvCursos.Rows.Count) return;
            var cursoSeleccionado = dgvCursos.Rows[e.RowIndex].DataBoundItem as Curso;
            if (cursoSeleccionado == null) return;
            var alumnos = gestionMatri.GetAlumnosPorCurso(cursoSeleccionado.Codigo);
            dgvMatriculados.DataSource = alumnos;
        }


        private void dgvMatriculados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvMatriculados.Rows.Count) return;
            var item = dgvMatriculados.Rows[e.RowIndex].DataBoundItem;
            if (item == null) return;

            Console.WriteLine($"Tipo de elemento seleccionado: {item.GetType().Name}");

            switch (item)
            {
                case Matricula m:
                    txtDniAlumno.Text = m.Dni;
                    txtCodigoMatricula.Text = m.CodigoCurso;
                    break;
                case Alumno a:
                    txtDniAlumno.Text = a.Dni;
                    break;
                case Curso c:
                    txtCodigoMatricula.Text = c.Codigo;
                    break;
                default:
                    MessageBox.Show($"Tipo inesperado: {item.GetType().Name}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }


    }
}
