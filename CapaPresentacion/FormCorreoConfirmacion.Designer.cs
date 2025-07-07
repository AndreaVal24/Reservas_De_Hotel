namespace CapaPresentacion
{
    partial class FormCorreoReservas
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvConfirmaciones = new DataGridView();
            btnEnviarCorreo = new Button();
            lblTituloConfirmaciones = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvConfirmaciones).BeginInit();
            SuspendLayout();
            // 
            // dgvConfirmaciones
            // 
            dgvConfirmaciones.AllowUserToAddRows = false;
            dgvConfirmaciones.AllowUserToDeleteRows = false;
            dgvConfirmaciones.AllowUserToResizeColumns = false;
            dgvConfirmaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvConfirmaciones.BackgroundColor = Color.Snow;
            dgvConfirmaciones.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkGoldenrod;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvConfirmaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvConfirmaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvConfirmaciones.DefaultCellStyle = dataGridViewCellStyle2;
            dgvConfirmaciones.EnableHeadersVisualStyles = false;
            dgvConfirmaciones.GridColor = Color.Black;
            dgvConfirmaciones.Location = new Point(211, 114);
            dgvConfirmaciones.Name = "dgvConfirmaciones";
            dgvConfirmaciones.ReadOnly = true;
            dgvConfirmaciones.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LightYellow;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightYellow;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvConfirmaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvConfirmaciones.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = Color.Ivory;
            dgvConfirmaciones.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvConfirmaciones.Size = new Size(1257, 441);
            dgvConfirmaciones.TabIndex = 22;
            dgvConfirmaciones.CellContentClick += dgvConfirmaciones_CellContentClick;
            // 
            // btnEnviarCorreo
            // 
            btnEnviarCorreo.BackColor = Color.DarkGoldenrod;
            btnEnviarCorreo.FlatStyle = FlatStyle.Flat;
            btnEnviarCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnviarCorreo.ForeColor = Color.White;
            btnEnviarCorreo.Location = new Point(603, 592);
            btnEnviarCorreo.Name = "btnEnviarCorreo";
            btnEnviarCorreo.Size = new Size(422, 58);
            btnEnviarCorreo.TabIndex = 1;
            btnEnviarCorreo.Text = "Enviar Correo de Confirmación";
            btnEnviarCorreo.UseVisualStyleBackColor = false;
            btnEnviarCorreo.Click += btnEnviarCorreo_Click;
            // 
            // lblTituloConfirmaciones
            // 
            lblTituloConfirmaciones.AutoSize = true;
            lblTituloConfirmaciones.Font = new Font("Lucida Calligraphy", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloConfirmaciones.Location = new Point(498, 42);
            lblTituloConfirmaciones.Name = "lblTituloConfirmaciones";
            lblTituloConfirmaciones.Size = new Size(724, 41);
            lblTituloConfirmaciones.TabIndex = 23;
            lblTituloConfirmaciones.Text = "Confirmaciones de Reservas Pendientes";
            lblTituloConfirmaciones.Click += lblTituloConfirmaciones_Click;
            // 
            // FormCorreoReservas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(1719, 679);
            Controls.Add(lblTituloConfirmaciones);
            Controls.Add(btnEnviarCorreo);
            Controls.Add(dgvConfirmaciones);
            Name = "FormCorreoReservas";
            Text = "FormEstadisticas";
            Load += FormEstadisticas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConfirmaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvConfirmaciones;
        private Button btnEnviarCorreo;
        private Label lblTituloConfirmaciones;
    }
}