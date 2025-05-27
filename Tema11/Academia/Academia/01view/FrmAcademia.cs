using System;
using System.Windows.Forms;
using Academia._01view;

namespace Academia._01view
{
    public partial class FrmAcademia : Form
    {
        public FrmAcademia()
        {
            InitializeComponent();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            using (var f = new FrmAlumnos())
                f.ShowDialog();
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            using (var f = new FrmCursos())
                f.ShowDialog();
        }

        private void btnMatriculas_Click(object sender, EventArgs e)
        {
            using (var f = new FrmMatriculas())
                f.ShowDialog();
        }
        private void FrmAcademia_Load(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelnombre_Click(object sender, EventArgs e)
        {

        }
    }
}
