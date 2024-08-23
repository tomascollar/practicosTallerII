namespace Practico2
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
            btnGuardar = new Button();
            btnEliminar = new Button();
            LApenom = new Label();
            LDNI = new Label();
            LApellido = new Label();
            LNombre = new Label();
            LModificar = new Label();
            txtNombre = new TextBox();
            txtDNI = new TextBox();
            txtApellido = new TextBox();
            panel1 = new Panel();
            LTarjeta = new Label();
            checkMasterCard = new CheckBox();
            checkVisa = new CheckBox();
            txtTelefono = new TextBox();
            checkNaranja = new CheckBox();
            LTelefono = new Label();
            pictureBox1 = new PictureBox();
            RBHombre = new RadioButton();
            RBMujer = new RadioButton();
            btnSalir = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ButtonHighlight;
            btnGuardar.Image = Properties.Resources.guardar;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(85, 357);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(128, 71);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Image = Properties.Resources.eliminar;
            btnEliminar.Location = new Point(268, 358);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(118, 68);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // LApenom
            // 
            LApenom.AutoSize = true;
            LApenom.Location = new Point(24, 20);
            LApenom.Name = "LApenom";
            LApenom.Size = new Size(110, 15);
            LApenom.TabIndex = 2;
            LApenom.Text = "Nombre y Apellido:";
            // 
            // LDNI
            // 
            LDNI.AutoSize = true;
            LDNI.Location = new Point(24, 65);
            LDNI.Name = "LDNI";
            LDNI.Size = new Size(27, 15);
            LDNI.TabIndex = 3;
            LDNI.Text = "DNI";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(24, 100);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 4;
            LApellido.Text = "Apellido";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(24, 139);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 5;
            LNombre.Text = "Nombre";
            // 
            // LModificar
            // 
            LModificar.AutoSize = true;
            LModificar.ForeColor = Color.Red;
            LModificar.Location = new Point(165, 20);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(58, 15);
            LModificar.TabIndex = 6;
            LModificar.Text = "modificar";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(136, 131);
            txtNombre.Name = "txtNombre";
            txtNombre.ShortcutsEnabled = false;
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 7;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(136, 57);
            txtDNI.Name = "txtDNI";
            txtDNI.ShortcutsEnabled = false;
            txtDNI.Size = new Size(100, 23);
            txtDNI.TabIndex = 8;
            txtDNI.KeyPress += txtDNI_KeyPress;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(136, 97);
            txtApellido.Name = "txtApellido";
            txtApellido.ShortcutsEnabled = false;
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 9;
            txtApellido.KeyPress += txtApellido_KeyPress;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(LTarjeta);
            panel1.Controls.Add(checkMasterCard);
            panel1.Controls.Add(checkVisa);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(checkNaranja);
            panel1.Controls.Add(LTelefono);
            panel1.Controls.Add(LApenom);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(txtDNI);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(LDNI);
            panel1.Controls.Add(LModificar);
            panel1.Controls.Add(LApellido);
            panel1.Controls.Add(LNombre);
            panel1.Location = new Point(84, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(302, 304);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // LTarjeta
            // 
            LTarjeta.AutoSize = true;
            LTarjeta.Location = new Point(24, 217);
            LTarjeta.Name = "LTarjeta";
            LTarjeta.Size = new Size(105, 15);
            LTarjeta.TabIndex = 15;
            LTarjeta.Text = "Tarjeta de creditos:";
            // 
            // checkMasterCard
            // 
            checkMasterCard.AutoSize = true;
            checkMasterCard.Location = new Point(136, 276);
            checkMasterCard.Name = "checkMasterCard";
            checkMasterCard.Size = new Size(85, 19);
            checkMasterCard.TabIndex = 14;
            checkMasterCard.Text = "Mastercard";
            checkMasterCard.UseVisualStyleBackColor = true;
            // 
            // checkVisa
            // 
            checkVisa.AutoSize = true;
            checkVisa.Location = new Point(136, 251);
            checkVisa.Name = "checkVisa";
            checkVisa.Size = new Size(47, 19);
            checkVisa.TabIndex = 13;
            checkVisa.Text = "Visa";
            checkVisa.UseVisualStyleBackColor = true;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(136, 174);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 12;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // checkNaranja
            // 
            checkNaranja.AutoSize = true;
            checkNaranja.Location = new Point(136, 226);
            checkNaranja.Name = "checkNaranja";
            checkNaranja.Size = new Size(67, 19);
            checkNaranja.TabIndex = 11;
            checkNaranja.Text = "Naranja";
            checkNaranja.UseVisualStyleBackColor = true;
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Location = new Point(24, 182);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(52, 15);
            LTelefono.TabIndex = 10;
            LTelefono.Text = "Telefono";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.BackgroundImage = Properties.Resources.varon;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.InitialImage = Properties.Resources.varon;
            pictureBox1.Location = new Point(488, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 146);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // RBHombre
            // 
            RBHombre.AutoSize = true;
            RBHombre.Checked = true;
            RBHombre.Location = new Point(488, 223);
            RBHombre.Name = "RBHombre";
            RBHombre.Size = new Size(69, 19);
            RBHombre.TabIndex = 18;
            RBHombre.TabStop = true;
            RBHombre.Text = "Hombre";
            RBHombre.UseVisualStyleBackColor = true;
            RBHombre.CheckedChanged += RBHombre_CheckedChanged;
            // 
            // RBMujer
            // 
            RBMujer.AutoSize = true;
            RBMujer.Location = new Point(588, 222);
            RBMujer.Name = "RBMujer";
            RBMujer.Size = new Size(56, 19);
            RBMujer.TabIndex = 19;
            RBMujer.Text = "Mujer";
            RBMujer.UseVisualStyleBackColor = true;
            RBMujer.CheckedChanged += RBMujer_CheckedChanged;
            // 
            // btnSalir
            // 
            btnSalir.Image = Properties.Resources.salir;
            btnSalir.Location = new Point(564, 357);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(134, 68);
            btnSalir.TabIndex = 20;
            btnSalir.Text = "Salir";
            btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 453);
            Controls.Add(btnSalir);
            Controls.Add(RBMujer);
            Controls.Add(RBHombre);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Name = "Form1";
            Text = "Pequeño Formulario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button btnEliminar;
        private Label LApenom;
        private Label LDNI;
        private Label LApellido;
        private Label LNombre;
        private Label LModificar;
        private TextBox txtNombre;
        private TextBox txtDNI;
        private TextBox txtApellido;
        private Panel panel1;
        private TextBox txtTelefono;
        private CheckBox checkNaranja;
        private Label LTelefono;
        private Label LTarjeta;
        private CheckBox checkMasterCard;
        private CheckBox checkVisa;
        private PictureBox pictureBox1;
        private RadioButton RBHombre;
        private RadioButton RBMujer;
        private Button btnSalir;
    }
}