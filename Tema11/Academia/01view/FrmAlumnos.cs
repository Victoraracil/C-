using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Academia._01view
{
    public partial class FrmAlumnos : Form
    {
        // Adding the missing fields to resolve the errors
        private GestionAlumnos gestionAlumnos; // Assuming GestionAlumnos is a class in your application
        private TextBox txtDni; // Adding the missing TextBox field

        public FrmAlumnos()
        {
            InitializeComponent();

            // Initialize the missing fields
            this.gestionAlumnos = new GestionAlumnos();
            this.txtDni = new TextBox();
        }

        private void FrmAlumnos_Load(object sender, EventArgs e)
        {

        }

        private void MapearNegocioPresentacion()
        {
            // Carga las propiedades de un objeto Alumno a los cuadros de texto del formulario
            this.txtDni.Text = this.gestionAlumnos.Alumno.Dni;
        }

        public void MaperarPresentacionNegocio()
        {
            // Carga las propiedades de los textbox del formulario a las propiedades del objeto Alumno
            this.gestionAlumnos.Alumno.Dni = this.txtDni.Text;
        }

        // Métodos para contestar a los eventos del ratón al hacer click sobre los botones
        public void btnPrimero_Click()
        {

        }
        public void btnUltimo_Click()
        {

        }
        public void btnAnterior_Click()
        {

        }
        public void btnSiguiente_Click() { }
        public void btnEdit_Click() { }
        public void btnInsert_Click() { }
        public void btnRemove_Click() { }
        public void btnFind_Click() { }
        public void btnClear_Click() { }

        // Eventos al cargar la pantalla y al hacer clic en el DataGridView
        public void FrmAlumnos_Load() { }
        public void dgvListaAlumnos_CellContentClick() { }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }

    // Assuming GestionAlumnos and Alumno classes exist in your application
    public class GestionAlumnos
    {
        public Alumno Alumno { get; set; }

        public GestionAlumnos()
        {
            this.Alumno = new Alumno();
        }
    }

    public class Alumno
    {
        public string Dni { get; set; }
    }
}