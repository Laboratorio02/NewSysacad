namespace Formularios
{
    partial class FormConsultarHorario
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultarHorario));
            dataGridViewHorario = new DataGridView();
            dias = new DataGridViewTextBoxColumn();
            turnoManiana = new DataGridViewTextBoxColumn();
            turnoTarde = new DataGridViewTextBoxColumn();
            turnoNoche = new DataGridViewTextBoxColumn();
            labelHorario = new Label();
            label1 = new Label();
            labelHorarioVacio = new Label();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHorario).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewHorario
            // 
            dataGridViewHorario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewHorario.BackgroundColor = Color.Gray;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 64, 64);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewHorario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewHorario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHorario.Columns.AddRange(new DataGridViewColumn[] { dias, turnoManiana, turnoTarde, turnoNoche });
            dataGridViewHorario.GridColor = SystemColors.ControlDarkDark;
            dataGridViewHorario.Location = new Point(84, 84);
            dataGridViewHorario.Margin = new Padding(3, 2, 3, 2);
            dataGridViewHorario.Name = "dataGridViewHorario";
            dataGridViewHorario.RowHeadersWidth = 51;
            dataGridViewHorario.RowTemplate.Height = 29;
            dataGridViewHorario.Size = new Size(671, 301);
            dataGridViewHorario.TabIndex = 0;
            dataGridViewHorario.CellContentClick += dataGridViewHorario_CellContentClick;
            // 
            // dias
            // 
            dias.HeaderText = "Materia";
            dias.MinimumWidth = 6;
            dias.Name = "dias";
            dias.ReadOnly = true;
            dias.Width = 125;
            // 
            // turnoManiana
            // 
            turnoManiana.HeaderText = "Turno";
            turnoManiana.MinimumWidth = 6;
            turnoManiana.Name = "turnoManiana";
            turnoManiana.ReadOnly = true;
            turnoManiana.Width = 170;
            // 
            // turnoTarde
            // 
            turnoTarde.HeaderText = "Día";
            turnoTarde.MinimumWidth = 6;
            turnoTarde.Name = "turnoTarde";
            turnoTarde.ReadOnly = true;
            turnoTarde.Width = 170;
            // 
            // turnoNoche
            // 
            turnoNoche.HeaderText = "Aula";
            turnoNoche.MinimumWidth = 6;
            turnoNoche.Name = "turnoNoche";
            turnoNoche.ReadOnly = true;
            turnoNoche.Width = 170;
            // 
            // labelHorario
            // 
            labelHorario.AutoSize = true;
            labelHorario.Location = new Point(403, 41);
            labelHorario.Name = "labelHorario";
            labelHorario.Size = new Size(97, 15);
            labelHorario.TabIndex = 1;
            labelHorario.Text = "Horario de clases";
            labelHorario.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 50);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            // 
            // labelHorarioVacio
            // 
            labelHorarioVacio.AutoSize = true;
            labelHorarioVacio.BackColor = Color.FromArgb(128, 255, 255);
            labelHorarioVacio.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelHorarioVacio.ForeColor = Color.Black;
            labelHorarioVacio.Location = new Point(89, 164);
            labelHorarioVacio.Name = "labelHorarioVacio";
            labelHorarioVacio.Size = new Size(482, 25);
            labelHorarioVacio.TabIndex = 3;
            labelHorarioVacio.Text = "No estás inscrito en ningún curso. Tu horario está vacío.";
            labelHorarioVacio.TextAlign = ContentAlignment.MiddleCenter;
            labelHorarioVacio.Click += labelHorarioVacio_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Orange;
            btnVolver.ForeColor = Color.Black;
            btnVolver.Location = new Point(262, 303);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(127, 23);
            btnVolver.TabIndex = 12;
            btnVolver.TabStop = false;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormConsultarHorario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(808, 481);
            Controls.Add(btnVolver);
            Controls.Add(labelHorarioVacio);
            Controls.Add(label1);
            Controls.Add(labelHorario);
            Controls.Add(dataGridViewHorario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConsultarHorario";
            Text = "FormConsultarHorario";
            Load += FormConsultarHorario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewHorario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewHorario;
        private Label labelHorario;
        private Label label1;
        private Label labelHorarioVacio;
        private DataGridViewTextBoxColumn dias;
        private DataGridViewTextBoxColumn turnoManiana;
        private DataGridViewTextBoxColumn turnoTarde;
        private DataGridViewTextBoxColumn turnoNoche;
        private Button btnVolver;
    }
}