using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Practico4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtVacios(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt.Text == string.Empty)
            {
                // txt.Focus();
                errorP.SetError(txt, "Este campo no debe quedar vacio");
            }
            else
            {
                errorP.Clear();
            }
        }

        ErrorProvider errorP = new ErrorProvider();


        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDesde.Text) || string.IsNullOrEmpty(txtHasta.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int desde = Int32.Parse(txtDesde.Text);
            int hasta = Int32.Parse(txtHasta.Text);

            for (int i = desde; i <= hasta; i++)
            {
                listBox1.Items.Add(desde);
                desde += 1;
            }

            CreateChart(listBox1);
        }

        private void botonPares_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDesde.Text) || String.IsNullOrEmpty(txtHasta.Text))
            {
                MessageBox.Show("Debe completar los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listBox1.Items.Clear();
                var desde = Convert.ToInt32(txtDesde.Text);
                var hasta = Convert.ToInt32(txtHasta.Text);

                while (desde <= hasta)
                {
                    if (desde % 2 == 0)
                    {
                        listBox1.Items.Add(desde);

                    }
                    desde++;
                }

                CreateChart(listBox1);
            }

        }

        private void botonImpares_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDesde.Text) || String.IsNullOrEmpty(txtHasta.Text))
            {
                MessageBox.Show("Debe completar los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listBox1.Items.Clear();
                var desde = Convert.ToInt32(txtDesde.Text);
                var hasta = Convert.ToInt32(txtHasta.Text);

                while (desde <= hasta)
                {
                    if (desde % 2 != 0)
                    {
                        listBox1.Items.Add(desde);
                    }
                    desde++;
                }

                CreateChart(listBox1);
            }
        }

        private void botonPrimos_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDesde.Text) || String.IsNullOrEmpty(txtHasta.Text))
            {
                MessageBox.Show("Debe completar los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listBox1.Items.Clear();
                var desde = Convert.ToInt32(txtDesde.Text);
                var hasta = Convert.ToInt32(txtHasta.Text);
                //var contador = 0;
                for (int i = desde; i < hasta; i++)
                {
                    var contador = 0;
                    if (i > 1)
                    {
                        for (int j = 2; j < i; j++)
                        {
                            if (i % j == 0)
                            {
                                contador = 1;
                                break;
                            }
                        }
                        if (contador == 0)
                        {
                            listBox1.Items.Add(i);
                        }
                    }
                }


                CreateChart(listBox1);
            }
        }

        private void txtDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Validar.soloNumeros(e);
            if (!valida)
                errorP.SetError(txtDesde, "Solo ingresar numeros");
            else
                errorP.Clear();
        }

        private void txthasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Validar.soloNumeros(e);
            if (!valida)
                errorP.SetError(txtHasta, "Solo numeros");
            else
                errorP.Clear();
        }

        private void CreateChart(ListBox listBox)
        {
            // Limpiar cualquier dato previo en el Chart
            chart1.Series.Clear();

            Series serie = chart1.Series.Add("Datos del ListBox");

            foreach (var item in listBox.Items)
            {
                double valor = Convert.ToDouble(item);
                serie.Points.Add(valor);
            }

            // gráfico de barras
            serie.ChartType = SeriesChartType.Column;

            // Personalizar el gráfico si es necesario
            chart1.ChartAreas[0].AxisX.Title = "Categoría";
            chart1.ChartAreas[0].AxisY.Title = "Valor";
        }

    }
}
