namespace Formularios
{
    partial class FormMostrarReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMostrarReporte));
            lblMuestraPDF = new Label();
            btnGenerarPDF = new Button();
            SuspendLayout();
            // 
            // lblMuestraPDF
            // 
            lblMuestraPDF.AutoSize = true;
            lblMuestraPDF.Location = new Point(133, 38);
            lblMuestraPDF.Margin = new Padding(2, 0, 2, 0);
            lblMuestraPDF.Name = "lblMuestraPDF";
            lblMuestraPDF.Size = new Size(30, 15);
            lblMuestraPDF.TabIndex = 0;
            lblMuestraPDF.Text = "hola";
            // 
            // btnGenerarPDF
            // 
            btnGenerarPDF.BackColor = Color.FromArgb(68, 149, 255);
            btnGenerarPDF.Location = new Point(359, 383);
            btnGenerarPDF.Margin = new Padding(2, 2, 2, 2);
            btnGenerarPDF.Name = "btnGenerarPDF";
            btnGenerarPDF.Size = new Size(125, 24);
            btnGenerarPDF.TabIndex = 1;
            btnGenerarPDF.Text = "Generar PDF";
            btnGenerarPDF.UseVisualStyleBackColor = false;
            btnGenerarPDF.Click += btnGenerarPDF_Click;
            // 
            // FormMostrarReporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 447);
            Controls.Add(btnGenerarPDF);
            Controls.Add(lblMuestraPDF);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            Name = "FormMostrarReporte";
            Text = "FormMostrarReporte";
            Load += FormMostrarReporte_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMuestraPDF;
        private Button btnGenerarPDF;
    }
}