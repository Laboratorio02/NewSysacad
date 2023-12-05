namespace Formularios
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            label1 = new Label();
            label2 = new Label();
            BtnLogin = new Button();
            textUsuario = new TextBox();
            textContraseña = new TextBox();
            BtnEstudiante = new Button();
            BtnAdministrador = new Button();
            btnProfesor = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(68, 149, 255);
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(104, 33);
            label1.Name = "label1";
            label1.Size = new Size(324, 30);
            label1.TabIndex = 0;
            label1.Text = "Universidad Tecnológica Nacional";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(68, 149, 255);
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(128, 101);
            label2.Name = "label2";
            label2.Size = new Size(217, 21);
            label2.TabIndex = 1;
            label2.Text = "Sistema Académico SYSACAD";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.FromArgb(68, 149, 255);
            BtnLogin.BackgroundImageLayout = ImageLayout.Zoom;
            BtnLogin.Cursor = Cursors.Hand;
            BtnLogin.FlatAppearance.BorderSize = 0;
            BtnLogin.FlatStyle = FlatStyle.Flat;
            BtnLogin.Location = new Point(104, 313);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(241, 23);
            BtnLogin.TabIndex = 2;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // textUsuario
            // 
            textUsuario.BorderStyle = BorderStyle.None;
            textUsuario.Location = new Point(104, 180);
            textUsuario.Name = "textUsuario";
            textUsuario.PlaceholderText = "Usuario";
            textUsuario.Size = new Size(241, 16);
            textUsuario.TabIndex = 3;
            // 
            // textContraseña
            // 
            textContraseña.BorderStyle = BorderStyle.None;
            textContraseña.Location = new Point(104, 235);
            textContraseña.Name = "textContraseña";
            textContraseña.PasswordChar = '*';
            textContraseña.PlaceholderText = "Contraseña";
            textContraseña.Size = new Size(241, 16);
            textContraseña.TabIndex = 4;
            // 
            // BtnEstudiante
            // 
            BtnEstudiante.BackColor = Color.FromArgb(68, 149, 255);
            BtnEstudiante.Cursor = Cursors.Hand;
            BtnEstudiante.Location = new Point(12, 386);
            BtnEstudiante.Name = "BtnEstudiante";
            BtnEstudiante.Size = new Size(104, 23);
            BtnEstudiante.TabIndex = 5;
            BtnEstudiante.Text = "Estudiante";
            BtnEstudiante.UseVisualStyleBackColor = false;
            BtnEstudiante.Click += BtnEstudiante_Click_1;
            // 
            // BtnAdministrador
            // 
            BtnAdministrador.BackColor = Color.FromArgb(68, 149, 255);
            BtnAdministrador.Cursor = Cursors.Hand;
            BtnAdministrador.Location = new Point(12, 357);
            BtnAdministrador.Name = "BtnAdministrador";
            BtnAdministrador.Size = new Size(104, 23);
            BtnAdministrador.TabIndex = 6;
            BtnAdministrador.Text = "Administrador";
            BtnAdministrador.UseVisualStyleBackColor = false;
            BtnAdministrador.Click += BtnAdministrador_Click;
            // 
            // btnProfesor
            // 
            btnProfesor.BackColor = Color.FromArgb(68, 149, 255);
            btnProfesor.Cursor = Cursors.Hand;
            btnProfesor.Location = new Point(12, 415);
            btnProfesor.Name = "btnProfesor";
            btnProfesor.Size = new Size(104, 23);
            btnProfesor.TabIndex = 7;
            btnProfesor.Text = "Profesor";
            btnProfesor.UseVisualStyleBackColor = false;
            btnProfesor.Click += btnProfesor_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Login;
            ClientSize = new Size(800, 450);
            Controls.Add(btnProfesor);
            Controls.Add(BtnAdministrador);
            Controls.Add(BtnEstudiante);
            Controls.Add(textContraseña);
            Controls.Add(textUsuario);
            Controls.Add(BtnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonFace;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmLogin";
            Text = "Sysacad Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button BtnLogin;
        private TextBox textUsuario;
        private TextBox textContraseña;
        private Button BtnEstudiante;
        private Button BtnAdministrador;
        private Button btnProfesor;
    }
}