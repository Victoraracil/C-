using Academia._02aplication;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Academia._01view
{
    public partial class FrmCursos: Form
    {
        private GestionCursos gestionCursos;

        public FrmCursos()
        {
            InitializeComponent();
            gestionCursos = new GestionCursos();
            CargarDatosEnGrid();
        }

       
        private void MapearNegocioPresentacion()
        {
            if (gestionCursos.Curso == null)
                return;

            txtCodigo.Text = gestionCursos.Curso.Codigo ?? string.Empty;
            txtTitulo.Text = gestionCursos.Curso.Titulo ?? string.Empty;
            txtLugar.Text = gestionCursos.Curso.Lugar ?? string.Empty;
            txtNumeroPlazas.Text = gestionCursos.Curso.NumPlaza?.ToString() ?? "0";
            txtPrecio.Text = gestionCursos.Curso.Precio?.ToString() ?? "0.00";
        }

      
        private void MapearPresentacionNegocio()
        {
            if (gestionCursos.Curso == null)
                gestionCursos.Curso = new Curso();

            gestionCursos.Curso.Codigo = txtCodigo.Text.Trim();
            gestionCursos.Curso.Titulo = txtTitulo.Text.Trim();
            gestionCursos.Curso.Lugar = txtLugar.Text.Trim();
            gestionCursos.Curso.NumPlaza = txtNumeroPlazas.Text.Trim();
            gestionCursos.Curso.Precio = txtPrecio.Text.Trim();
        }

        private void CargarDatosEnGrid()
        {
            var cursos = gestionCursos.GetAll();
            if (cursos != null && cursos.Count > 0)
            {
                dgvCursos.DataSource = null;
                dgvCursos.DataSource = cursos;
            }
            else
            {
                dgvCursos.DataSource = null;
                MessageBox.Show("No se encontraron cursos en la base de datos o la base de datos no esta conectada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            var primerCurso = gestionCursos.Primero();
            if (primerCurso != null)
            {
                gestionCursos.Curso = primerCurso;
                MapearNegocioPresentacion();
            }
            else
            {
                MessageBox.Show("No se encontró ningún curso.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            var cursoAnterior = gestionCursos.Anterior();
            if (cursoAnterior != null)
            {
                gestionCursos.Curso = cursoAnterior;
                MapearNegocioPresentacion();
            }
            else
            {
                MessageBox.Show("No hay un curso anterior.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            var cursoSiguiente = gestionCursos.Siguiente();
            if (cursoSiguiente != null)
            {
                gestionCursos.Curso = cursoSiguiente;
                MapearNegocioPresentacion();
            }
            else
            {
                MessageBox.Show("No hay un curso siguiente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnUltimo_Click(object sender, EventArgs e)
        {
            var ultimoCurso = gestionCursos.Ultimo();
            if (ultimoCurso != null)
            {
                gestionCursos.Curso = ultimoCurso;
                MapearNegocioPresentacion();
            }
            else
            {
                MessageBox.Show("No se encontró ningún curso.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                MessageBox.Show("Completa todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MapearPresentacionNegocio();
            var resultado = gestionCursos.Insert();
            if (resultado > 0)
            {
                MessageBox.Show("Curso insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatosEnGrid();
            }
            else if (resultado == -1)
                MessageBox.Show("El curso ya existe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Error al insertar el curso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                MessageBox.Show("Completa todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MapearPresentacionNegocio();
            var result = gestionCursos.Edit();
            if (result > 0)
            {
                MessageBox.Show("Curso actualizado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatosEnGrid();
            }
            else
                MessageBox.Show("No se pudo actualizar. ¿Código existente?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (gestionCursos.Curso == null || string.IsNullOrEmpty(gestionCursos.Curso.Codigo))
            {
                MessageBox.Show("Selecciona un curso para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show("¿Estás seguro de que deseas eliminar este curso?", "Confirmar eliminación", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                var result = gestionCursos.Remove();
                if (result > 0)
                {
                    MessageBox.Show("Curso eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatosEnGrid();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el curso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Eliminación cancelada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            var codigo = txtCodigo.Text.Trim();
            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Ingresa un código para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var curso = gestionCursos.GetById(codigo);
            if (curso != null)
            {
                gestionCursos.Curso = curso;
                MapearNegocioPresentacion();
            }
            else
                MessageBox.Show("Curso no encontrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            gestionCursos = new GestionCursos();
            LimpiarCampos();
            CargarDatosEnGrid();
        }

        private void dgvCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = dgvCursos.Rows[e.RowIndex];
            gestionCursos.Curso = new Curso
            {
                Codigo = fila.Cells["Codigo"].Value?.ToString() ?? "",
                Titulo = fila.Cells["Titulo"].Value?.ToString() ?? "",
                Lugar = fila.Cells["Lugar"].Value?.ToString() ?? "",
                NumPlaza = fila.Cells["NumPlaza"].Value?.ToString() ?? "",
                Precio = fila.Cells["Precio"].Value?.ToString() ?? ""
            };
            MapearNegocioPresentacion();
        }

        private bool ValidarCampos()
        {
            bool ok = true;
            foreach (var t in new[] { txtCodigo, txtTitulo, txtLugar, txtNumeroPlazas, txtPrecio })
            {
                if (string.IsNullOrWhiteSpace(t.Text))
                {
                    t.BackColor = Color.LightCoral;
                    ok = false;
                }
                else
                {
                    t.BackColor = Color.White;
                }
            }
            return ok;
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtTitulo.Clear();
            txtLugar.Clear();
            txtNumeroPlazas.Clear();
            txtPrecio.Clear();
        }

        private void frmCursos_Load(object sender, EventArgs e)
        {

        }
    }
}
