using Academia._02aplication;

using System;

using System.Windows.Forms;

namespace Academia._01view
{
    public partial class FrmAlumnos : Form
    {
        private GestionAlumnos gestionAlumnos;
        public FrmAlumnos()
        {
            InitializeComponent();
            gestionAlumnos = new GestionAlumnos();
            CargarListaAlumnos();
            dgvAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlumnos.CellClick += dgvAlumnos_CellContentClick;

        }

        
        private void MapearNegocioPresentacion()
        {
            if (gestionAlumnos.Alumno != null)
            {
                txtDni.Text = gestionAlumnos.Alumno.Dni;
                txtNombre.Text = gestionAlumnos.Alumno.Nombre;
                txtApellidos.Text = gestionAlumnos.Alumno.Apellidos;
                txtTelefono.Text = gestionAlumnos.Alumno.Telefono;
                txtPoblacion.Text = gestionAlumnos.Alumno.Poblacion;
            }
        }

        
        private void MapearPresentacionNegocio()
        {
            if (gestionAlumnos.Alumno == null)
            {
                gestionAlumnos.Alumno = new Alumno();
            }

            gestionAlumnos.Alumno.Dni = txtDni.Text.Trim();
            gestionAlumnos.Alumno.Nombre = txtNombre.Text.Trim();
            gestionAlumnos.Alumno.Apellidos = txtApellidos.Text.Trim();
            gestionAlumnos.Alumno.Poblacion = txtPoblacion.Text.Trim();
            gestionAlumnos.Alumno.Telefono = txtTelefono.Text.Trim();

        }
        private void CargarDatosEnGrid()
        {
            var alumnos = gestionAlumnos.GetAll();
            if (alumnos != null && alumnos.Count > 0)
            {
                dgvAlumnos.DataSource = null;
                dgvAlumnos.DataSource = alumnos;
            }
            else
            {
                dgvAlumnos.DataSource = null;
                MessageBox.Show("No se encontraron alumnos en la base de datos o la base de datos no esta conectada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void CargarListaAlumnos()
        {
            dgvAlumnos.DataSource = gestionAlumnos.GetAll();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTelefono.Text) && !long.TryParse(txtTelefono.Text.Trim(), out _))
            {
                MessageBox.Show("El campo Teléfono solo puede contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefono.Focus();
                return;
            }

            MapearPresentacionNegocio();

            int result = gestionAlumnos.Edit();

            if (result > 0)
            {
                MessageBox.Show("Alumno actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvAlumnos.DataSource = gestionAlumnos.GetAll(); 
            }
            else
            {
                MessageBox.Show(" No se puede cambiar el DNI una vez registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dgvAlumnos.Rows[e.RowIndex];

                gestionAlumnos.Alumno = new Alumno
                {
                    Dni = filaSeleccionada.Cells["Dni"].Value?.ToString() ?? "",
                    Nombre = filaSeleccionada.Cells["Nombre"].Value?.ToString() ?? "",
                    Apellidos = filaSeleccionada.Cells["Apellidos"].Value?.ToString() ?? "",
                    Poblacion = filaSeleccionada.Cells["Poblacion"].Value?.ToString() ?? "",
                    Telefono = filaSeleccionada.Cells["Telefono"].Value?.ToString() ?? ""

                };
                MapearNegocioPresentacion();
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            var primerCurso = gestionAlumnos.Primero();
            if (primerCurso != null)
            {
                gestionAlumnos.Alumno = primerCurso;
                MapearNegocioPresentacion();
            }
            else
            {
                MessageBox.Show("No se encontró ningún alumno.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            var alumnoAnterior = gestionAlumnos.Anterior();

            if (alumnoAnterior != null)
            {
                MapearNegocioPresentacion();
            }
            else
            {
                MessageBox.Show("No hay un alumno anterior.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            var alumnoSiguiente = gestionAlumnos.Siguiente();

            if (alumnoSiguiente != null)
            {
                MapearNegocioPresentacion();
            }
            else
            {
                MessageBox.Show("No hay un alumno siguiente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            var ultimoAlumno = gestionAlumnos.Ultimo();

            if (ultimoAlumno != null)
            {
                gestionAlumnos.Alumno = ultimoAlumno;

                MapearNegocioPresentacion();
            }
            else
            {
                MessageBox.Show("No se encontró ningún alumno.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
      

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTelefono.Text) && !int.TryParse(txtTelefono.Text.Trim(), out _))
            {
                MessageBox.Show("El campo Teléfono solo puede contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefono.Focus();
                return;
            }

            MapearPresentacionNegocio();

            int resultado = gestionAlumnos.Insert();

            if (resultado > 0)
            {
                MessageBox.Show("Alumno insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarListaAlumnos();
            }
            else if (resultado == -1)
            {
                MessageBox.Show("El alumno ya existe en la base de datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Ocurrió un error al insertar el alumno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrWhiteSpace(txtDni.Text))
            {
                MessageBox.Show("El campo DNI no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDni.Focus();
                return;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (gestionAlumnos.Alumno == null || string.IsNullOrEmpty(gestionAlumnos.Alumno.Dni))
            {
                MessageBox.Show("Por favor, selecciona un alumno para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show( "¿Estás seguro de que deseas eliminar este alumno?","Confirmar eliminación",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                int resultado = gestionAlumnos.Remove();

                if (resultado > 0)
                {
                    MessageBox.Show("Alumno eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarListaAlumnos();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el alumno. ¿Está seleccionado correctamente?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Eliminación cancelada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string poblacion = txtPoblacion.Text.Trim();

            if (!string.IsNullOrWhiteSpace(txtTelefono.Text) && !int.TryParse(txtTelefono.Text.Trim(), out _))
            {
                MessageBox.Show("El campo Teléfono solo puede contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefono.Focus();
                return;
            }

            var resultados = gestionAlumnos.Buscar(dni, nombre, apellidos, telefono, poblacion);

            if (resultados.Any())
            {
                dgvAlumnos.DataSource = resultados;
            }
            else
            {
                MessageBox.Show("No se encontró ningún alumno con los datos ingresados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            gestionAlumnos = new GestionAlumnos();
            dgvAlumnos.DataSource = gestionAlumnos.GetAll();
            MapearNegocioPresentacion();
        }
                             
        private void frmAlumnos_Load(object sender, EventArgs e)
        {

        }
    }
}