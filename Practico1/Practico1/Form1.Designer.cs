namespace Practico1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bGuardar = new Button();
            bEliminar = new Button();
            labelApellido = new Label();
            labelNombre = new Label();
            txtBoxApellido = new TextBox();
            txtBoxNombre = new TextBox();
            txtBox3 = new TextBox();
            bSalir = new Button();
            SuspendLayout();
            // 
            // bGuardar
            // 
            bGuardar.Location = new Point(39, 183);
            bGuardar.Name = "bGuardar";
            bGuardar.Size = new Size(92, 23);
            bGuardar.TabIndex = 0;
            bGuardar.Text = "Guardar";
            bGuardar.UseVisualStyleBackColor = true;
            bGuardar.Click += bGuardar_Click;
            // 
            // bEliminar
            // 
            bEliminar.Location = new Point(160, 183);
            bEliminar.Name = "bEliminar";
            bEliminar.Size = new Size(87, 23);
            bEliminar.TabIndex = 1;
            bEliminar.Text = "Eliminar";
            bEliminar.UseVisualStyleBackColor = true;
            bEliminar.Click += bEliminar_Click;
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Location = new Point(39, 97);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(51, 15);
            labelApellido.TabIndex = 2;
            labelApellido.Tag = "";
            labelApellido.Text = "Apellido";
            labelApellido.Click += label1_Click;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(39, 137);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(51, 15);
            labelNombre.TabIndex = 3;
            labelNombre.Text = "Nombre";
            labelNombre.Click += labelNombre_Click;
            // 
            // txtBoxApellido
            // 
            txtBoxApellido.Location = new Point(105, 94);
            txtBoxApellido.Name = "txtBoxApellido";
            txtBoxApellido.Size = new Size(133, 23);
            txtBoxApellido.TabIndex = 4;
            txtBoxApellido.TextChanged += txtBoxApellido_TextChanged;
            // 
            // txtBoxNombre
            // 
            txtBoxNombre.Location = new Point(105, 134);
            txtBoxNombre.Name = "txtBoxNombre";
            txtBoxNombre.Size = new Size(133, 23);
            txtBoxNombre.TabIndex = 5;
            // 
            // txtBox3
            // 
            txtBox3.Location = new Point(311, 68);
            txtBox3.Multiline = true;
            txtBox3.Name = "txtBox3";
            txtBox3.Size = new Size(152, 136);
            txtBox3.TabIndex = 6;
            // 
            // bSalir
            // 
            bSalir.Location = new Point(344, 226);
            bSalir.Name = "bSalir";
            bSalir.Size = new Size(75, 23);
            bSalir.TabIndex = 7;
            bSalir.Text = "Salir";
            bSalir.UseVisualStyleBackColor = true;
            bSalir.Click += bSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
            Controls.Add(bSalir);
            Controls.Add(txtBox3);
            Controls.Add(txtBoxNombre);
            Controls.Add(txtBoxApellido);
            Controls.Add(labelNombre);
            Controls.Add(labelApellido);
            Controls.Add(bEliminar);
            Controls.Add(bGuardar);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mi Primer Forms";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bGuardar;
        private Button bEliminar;
        private Label labelApellido;
        private Label labelNombre;
        private TextBox txtBoxApellido;
        private TextBox txtBoxNombre;
        private TextBox txtBox3;
        private Button bSalir;
    }
}