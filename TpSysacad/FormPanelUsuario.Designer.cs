namespace Formularios
{
    partial class FormPanelUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPanelUsuario));
            btnRegistrarEstudiante = new Button();
            btnGestionarCursos = new Button();
            labelUsaurio = new Label();
            btnInscripcionCurso = new Button();
            btnConsultarHorario = new Button();
            btnRealizarPagos = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnRegistrarEstudiante
            // 
            btnRegistrarEstudiante.BackColor = Color.FromArgb(68, 149, 250);
            btnRegistrarEstudiante.Cursor = Cursors.Hand;
            btnRegistrarEstudiante.FlatAppearance.BorderSize = 0;
            btnRegistrarEstudiante.FlatStyle = FlatStyle.Flat;
            btnRegistrarEstudiante.ForeColor = Color.White;
            btnRegistrarEstudiante.Location = new Point(142, 71);
            btnRegistrarEstudiante.Margin = new Padding(2);
            btnRegistrarEstudiante.Name = "btnRegistrarEstudiante";
            btnRegistrarEstudiante.Size = new Size(130, 20);
            btnRegistrarEstudiante.TabIndex = 0;
            btnRegistrarEstudiante.Text = "Registrar Estudiante";
            btnRegistrarEstudiante.UseVisualStyleBackColor = false;
            btnRegistrarEstudiante.Click += button1_Click;
            // 
            // btnGestionarCursos
            // 
            btnGestionarCursos.BackColor = Color.FromArgb(68, 149, 250);
            btnGestionarCursos.Cursor = Cursors.Hand;
            btnGestionarCursos.FlatAppearance.BorderSize = 0;
            btnGestionarCursos.FlatStyle = FlatStyle.Flat;
            btnGestionarCursos.ForeColor = Color.White;
            btnGestionarCursos.Location = new Point(142, 162);
            btnGestionarCursos.Margin = new Padding(2);
            btnGestionarCursos.Name = "btnGestionarCursos";
            btnGestionarCursos.Size = new Size(130, 20);
            btnGestionarCursos.TabIndex = 1;
            btnGestionarCursos.Text = "Gestionar Curso";
            btnGestionarCursos.UseVisualStyleBackColor = false;
            btnGestionarCursos.Click += BtnGestionarCursos_Click;
            // 
            // labelUsaurio
            // 
            labelUsaurio.AutoSize = true;
            labelUsaurio.BackColor = Color.Transparent;
            labelUsaurio.FlatStyle = FlatStyle.Flat;
            labelUsaurio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelUsaurio.ForeColor = Color.FromArgb(68, 149, 250);
            labelUsaurio.Location = new Point(142, 31);
            labelUsaurio.Margin = new Padding(2, 0, 2, 0);
            labelUsaurio.Name = "labelUsaurio";
            labelUsaurio.Size = new Size(47, 21);
            labelUsaurio.TabIndex = 2;
            labelUsaurio.Text = "Panel";
            // 
            // btnInscripcionCurso
            // 
            btnInscripcionCurso.Location = new Point(142, 114);
            btnInscripcionCurso.Margin = new Padding(2);
            btnInscripcionCurso.Name = "btnInscripcionCurso";
            btnInscripcionCurso.Size = new Size(130, 20);
            btnInscripcionCurso.TabIndex = 3;
            btnInscripcionCurso.Text = "Inscripcion a cursos";
            btnInscripcionCurso.UseVisualStyleBackColor = true;
            btnInscripcionCurso.Click += button2_Click;
            // 
            // btnConsultarHorario
            // 
            btnConsultarHorario.BackColor = Color.FromArgb(68, 149, 250);
            btnConsultarHorario.Cursor = Cursors.Hand;
            btnConsultarHorario.FlatAppearance.BorderSize = 0;
            btnConsultarHorario.FlatStyle = FlatStyle.Flat;
            btnConsultarHorario.ForeColor = Color.White;
            btnConsultarHorario.Location = new Point(142, 114);
            btnConsultarHorario.Margin = new Padding(2);
            btnConsultarHorario.Name = "btnConsultarHorario";
            btnConsultarHorario.Size = new Size(130, 20);
            btnConsultarHorario.TabIndex = 4;
            btnConsultarHorario.Text = "Consultar Horario";
            btnConsultarHorario.UseVisualStyleBackColor = false;
            btnConsultarHorario.Click += button3_Click;
            // 
            // btnRealizarPagos
            // 
            btnRealizarPagos.BackColor = Color.FromArgb(68, 149, 250);
            btnRealizarPagos.Cursor = Cursors.Hand;
            btnRealizarPagos.FlatAppearance.BorderSize = 0;
            btnRealizarPagos.FlatStyle = FlatStyle.Popup;
            btnRealizarPagos.ForeColor = Color.White;
            btnRealizarPagos.Location = new Point(142, 208);
            btnRealizarPagos.Margin = new Padding(2);
            btnRealizarPagos.Name = "btnRealizarPagos";
            btnRealizarPagos.Size = new Size(130, 20);
            btnRealizarPagos.TabIndex = 5;
            btnRealizarPagos.Text = "Realizar Pagos";
            btnRealizarPagos.UseVisualStyleBackColor = false;
            btnRealizarPagos.Click += button4_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(68, 149, 250);
            btnSalir.BackgroundImageLayout = ImageLayout.None;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(11, 258);
            btnSalir.Margin = new Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(127, 25);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormPanelUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(808, 481);
            Controls.Add(btnSalir);
            Controls.Add(btnRealizarPagos);
            Controls.Add(btnConsultarHorario);
            Controls.Add(btnInscripcionCurso);
            Controls.Add(labelUsaurio);
            Controls.Add(btnGestionarCursos);
            Controls.Add(btnRegistrarEstudiante);
            Margin = new Padding(2);
            Name = "FormPanelUsuario";
            Text = "PanelUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrarEstudiante;
        private Button btnGestionarCursos;
        private Label labelUsaurio;
        private Button btnInscripcionCurso;
        private Button btnConsultarHorario;
        private Button btnRealizarPagos;
        private Button btnSalir;
    }
}