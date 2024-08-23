using Microsoft.VisualBasic;
using Practico2.Properties;

namespace Practico2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo numero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String modificado = txtNombre.Text + " " + txtApellido.Text;

            LModificar.Text = modificado;

            if (string.IsNullOrEmpty(txtDNI.Text) || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty((string)txtNombre.Text)
                    || string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult ask;

            ask = MessageBox.Show("Seguro que desea insertar un nuevo Cliente?", "Confirmar Insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ask == DialogResult.Yes)
            {
                MessageBox.Show("El cliente " + LModificar.Text + " se insertó correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String modificado = txtNombre.Text + " " + txtApellido.Text;
            LModificar.Text = modificado;

            if (string.IsNullOrEmpty(txtDNI.Text) || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty((string)txtNombre.Text)
                    || string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult ask;
            ask = MessageBox.Show("Esta a punto de eliminar al Cliente: " + LModificar.Text, "Confirmar Eliminacion", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Exclamation);

            if (ask == DialogResult.Yes)
            {
                txtApellido.Clear();
                txtDNI.Clear();
                txtNombre.Clear();
                txtTelefono.Clear();
                MessageBox.Show("El Cliente: " + LModificar.Text + " se elimino correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LModificar.Text = null;
                RBHombre.Checked = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void RBHombre_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = null;
            pictureBox1.BackgroundImage = Image.FromFile("C:\\Users\\Usuario\\Desktop\\Proyectos taller 2\\Practico2\\Practico2\\Resources\\varon.png");
        }

        private void RBMujer_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = null;
            pictureBox1.BackgroundImage = Image.FromFile("C:\\Users\\Usuario\\Desktop\\Proyectos taller 2\\Practico2\\Practico2\\Resources\\mujer.png");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}