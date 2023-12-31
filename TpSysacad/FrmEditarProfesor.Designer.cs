﻿namespace Formularios
{
    partial class FrmEditarProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarProfesor));
            btnSalir = new Button();
            btnGuardarProfesor = new Button();
            textBoxNombre = new TextBox();
            textBoxApellido = new TextBox();
            textBoxDni = new TextBox();
            textBoxDireccion = new TextBox();
            textBoxCorreo = new TextBox();
            textBoxTelefono = new TextBox();
            txtEspecializacion = new TextBox();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(68, 149, 255);
            btnSalir.Location = new Point(12, 398);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnGuardarProfesor
            // 
            btnGuardarProfesor.BackColor = Color.FromArgb(68, 149, 255);
            btnGuardarProfesor.Location = new Point(174, 327);
            btnGuardarProfesor.Name = "btnGuardarProfesor";
            btnGuardarProfesor.Size = new Size(144, 23);
            btnGuardarProfesor.TabIndex = 1;
            btnGuardarProfesor.Text = "Guardar Profesor";
            btnGuardarProfesor.UseVisualStyleBackColor = false;
            btnGuardarProfesor.Click += btnGuardarProfesor_Click;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(30, 136);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(100, 23);
            textBoxNombre.TabIndex = 2;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(30, 217);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(100, 23);
            textBoxApellido.TabIndex = 3;
            // 
            // textBoxDni
            // 
            textBoxDni.Location = new Point(174, 136);
            textBoxDni.Name = "textBoxDni";
            textBoxDni.Size = new Size(100, 23);
            textBoxDni.TabIndex = 4;
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Location = new Point(174, 217);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(100, 23);
            textBoxDireccion.TabIndex = 5;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.Location = new Point(292, 136);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(100, 23);
            textBoxCorreo.TabIndex = 6;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(292, 217);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(100, 23);
            textBoxTelefono.TabIndex = 7;
            // 
            // txtEspecializacion
            // 
            txtEspecializacion.Location = new Point(391, 175);
            txtEspecializacion.Name = "txtEspecializacion";
            txtEspecializacion.PlaceholderText = "Especializacion";
            txtEspecializacion.Size = new Size(100, 23);
            txtEspecializacion.TabIndex = 8;
            // 
            // FrmEditarProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(txtEspecializacion);
            Controls.Add(textBoxTelefono);
            Controls.Add(textBoxCorreo);
            Controls.Add(textBoxDireccion);
            Controls.Add(textBoxDni);
            Controls.Add(textBoxApellido);
            Controls.Add(textBoxNombre);
            Controls.Add(btnGuardarProfesor);
            Controls.Add(btnSalir);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmEditarProfesor";
            Text = "FrmEditarProfesor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Button btnGuardarProfesor;
        private TextBox textBoxNombre;
        private TextBox textBoxApellido;
        private TextBox textBoxDni;
        private TextBox textBoxDireccion;
        private TextBox textBoxCorreo;
        private TextBox textBoxTelefono;
        private TextBox txtEspecializacion;
    }
}