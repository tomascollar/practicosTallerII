namespace Practico4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.botonPares = new System.Windows.Forms.Button();
            this.botonImpares = new System.Windows.Forms.Button();
            this.botonPrimos = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.LDesde = new System.Windows.Forms.Label();
            this.LHasta = new System.Windows.Forms.Label();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(67, 162);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(100, 23);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar Funcion";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // botonPares
            // 
            this.botonPares.Location = new System.Drawing.Point(67, 191);
            this.botonPares.Name = "botonPares";
            this.botonPares.Size = new System.Drawing.Size(100, 23);
            this.botonPares.TabIndex = 1;
            this.botonPares.Text = "Numeros Pares";
            this.botonPares.UseVisualStyleBackColor = true;
            this.botonPares.Click += new System.EventHandler(this.botonPares_Click);
            // 
            // botonImpares
            // 
            this.botonImpares.Location = new System.Drawing.Point(67, 220);
            this.botonImpares.Name = "botonImpares";
            this.botonImpares.Size = new System.Drawing.Size(100, 23);
            this.botonImpares.TabIndex = 2;
            this.botonImpares.Text = "Numeros Impares";
            this.botonImpares.UseVisualStyleBackColor = true;
            this.botonImpares.Click += new System.EventHandler(this.botonImpares_Click);
            // 
            // botonPrimos
            // 
            this.botonPrimos.Location = new System.Drawing.Point(67, 249);
            this.botonPrimos.Name = "botonPrimos";
            this.botonPrimos.Size = new System.Drawing.Size(100, 23);
            this.botonPrimos.TabIndex = 3;
            this.botonPrimos.Text = "Numeros Primos";
            this.botonPrimos.UseVisualStyleBackColor = true;
            this.botonPrimos.Click += new System.EventHandler(this.botonPrimos_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(199, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(320, 251);
            this.listBox1.TabIndex = 4;
            // 
            // LDesde
            // 
            this.LDesde.AutoSize = true;
            this.LDesde.Location = new System.Drawing.Point(18, 54);
            this.LDesde.Name = "LDesde";
            this.LDesde.Size = new System.Drawing.Size(38, 13);
            this.LDesde.TabIndex = 5;
            this.LDesde.Text = "Desde";
            // 
            // LHasta
            // 
            this.LHasta.AutoSize = true;
            this.LHasta.Location = new System.Drawing.Point(18, 100);
            this.LHasta.Name = "LHasta";
            this.LHasta.Size = new System.Drawing.Size(35, 13);
            this.LHasta.TabIndex = 6;
            this.LHasta.Text = "Hasta";
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(67, 51);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(100, 20);
            this.txtDesde.TabIndex = 7;
            this.txtDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesde_KeyPress);
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(67, 97);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(100, 20);
            this.txtHasta.TabIndex = 8;
            this.txtHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txthasta_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lista de Números";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.txtHasta);
            this.panel1.Controls.Add(this.txtDesde);
            this.panel1.Controls.Add(this.LHasta);
            this.panel1.Controls.Add(this.LDesde);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.botonPrimos);
            this.panel1.Controls.Add(this.botonImpares);
            this.panel1.Controls.Add(this.botonPares);
            this.panel1.Controls.Add(this.btnGenerar);
            this.panel1.Location = new System.Drawing.Point(30, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 451);
            this.panel1.TabIndex = 10;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(42, 304);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(510, 130);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 526);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button botonPares;
        private System.Windows.Forms.Button botonImpares;
        private System.Windows.Forms.Button botonPrimos;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label LDesde;
        private System.Windows.Forms.Label LHasta;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

