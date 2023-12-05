namespace Formularios
{
    partial class FormGenerarReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGenerarReportes));
            dataGridViewReportes = new DataGridView();
            Check = new DataGridViewCheckBoxColumn();
            Informe = new DataGridViewTextBoxColumn();
            label = new Label();
            cBCurso = new ComboBox();
            btnMuestra = new Button();
            btnGenerador = new Button();
            cBPeriodo = new ComboBox();
            cBPago = new ComboBox();
            btnAtras = new Button();
            cBEspera = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReportes).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewReportes
            // 
            dataGridViewReportes.AllowUserToAddRows = false;
            dataGridViewReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewReportes.BackgroundColor = Color.FromArgb(68, 149, 255);
            dataGridViewReportes.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReportes.Columns.AddRange(new DataGridViewColumn[] { Check, Informe });
            dataGridViewReportes.Location = new Point(173, 90);
            dataGridViewReportes.Margin = new Padding(2, 2, 2, 2);
            dataGridViewReportes.Name = "dataGridViewReportes";
            dataGridViewReportes.RowHeadersWidth = 62;
            dataGridViewReportes.RowTemplate.Height = 33;
            dataGridViewReportes.Size = new Size(474, 135);
            dataGridViewReportes.TabIndex = 0;
            dataGridViewReportes.CellContentClick += dataGridViewReportes_CellContentClick;
            // 
            // Check
            // 
            Check.HeaderText = "Check";
            Check.MinimumWidth = 8;
            Check.Name = "Check";
            Check.Width = 46;
            // 
            // Informe
            // 
            Informe.HeaderText = "Informe";
            Informe.MinimumWidth = 8;
            Informe.Name = "Informe";
            Informe.Width = 74;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(227, 5);
            label.Margin = new Padding(2, 0, 2, 0);
            label.Name = "label";
            label.Size = new Size(92, 15);
            label.TabIndex = 1;
            label.Text = "Generar Reporte";
            // 
            // cBCurso
            // 
            cBCurso.BackColor = Color.FromArgb(68, 149, 255);
            cBCurso.FlatStyle = FlatStyle.Flat;
            cBCurso.FormattingEnabled = true;
            cBCurso.Location = new Point(217, 276);
            cBCurso.Margin = new Padding(2, 2, 2, 2);
            cBCurso.Name = "cBCurso";
            cBCurso.Size = new Size(129, 23);
            cBCurso.TabIndex = 2;
            cBCurso.Text = "Curso";
            cBCurso.Visible = false;
            // 
            // btnMuestra
            // 
            btnMuestra.BackColor = Color.FromArgb(68, 149, 255);
            btnMuestra.Location = new Point(57, 276);
            btnMuestra.Margin = new Padding(2, 2, 2, 2);
            btnMuestra.Name = "btnMuestra";
            btnMuestra.Size = new Size(109, 23);
            btnMuestra.TabIndex = 3;
            btnMuestra.Text = "Mostrar Datos";
            btnMuestra.UseVisualStyleBackColor = false;
            btnMuestra.Click += btnMuestra_Click;
            // 
            // btnGenerador
            // 
            btnGenerador.BackColor = Color.FromArgb(68, 149, 255);
            btnGenerador.Location = new Point(57, 239);
            btnGenerador.Margin = new Padding(2, 2, 2, 2);
            btnGenerador.Name = "btnGenerador";
            btnGenerador.Size = new Size(109, 24);
            btnGenerador.TabIndex = 4;
            btnGenerador.Text = "Generar Reporte";
            btnGenerador.UseVisualStyleBackColor = false;
            btnGenerador.Visible = false;
            btnGenerador.Click += btnGenerador_Click;
            // 
            // cBPeriodo
            // 
            cBPeriodo.BackColor = Color.FromArgb(68, 149, 255);
            cBPeriodo.FlatStyle = FlatStyle.Flat;
            cBPeriodo.FormattingEnabled = true;
            cBPeriodo.Location = new Point(217, 303);
            cBPeriodo.Margin = new Padding(2, 2, 2, 2);
            cBPeriodo.Name = "cBPeriodo";
            cBPeriodo.Size = new Size(129, 23);
            cBPeriodo.TabIndex = 5;
            cBPeriodo.Text = "Periodo";
            cBPeriodo.Visible = false;
            // 
            // cBPago
            // 
            cBPago.BackColor = Color.FromArgb(68, 149, 255);
            cBPago.FlatStyle = FlatStyle.Flat;
            cBPago.FormattingEnabled = true;
            cBPago.Location = new Point(217, 249);
            cBPago.Margin = new Padding(2, 2, 2, 2);
            cBPago.Name = "cBPago";
            cBPago.Size = new Size(129, 23);
            cBPago.TabIndex = 6;
            cBPago.Text = "Pago";
            cBPago.Visible = false;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.FromArgb(68, 149, 255);
            btnAtras.Location = new Point(57, 357);
            btnAtras.Margin = new Padding(2, 2, 2, 2);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(78, 20);
            btnAtras.TabIndex = 7;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // cBEspera
            // 
            cBEspera.BackColor = Color.FromArgb(68, 149, 255);
            cBEspera.FlatStyle = FlatStyle.Popup;
            cBEspera.FormattingEnabled = true;
            cBEspera.Location = new Point(217, 330);
            cBEspera.Margin = new Padding(2, 2, 2, 2);
            cBEspera.Name = "cBEspera";
            cBEspera.Size = new Size(129, 23);
            cBEspera.TabIndex = 8;
            cBEspera.Text = "Espera Por Curso";
            cBEspera.Visible = false;
            // 
            // FormGenerarReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(cBEspera);
            Controls.Add(btnAtras);
            Controls.Add(cBPago);
            Controls.Add(cBPeriodo);
            Controls.Add(btnGenerador);
            Controls.Add(btnMuestra);
            Controls.Add(cBCurso);
            Controls.Add(label);
            Controls.Add(dataGridViewReportes);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            Name = "FormGenerarReportes";
            Text = "FormGemerarReportes";
            ((System.ComponentModel.ISupportInitialize)dataGridViewReportes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewReportes;
        private DataGridViewCheckBoxColumn Check;
        private DataGridViewTextBoxColumn Informe;
        private Label label;
        private ComboBox cBCurso;
        private Button btnMuestra;
        private Button btnGenerador;
        private ComboBox cBPeriodo;
        private ComboBox cBPago;
        private Button btnAtras;
        private ComboBox cBEspera;
    }
}