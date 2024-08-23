using System.Net.Sockets;

namespace Practico1
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

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            String mensaje = txtBoxApellido.Text + " " + txtBoxNombre.Text;

            txtBox3.Text = mensaje;
        }

        private void txtBoxApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            txtBox3.Clear();
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}