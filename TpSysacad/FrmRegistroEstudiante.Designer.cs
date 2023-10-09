namespace Formularios
{
    partial class FrmRegistroEstudiante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroEstudiante));
            label1 = new Label();
            textNombre = new TextBox();
            textApellido = new TextBox();
            textDni = new TextBox();
            textDireccion = new TextBox();
            textTelefono = new TextBox();
            textEmail = new TextBox();
            btnRegistro = new Button();
            RbtnCambiarcontrasenia = new RadioButton();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(199, 31);
            label1.Name = "label1";
            label1.Size = new Size(144, 21);
            label1.TabIndex = 0;
            label1.Text = "Registro Estudiante";
            // 
            // textNombre
            // 
            textNombre.BackColor = Color.FromArgb(34, 192, 212);
            textNombre.BorderStyle = BorderStyle.None;
            textNombre.ForeColor = SystemColors.WindowText;
            textNombre.Location = new Point(223, 84);
            textNombre.Name = "textNombre";
            textNombre.PlaceholderText = "Nombre";
            textNombre.Size = new Size(88, 16);
            textNombre.TabIndex = 1;
            // 
            // textApellido
            // 
            textApellido.BackColor = Color.FromArgb(34, 192, 212);
            textApellido.BorderStyle = BorderStyle.None;
            textApellido.Location = new Point(223, 129);
            textApellido.Name = "textApellido";
            textApellido.PlaceholderText = "Apellido";
            textApellido.Size = new Size(88, 16);
            textApellido.TabIndex = 2;
            // 
            // textDni
            // 
            textDni.BackColor = Color.FromArgb(34, 192, 212);
            textDni.BorderStyle = BorderStyle.None;
            textDni.Location = new Point(223, 176);
            textDni.Name = "textDni";
            textDni.PlaceholderText = "DNI";
            textDni.Size = new Size(88, 16);
            textDni.TabIndex = 3;
            // 
            // textDireccion
            // 
            textDireccion.BackColor = Color.FromArgb(34, 192, 212);
            textDireccion.BorderStyle = BorderStyle.None;
            textDireccion.Location = new Point(223, 221);
            textDireccion.Name = "textDireccion";
            textDireccion.PlaceholderText = "Direccion";
            textDireccion.Size = new Size(88, 16);
            textDireccion.TabIndex = 4;
            // 
            // textTelefono
            // 
            textTelefono.BackColor = Color.FromArgb(34, 192, 212);
            textTelefono.BorderStyle = BorderStyle.None;
            textTelefono.Location = new Point(223, 270);
            textTelefono.Name = "textTelefono";
            textTelefono.PlaceholderText = "Telefono";
            textTelefono.Size = new Size(88, 16);
            textTelefono.TabIndex = 5;
            // 
            // textEmail
            // 
            textEmail.BackColor = Color.FromArgb(34, 192, 212);
            textEmail.BorderStyle = BorderStyle.None;
            textEmail.Location = new Point(223, 330);
            textEmail.Name = "textEmail";
            textEmail.PlaceholderText = "Email";
            textEmail.Size = new Size(88, 16);
            textEmail.TabIndex = 6;
            // 
            // btnRegistro
            // 
            btnRegistro.BackColor = Color.FromArgb(222, 224, 239);
            btnRegistro.FlatAppearance.BorderSize = 0;
            btnRegistro.FlatStyle = FlatStyle.Flat;
            btnRegistro.Location = new Point(608, 339);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(75, 23);
            btnRegistro.TabIndex = 7;
            btnRegistro.Text = "Registrar";
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.Click += BtnRegistro_Click;
            // 
            // RbtnCambiarcontrasenia
            // 
            RbtnCambiarcontrasenia.AutoSize = true;
            RbtnCambiarcontrasenia.BackColor = Color.FromArgb(34, 192, 212);
            RbtnCambiarcontrasenia.Location = new Point(223, 393);
            RbtnCambiarcontrasenia.Name = "RbtnCambiarcontrasenia";
            RbtnCambiarcontrasenia.Size = new Size(122, 19);
            RbtnCambiarcontrasenia.TabIndex = 9;
            RbtnCambiarcontrasenia.TabStop = true;
            RbtnCambiarcontrasenia.Text = "Cambiar Contraña";
            RbtnCambiarcontrasenia.UseVisualStyleBackColor = false;
            RbtnCambiarcontrasenia.CheckedChanged += RbtnCambiarcontrasenia_CheckedChanged;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(255, 107, 187);
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Location = new Point(56, 393);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(76, 19);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // FrmRegistroEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(808, 481);
            Controls.Add(btnVolver);
            Controls.Add(RbtnCambiarcontrasenia);
            Controls.Add(btnRegistro);
            Controls.Add(textEmail);
            Controls.Add(textTelefono);
            Controls.Add(textDireccion);
            Controls.Add(textDni);
            Controls.Add(textApellido);
            Controls.Add(textNombre);
            Controls.Add(label1);
            Name = "FrmRegistroEstudiante";
            Text = "FrmRegistroEstudiante";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textNombre;
        private TextBox textApellido;
        private TextBox textDni;
        private TextBox textDireccion;
        private TextBox textTelefono;
        private TextBox textEmail;
        private Button btnRegistro;
        private RadioButton RbtnCambiarcontrasenia;
        private Button btnVolver;
    }
}