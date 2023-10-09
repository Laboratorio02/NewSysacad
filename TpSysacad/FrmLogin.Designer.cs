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
            BtnAdmin = new Button();
            BtnEstudiante = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(68, 149, 250);
            label1.Location = new Point(94, 45);
            label1.Name = "label1";
            label1.Size = new Size(372, 32);
            label1.TabIndex = 0;
            label1.Text = "Universidad Tecnológica Nacional";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(68, 149, 250);
            label2.Location = new Point(124, 107);
            label2.Name = "label2";
            label2.Size = new Size(217, 21);
            label2.TabIndex = 1;
            label2.Text = "Sistema Académico SYSACAD";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.FromArgb(68, 149, 250);
            BtnLogin.Cursor = Cursors.Hand;
            BtnLogin.FlatAppearance.BorderColor = Color.FromArgb(68, 149, 250);
            BtnLogin.FlatAppearance.BorderSize = 0;
            BtnLogin.FlatStyle = FlatStyle.Flat;
            BtnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            BtnLogin.ForeColor = SystemColors.HighlightText;
            BtnLogin.Location = new Point(103, 310);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(247, 28);
            BtnLogin.TabIndex = 2;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // textUsuario
            // 
            textUsuario.BackColor = Color.FromArgb(249, 250, 251);
            textUsuario.BorderStyle = BorderStyle.None;
            textUsuario.ForeColor = Color.Black;
            textUsuario.Location = new Point(103, 189);
            textUsuario.Name = "textUsuario";
            textUsuario.PlaceholderText = "Usuario";
            textUsuario.Size = new Size(247, 16);
            textUsuario.TabIndex = 3;
            textUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // textContraseña
            // 
            textContraseña.BackColor = Color.FromArgb(249, 250, 251);
            textContraseña.BorderStyle = BorderStyle.None;
            textContraseña.Location = new Point(103, 235);
            textContraseña.Name = "textContraseña";
            textContraseña.PasswordChar = '*';
            textContraseña.PlaceholderText = "Contraseña";
            textContraseña.Size = new Size(247, 16);
            textContraseña.TabIndex = 4;
            textContraseña.TextAlign = HorizontalAlignment.Center;
            // 
            // BtnAdmin
            // 
            BtnAdmin.BackColor = Color.FromArgb(68, 149, 250);
            BtnAdmin.Cursor = Cursors.Hand;
            BtnAdmin.ForeColor = Color.White;
            BtnAdmin.Location = new Point(2, 398);
            BtnAdmin.Name = "BtnAdmin";
            BtnAdmin.Size = new Size(96, 23);
            BtnAdmin.TabIndex = 5;
            BtnAdmin.Text = "Administrador";
            BtnAdmin.UseVisualStyleBackColor = false;
            BtnAdmin.Click += BtnAdmin_Click;
            // 
            // BtnEstudiante
            // 
            BtnEstudiante.BackColor = Color.FromArgb(68, 149, 250);
            BtnEstudiante.Cursor = Cursors.Hand;
            BtnEstudiante.ForeColor = Color.White;
            BtnEstudiante.Location = new Point(2, 446);
            BtnEstudiante.Name = "BtnEstudiante";
            BtnEstudiante.Size = new Size(96, 23);
            BtnEstudiante.TabIndex = 6;
            BtnEstudiante.Text = "Estudiante";
            BtnEstudiante.UseVisualStyleBackColor = false;
            BtnEstudiante.Click += BtnEstudiante_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(808, 481);
            Controls.Add(BtnEstudiante);
            Controls.Add(BtnAdmin);
            Controls.Add(textContraseña);
            Controls.Add(textUsuario);
            Controls.Add(BtnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.DodgerBlue;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
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
        private Button BtnAdmin;
        private Button BtnEstudiante;
    }
}