﻿namespace Formularios
{
    partial class FrmCursosAcargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCursosAcargo));
            btnSalir = new Button();
            dtgCrusos_alumnos = new DataGridView();
            btnMostrarAlumnos = new Button();
            btnIngresarNota = new Button();
            btnAsistancia = new Button();
            CbxTipoEvaluacion = new ComboBox();
            textBoxNota = new TextBox();
            btnGuardarNota = new Button();
            cbxAsistencia = new ComboBox();
            btnGuardarAsistencia = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgCrusos_alumnos).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(68, 149, 255);
            btnSalir.Location = new Point(24, 397);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // dtgCrusos_alumnos
            // 
            dtgCrusos_alumnos.BackgroundColor = SystemColors.ActiveCaption;
            dtgCrusos_alumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCrusos_alumnos.Location = new Point(34, 118);
            dtgCrusos_alumnos.Name = "dtgCrusos_alumnos";
            dtgCrusos_alumnos.RowTemplate.Height = 25;
            dtgCrusos_alumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgCrusos_alumnos.Size = new Size(640, 150);
            dtgCrusos_alumnos.TabIndex = 1;
            dtgCrusos_alumnos.CellClick += dtgCrusos_alumnos_CellClick;
            // 
            // btnMostrarAlumnos
            // 
            btnMostrarAlumnos.BackColor = Color.FromArgb(68, 149, 255);
            btnMostrarAlumnos.Location = new Point(252, 328);
            btnMostrarAlumnos.Name = "btnMostrarAlumnos";
            btnMostrarAlumnos.Size = new Size(125, 23);
            btnMostrarAlumnos.TabIndex = 2;
            btnMostrarAlumnos.Text = "Mostrar Alumnos ";
            btnMostrarAlumnos.UseVisualStyleBackColor = false;
            btnMostrarAlumnos.Click += btnMostrarAlumnos_Click;
            // 
            // btnIngresarNota
            // 
            btnIngresarNota.BackColor = Color.FromArgb(68, 149, 255);
            btnIngresarNota.Location = new Point(71, 286);
            btnIngresarNota.Name = "btnIngresarNota";
            btnIngresarNota.Size = new Size(110, 23);
            btnIngresarNota.TabIndex = 3;
            btnIngresarNota.Text = "ingresar Nota";
            btnIngresarNota.UseVisualStyleBackColor = false;
            btnIngresarNota.Visible = false;
            btnIngresarNota.Click += btnIngresarNota_Click;
            // 
            // btnAsistancia
            // 
            btnAsistancia.BackColor = Color.FromArgb(68, 149, 255);
            btnAsistancia.Location = new Point(501, 286);
            btnAsistancia.Name = "btnAsistancia";
            btnAsistancia.Size = new Size(93, 23);
            btnAsistancia.TabIndex = 4;
            btnAsistancia.Text = "Asistencia";
            btnAsistancia.UseVisualStyleBackColor = false;
            btnAsistancia.Visible = false;
            btnAsistancia.Click += btnAsistancia_Click;
            // 
            // CbxTipoEvaluacion
            // 
            CbxTipoEvaluacion.BackColor = Color.FromArgb(68, 149, 255);
            CbxTipoEvaluacion.FormattingEnabled = true;
            CbxTipoEvaluacion.Location = new Point(71, 72);
            CbxTipoEvaluacion.Name = "CbxTipoEvaluacion";
            CbxTipoEvaluacion.Size = new Size(182, 23);
            CbxTipoEvaluacion.TabIndex = 5;
            CbxTipoEvaluacion.Text = "Seleccione tipo Evaluacion";
            CbxTipoEvaluacion.Visible = false;
            // 
            // textBoxNota
            // 
            textBoxNota.BackColor = Color.White;
            textBoxNota.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNota.ForeColor = SystemColors.ControlLight;
            textBoxNota.Location = new Point(312, 72);
            textBoxNota.Name = "textBoxNota";
            textBoxNota.PlaceholderText = "Ingrese la nota";
            textBoxNota.Size = new Size(100, 23);
            textBoxNota.TabIndex = 6;
            textBoxNota.Visible = false;
            // 
            // btnGuardarNota
            // 
            btnGuardarNota.BackColor = Color.FromArgb(68, 149, 255);
            btnGuardarNota.Location = new Point(287, 286);
            btnGuardarNota.Name = "btnGuardarNota";
            btnGuardarNota.Size = new Size(134, 23);
            btnGuardarNota.TabIndex = 7;
            btnGuardarNota.Text = "Guardar Nota";
            btnGuardarNota.UseVisualStyleBackColor = false;
            btnGuardarNota.Visible = false;
            btnGuardarNota.Click += btnGuardarNota_Click;
            // 
            // cbxAsistencia
            // 
            cbxAsistencia.BackColor = Color.FromArgb(68, 149, 255);
            cbxAsistencia.FormattingEnabled = true;
            cbxAsistencia.Location = new Point(478, 72);
            cbxAsistencia.Name = "cbxAsistencia";
            cbxAsistencia.Size = new Size(160, 23);
            cbxAsistencia.TabIndex = 8;
            cbxAsistencia.Text = "Seleccione la Asistencia";
            cbxAsistencia.Visible = false;
            // 
            // btnGuardarAsistencia
            // 
            btnGuardarAsistencia.BackColor = Color.FromArgb(68, 149, 255);
            btnGuardarAsistencia.Location = new Point(414, 328);
            btnGuardarAsistencia.Name = "btnGuardarAsistencia";
            btnGuardarAsistencia.Size = new Size(129, 23);
            btnGuardarAsistencia.TabIndex = 9;
            btnGuardarAsistencia.Text = "Guardar Asistencia";
            btnGuardarAsistencia.UseVisualStyleBackColor = false;
            btnGuardarAsistencia.Visible = false;
            btnGuardarAsistencia.Click += btnGuardarAsistencia_Click;
            // 
            // FrmCursosAcargo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardarAsistencia);
            Controls.Add(cbxAsistencia);
            Controls.Add(btnGuardarNota);
            Controls.Add(textBoxNota);
            Controls.Add(CbxTipoEvaluacion);
            Controls.Add(btnAsistancia);
            Controls.Add(btnIngresarNota);
            Controls.Add(btnMostrarAlumnos);
            Controls.Add(dtgCrusos_alumnos);
            Controls.Add(btnSalir);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCursosAcargo";
            Text = "FrmCursosAcargo";
            Load += FrmCursosAcargo_Load;
            ((System.ComponentModel.ISupportInitialize)dtgCrusos_alumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private DataGridView dtgCrusos_alumnos;
        private Button btnMostrarAlumnos;
        private Button btnIngresarNota;
        private Button btnAsistancia;
        private ComboBox CbxTipoEvaluacion;
        private TextBox textBoxNota;
        private Button btnGuardarNota;
        private ComboBox cbxAsistencia;
        private Button btnGuardarAsistencia;
    }
}