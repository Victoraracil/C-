using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia._01view
{
    public partial class FrmAlumnos : Form
    {
        GestionAlumnos gestionAlumnos = new GestionAlumnos();
        public FrmAlumnos()
        {
            InitializeComponent();
            MaperarNegocioPresentacion();
            MapearPresentacionNegocio();
            this.dgvALUMNOS.DataSource = gestionAlumnos.GetAll();
        }
        private void MaperarNegocioPresentacion()
        {
            txtDni.Text = this.gestionAlumnos.Alumno.Dni;
            txtNombre.Text = this.gestionAlumnos.Alumno.Nombre;
            txtApellidos.Text = this.gestionAlumnos.Alumno.Apellidos;
            txtTelefono.Text = this.gestionAlumnos.Alumno.Telefono;
            txtPoblacion.Text = this.gestionAlumnos.Alumno.Poblacion;
        }
        private void MapearPresentacionNegocio()
        {
            this.gestionAlumnos.Alumno.Dni = txtDni.Text;
            this.gestionAlumnos.Alumno.Nombre = txtNombre.Text;
            this.gestionAlumnos.Alumno.Apellidos = txtApellidos.Text;
            this.gestionAlumnos.Alumno.Telefono = txtTelefono.Text;
            this.gestionAlumnos.Alumno.Poblacion = txtPoblacion.Text;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            gestionAlumnos.Primero();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            gestionAlumnos.Anterior();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            gestionAlumnos.Siguiente();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            gestionAlumnos.Ultimo();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            gestionAlumnos.Editar();
            this.dgvALUMNOS.DataSource = gestionAlumnos.GetAll();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (gestionAlumnos.Insertar() > 0)
            {
                MessageBox.Show("Alumno insertado correctamente");
                this.dgvALUMNOS.DataSource = gestionAlumnos.GetAll();
            }
            else
            {
                MessageBox.Show("Error al insertar el alumno");
            }
            MaperarNegocioPresentacion();
            MapearPresentacionNegocio();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            gestionAlumnos.Eliminar();
            this.dgvALUMNOS.DataSource = gestionAlumnos.GetAll();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            gestionAlumnos.Buscar();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            gestionAlumnos.Limpiar();
        }

        private void FrmAlumnos_Load(object sender, EventArgs e)
        {

        }
        
    }
}
