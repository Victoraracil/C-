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
        public FrmAlumnos()
        {
            InitializeComponent();
        }

        private void FrmAlumnos_Load(object sender, EventArgs e)
        {

        }
        private void MapearNegocioPresentacion()
        {
            //Carga las propiedades de un objeto Alumno a los cuadros de texto del formulario, por ejemplo:
            this.txtDni.Text = this.gestionAlumnos.Alumno.Dni;
        }

        public void MaperarPresentacionNegocio()
        {
            //Carga las propiedades de los textbox del fornulario a las propiedades del objeto Alumno, por ejemplo:
            this.gestionAlumnos.Alumno.Dni = this.txtDni.Text;
        }

    }
}
