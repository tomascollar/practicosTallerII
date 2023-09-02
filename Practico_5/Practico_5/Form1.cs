using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practico_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblSaldo_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Evitar que se ingrese el carácter en el TextBox
            }
        }

        private void DataGrid_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // Cambiar el color de fondo de la fila en función de alguna condición
            if (e.RowIndex >= 0)
            {
                int valor = Convert.ToInt32(DataGrid.Rows[e.RowIndex].Cells["Saldo"].Value);
                DataGrid.DefaultCellStyle.BackColor = Color.White;
                if (valor < 50)
                {
                    // Cambiar el color de fondo de la fila
                    DataGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    // Restaurar el color de fondo predeterminado
                    DataGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "C";
            ofd.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|Png (*.png)|+.png";
            //ofd.ShowDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbFoto.ImageLocation = ofd.FileName;
                txtRuta.Text = ofd.FileName;

                //copiar la foto seleccionada en la carpeta foto del proyecto
                string nombreArchivo = Path.GetFileName(txtRuta.Text);
                string destino = Path.Combine(Application.StartupPath, "Fotos", nombreArchivo);
                try
                {
                    // Copiar el archivo seleccionado a la carpeta destino dentro del proyecto
                    File.Copy(txtRuta.Text, destino, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al copiar la imagen: " + ex.Message);
                }

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtSaldo.Text) || string.IsNullOrEmpty(txtNombre.Text) || (RBhom.Checked == false && RBmuj.Checked == false))
            {
                MessageBox.Show("Debe completar los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var msg = MessageBox.Show("Desea guardar un nuevo cliente?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == System.Windows.Forms.DialogResult.Yes)
                {
                    var Nombre = txtNombre.Text;
                    var Apellido = txtApellido.Text;
                    var FechaNac = dtFecha.Text;

                    var Saldo = Convert.ToInt32(txtSaldo.Text);

                    var Sexo = RBhom.Checked ? RBhom.Text : RBmuj.Text;

                    
                    DataGrid.Rows.Add(Apellido, Nombre, FechaNac, Sexo, "Eliminar", Saldo, pbFoto.Image, txtRuta.Text);
                    DataGrid.RowPrePaint += DataGrid_RowPrePaint;
                    MessageBox.Show("Datos guardados con éxito", "Guardar", MessageBoxButtons.OK);

                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtRuta.Clear();
                    txtSaldo.Clear();
                    pbFoto.Image = null;
                    RBmuj.Checked = false;
                    RBhom.Checked = false;
                }
                else
                {
                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtRuta.Clear();
                    txtSaldo.Clear();
                    RBmuj.Checked = false;
                    RBhom.Checked = false;

                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DataGrid.Rows[e.RowIndex];
            DataGridViewCell nombreCell = row.Cells["Nombre"];
            DataGridViewCell eliminarCell = row.Cells["Eliminar"];

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewColumn columna = DataGrid.Columns[e.ColumnIndex];
                if (columna.Name != "Eliminar")
                {
                    // Desactivar el evento Click en celdas que no sean del tipo botón
                    DataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;

                }
                else
                {

                    if (string.IsNullOrWhiteSpace(Convert.ToString(nombreCell.Value)))
                    {
                        // Desactivar el botón de eliminar si la fila está vacía
                        eliminarCell.ReadOnly = true;
                    }
                    else
                    {
                        eliminarCell.ReadOnly = false;
                        var msg = MessageBox.Show("Desea eliminar el cliente?", "Confirmar Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (msg == DialogResult.Yes)
                        {
                            if (e.RowIndex >= 0 && e.ColumnIndex == DataGrid.Columns["Eliminar"].Index)
                            {
                                // Eliminar la fila correspondiente
                                DataGrid.Rows.RemoveAt(e.RowIndex);
                            }
                            MessageBox.Show("Cliente eliminado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void pbFoto_Click(object sender, EventArgs e)
        {
        
        }
    }
}
