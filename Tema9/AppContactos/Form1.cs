namespace AppContactos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = (nameLabel.Text);
            int edad = Convert.ToInt32(edadLabel.Text);
            long telefono = Convert.ToInt64(phoneLabel.Text);
            contactosBox.Text = "" + (nombre + edad + telefono);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
