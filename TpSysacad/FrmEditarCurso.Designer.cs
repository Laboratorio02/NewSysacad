namespace Formularios
{
    partial class FrmEditarCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarCurso));
            label1 = new Label();
            textBoxNombre = new TextBox();
            textBoxCodigo = new TextBox();
            textBoxDescripcion = new TextBox();
            textBoxCupoMax = new TextBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(182, 181, 181);
            label1.Location = new Point(244, 123);
            label1.Name = "label1";
            label1.Size = new Size(50, 21);
            label1.TabIndex = 0;
            label1.Text = "Editar";
            // 
            // textBoxNombre
            // 
            textBoxNombre.BackColor = Color.Goldenrod;
            textBoxNombre.Location = new Point(23, 194);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(100, 23);
            textBoxNombre.TabIndex = 1;
            textBoxNombre.Text = "Nombre";
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.BackColor = Color.Goldenrod;
            textBoxCodigo.Location = new Point(141, 194);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(100, 23);
            textBoxCodigo.TabIndex = 2;
            textBoxCodigo.Text = "Codigo";
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.BackColor = Color.Goldenrod;
            textBoxDescripcion.Location = new Point(257, 194);
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(117, 23);
            textBoxDescripcion.TabIndex = 3;
            textBoxDescripcion.Text = "Descripcion";
            // 
            // textBoxCupoMax
            // 
            textBoxCupoMax.BackColor = Color.Goldenrod;
            textBoxCupoMax.Location = new Point(391, 194);
            textBoxCupoMax.Name = "textBoxCupoMax";
            textBoxCupoMax.Size = new Size(100, 23);
            textBoxCupoMax.TabIndex = 4;
            textBoxCupoMax.Text = "Cupo Maximo";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(128, 255, 128);
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.Location = new Point(219, 331);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FrmEditarCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(btnAceptar);
            Controls.Add(textBoxCupoMax);
            Controls.Add(textBoxDescripcion);
            Controls.Add(textBoxCodigo);
            Controls.Add(textBoxNombre);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "FrmEditarCurso";
            Text = "FrmEditarCurso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNombre;
        private TextBox textBoxCodigo;
        private TextBox textBoxDescripcion;
        private TextBox textBoxCupoMax;
        private Button btnAceptar;
    }
}