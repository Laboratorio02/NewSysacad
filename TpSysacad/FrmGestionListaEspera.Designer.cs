namespace Formularios
{
    partial class FrmGestionListaEspera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionListaEspera));
            dtgvListaEspera = new DataGridView();
            btnVerlista = new Button();
            btnEliminarEstudiante = new Button();
            btnAgregarEstudiante = new Button();
            btnAgregar = new Button();
            btnSalir = new Button();
            label = new Label();
            lblAvisoListavacia = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvListaEspera).BeginInit();
            SuspendLayout();
            // 
            // dtgvListaEspera
            // 
            dtgvListaEspera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgvListaEspera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvListaEspera.Location = new Point(62, 121);
            dtgvListaEspera.Name = "dtgvListaEspera";
            dtgvListaEspera.RowHeadersWidth = 62;
            dtgvListaEspera.RowTemplate.Height = 25;
            dtgvListaEspera.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvListaEspera.Size = new Size(675, 163);
            dtgvListaEspera.TabIndex = 2;
            dtgvListaEspera.CellClick += dtgvListaEspera_CellClick;
            // 
            // btnVerlista
            // 
            btnVerlista.BackColor = Color.FromArgb(255, 255, 128);
            btnVerlista.Location = new Point(298, 304);
            btnVerlista.Name = "btnVerlista";
            btnVerlista.Size = new Size(188, 23);
            btnVerlista.TabIndex = 3;
            btnVerlista.Text = "Consultar Lista de Espera";
            btnVerlista.UseVisualStyleBackColor = false;
            btnVerlista.Click += btnVerlista_Click;
            // 
            // btnEliminarEstudiante
            // 
            btnEliminarEstudiante.BackColor = Color.Brown;
            btnEliminarEstudiante.Location = new Point(579, 304);
            btnEliminarEstudiante.Name = "btnEliminarEstudiante";
            btnEliminarEstudiante.Size = new Size(158, 23);
            btnEliminarEstudiante.TabIndex = 4;
            btnEliminarEstudiante.Text = "Eliminar Estudiante";
            btnEliminarEstudiante.UseVisualStyleBackColor = false;
            btnEliminarEstudiante.Click += btnEliminarEstudiante_Click_1;
            // 
            // btnAgregarEstudiante
            // 
            btnAgregarEstudiante.BackColor = Color.FromArgb(128, 255, 128);
            btnAgregarEstudiante.Location = new Point(62, 304);
            btnAgregarEstudiante.Name = "btnAgregarEstudiante";
            btnAgregarEstudiante.Size = new Size(177, 23);
            btnAgregarEstudiante.TabIndex = 5;
            btnAgregarEstudiante.Text = "Agregar Estudiante";
            btnAgregarEstudiante.UseVisualStyleBackColor = false;
            btnAgregarEstudiante.Click += btnAgregarEstudiante_Click_1;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(192, 255, 192);
            btnAgregar.Location = new Point(309, 370);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(102, 23);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(68, 149, 255);
            btnSalir.Location = new Point(38, 370);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label
            // 
            label.BackColor = Color.FromArgb(68, 149, 255);
            label.Location = new Point(180, 150);
            label.Name = "label";
            label.Size = new Size(264, 83);
            label.TabIndex = 8;
            label.Text = "label";
            label.Visible = false;
            // 
            // lblAvisoListavacia
            // 
            lblAvisoListavacia.BackColor = Color.FromArgb(68, 149, 255);
            lblAvisoListavacia.Location = new Point(180, 150);
            lblAvisoListavacia.Name = "lblAvisoListavacia";
            lblAvisoListavacia.Size = new Size(477, 121);
            lblAvisoListavacia.TabIndex = 9;
            lblAvisoListavacia.Text = "Aviso Lista vacia";
            // 
            // FrmGestionListaEspera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 447);
            Controls.Add(lblAvisoListavacia);
            Controls.Add(label);
            Controls.Add(btnSalir);
            Controls.Add(btnAgregar);
            Controls.Add(btnAgregarEstudiante);
            Controls.Add(btnEliminarEstudiante);
            Controls.Add(btnVerlista);
            Controls.Add(dtgvListaEspera);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmGestionListaEspera";
            Text = "s";
            ((System.ComponentModel.ISupportInitialize)dtgvListaEspera).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dtgvListaEspera;
        private Button btnVerlista;
        private Button btnEliminarEstudiante;
        private Button btnAgregarEstudiante;
        private Button btnAgregar;
        private Button btnSalir;
        private Label label;
        private Label lblAvisoListavacia;
    }
}