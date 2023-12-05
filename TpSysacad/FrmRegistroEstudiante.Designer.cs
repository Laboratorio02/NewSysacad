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
            RbtnCambiarcontrasenia = new RadioButton();
            btnVolver = new Button();
            btnRegistro = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(176, 32);
            label1.Name = "label1";
            label1.Size = new Size(144, 21);
            label1.TabIndex = 0;
            label1.Text = "Registro Estudiante";
            // 
            // textNombre
            // 
            textNombre.Location = new Point(200, 95);
            textNombre.Name = "textNombre";
            textNombre.PlaceholderText = "Nombre";
            textNombre.Size = new Size(100, 23);
            textNombre.TabIndex = 1;
            // 
            // textApellido
            // 
            textApellido.Location = new Point(200, 136);
            textApellido.Name = "textApellido";
            textApellido.PlaceholderText = "Apellido";
            textApellido.Size = new Size(100, 23);
            textApellido.TabIndex = 2;
            // 
            // textDni
            // 
            textDni.Location = new Point(200, 178);
            textDni.Name = "textDni";
            textDni.PlaceholderText = "DNI";
            textDni.Size = new Size(100, 23);
            textDni.TabIndex = 3;
            // 
            // textDireccion
            // 
            textDireccion.Location = new Point(200, 216);
            textDireccion.Name = "textDireccion";
            textDireccion.PlaceholderText = "Direccion";
            textDireccion.Size = new Size(100, 23);
            textDireccion.TabIndex = 4;
            // 
            // textTelefono
            // 
            textTelefono.Location = new Point(200, 259);
            textTelefono.Name = "textTelefono";
            textTelefono.PlaceholderText = "Telefono";
            textTelefono.Size = new Size(100, 23);
            textTelefono.TabIndex = 5;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(200, 324);
            textEmail.Name = "textEmail";
            textEmail.PlaceholderText = "Email";
            textEmail.Size = new Size(153, 23);
            textEmail.TabIndex = 6;
            // 
            // RbtnCambiarcontrasenia
            // 
            RbtnCambiarcontrasenia.AutoSize = true;
            RbtnCambiarcontrasenia.BackColor = Color.FromArgb(68, 149, 255);
            RbtnCambiarcontrasenia.Cursor = Cursors.Hand;
            RbtnCambiarcontrasenia.Location = new Point(344, 286);
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
            btnVolver.BackColor = Color.FromArgb(68, 149, 255);
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.Location = new Point(97, 326);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnRegistro
            // 
            btnRegistro.BackColor = Color.FromArgb(128, 255, 128);
            btnRegistro.Cursor = Cursors.Hand;
            btnRegistro.Location = new Point(391, 326);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(75, 23);
            btnRegistro.TabIndex = 7;
            btnRegistro.Text = "Registrar";
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.Click += BtnRegistro_Click;
            // 
            // FrmRegistroEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private RadioButton RbtnCambiarcontrasenia;
        private Button btnVolver;
        private Button btnRegistro;
    }
}