namespace CapaPresentacion
{
    partial class FormEmpleados
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
            lblHotel = new Label();
            lblCliente = new Label();
            lblHabitacion = new Label();
            lblNumeroHabitacion = new Label();
            lblDiasEstadia = new Label();
            lblFecha = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnReservar = new Button();
            btnTotal = new Button();
            txtCliente = new TextBox();
            txtNumeroHabitacion = new TextBox();
            txtDiasEstadia = new TextBox();
            txtTotal = new TextBox();
            cbHabitacion = new ComboBox();
            dtpFecha = new DateTimePicker();
            dgv = new DataGridView();
            btnEliminar = new Button();
            btnEditarRe = new Button();
            btnBuscarporfecha = new Button();
            dtpHASTA = new DateTimePicker();
            btnMostrartodo = new Button();
            dtpDESDE = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // lblHotel
            // 
            lblHotel.AutoSize = true;
            lblHotel.BackColor = Color.Transparent;
            lblHotel.Font = new Font("Lucida Calligraphy", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHotel.Location = new Point(54, 19);
            lblHotel.Name = "lblHotel";
            lblHotel.Size = new Size(437, 41);
            lblHotel.TabIndex = 0;
            lblHotel.Text = "Reservas Lemon Resort";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.BackColor = Color.Transparent;
            lblCliente.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCliente.Location = new Point(197, 90);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(85, 30);
            lblCliente.TabIndex = 2;
            lblCliente.Text = "Cliente";
            // 
            // lblHabitacion
            // 
            lblHabitacion.AutoSize = true;
            lblHabitacion.BackColor = Color.Transparent;
            lblHabitacion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblHabitacion.Location = new Point(157, 146);
            lblHabitacion.Name = "lblHabitacion";
            lblHabitacion.Size = new Size(126, 30);
            lblHabitacion.TabIndex = 3;
            lblHabitacion.Text = "Habitación";
            // 
            // lblNumeroHabitacion
            // 
            lblNumeroHabitacion.AutoSize = true;
            lblNumeroHabitacion.BackColor = Color.Transparent;
            lblNumeroHabitacion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblNumeroHabitacion.Location = new Point(38, 202);
            lblNumeroHabitacion.Name = "lblNumeroHabitacion";
            lblNumeroHabitacion.Size = new Size(248, 30);
            lblNumeroHabitacion.TabIndex = 4;
            lblNumeroHabitacion.Text = "Número de Habitación";
            // 
            // lblDiasEstadia
            // 
            lblDiasEstadia.AutoSize = true;
            lblDiasEstadia.BackColor = Color.Transparent;
            lblDiasEstadia.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDiasEstadia.Location = new Point(143, 253);
            lblDiasEstadia.Name = "lblDiasEstadia";
            lblDiasEstadia.Size = new Size(138, 30);
            lblDiasEstadia.TabIndex = 5;
            lblDiasEstadia.Text = "Días Estadía";
            lblDiasEstadia.Click += label6_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblFecha.Location = new Point(209, 312);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(72, 30);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "Fecha";
            // 
            // btnReservar
            // 
            btnReservar.BackColor = Color.DarkGoldenrod;
            btnReservar.FlatAppearance.BorderSize = 0;
            btnReservar.FlatStyle = FlatStyle.Flat;
            btnReservar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnReservar.ForeColor = Color.White;
            btnReservar.Location = new Point(100, 445);
            btnReservar.Name = "btnReservar";
            btnReservar.Size = new Size(181, 40);
            btnReservar.TabIndex = 10;
            btnReservar.Text = "Guardar Reserva";
            btnReservar.UseVisualStyleBackColor = false;
            btnReservar.Click += btnReservar_Click;
            // 
            // btnTotal
            // 
            btnTotal.BackColor = Color.DarkGoldenrod;
            btnTotal.FlatAppearance.BorderSize = 0;
            btnTotal.FlatStyle = FlatStyle.Flat;
            btnTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTotal.ForeColor = Color.White;
            btnTotal.Location = new Point(100, 371);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(183, 40);
            btnTotal.TabIndex = 11;
            btnTotal.Text = "Calcular Total";
            btnTotal.UseVisualStyleBackColor = false;
            btnTotal.Click += btnTotal_Click;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(309, 88);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(182, 31);
            txtCliente.TabIndex = 13;
            txtCliente.KeyPress += txtCliente_KeyPress;
            // 
            // txtNumeroHabitacion
            // 
            txtNumeroHabitacion.Location = new Point(309, 197);
            txtNumeroHabitacion.Name = "txtNumeroHabitacion";
            txtNumeroHabitacion.Size = new Size(182, 31);
            txtNumeroHabitacion.TabIndex = 15;
            txtNumeroHabitacion.KeyPress += txtNumeroHabitacion_KeyPress;
            // 
            // txtDiasEstadia
            // 
            txtDiasEstadia.Location = new Point(309, 248);
            txtDiasEstadia.Name = "txtDiasEstadia";
            txtDiasEstadia.Size = new Size(182, 31);
            txtDiasEstadia.TabIndex = 16;
            txtDiasEstadia.TextChanged += txtDiasEstadia_TextChanged;
            txtDiasEstadia.KeyPress += txtDiasEstadia_KeyPress;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(309, 371);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(182, 31);
            txtTotal.TabIndex = 18;
            // 
            // cbHabitacion
            // 
            cbHabitacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbHabitacion.FormattingEnabled = true;
            cbHabitacion.Location = new Point(309, 144);
            cbHabitacion.Name = "cbHabitacion";
            cbHabitacion.Size = new Size(182, 33);
            cbHabitacion.TabIndex = 19;
            cbHabitacion.SelectedIndexChanged += cbHabitacion_SelectedIndexChanged;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(309, 302);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(182, 31);
            dtpFecha.TabIndex = 21;
            dtpFecha.Value = new DateTime(2025, 5, 31, 11, 22, 7, 0);
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.BackgroundColor = Color.Snow;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkGoldenrod;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle2;
            dgv.EnableHeadersVisualStyles = false;
            dgv.GridColor = Color.Black;
            dgv.Location = new Point(525, 34);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LightYellow;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightYellow;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = Color.Ivory;
            dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgv.Size = new Size(1034, 371);
            dgv.TabIndex = 22;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DarkGoldenrod;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(705, 417);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(149, 39);
            btnEliminar.TabIndex = 23;
            btnEliminar.Text = "Eliminar Reserva";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditarRe
            // 
            btnEditarRe.BackColor = Color.DarkGoldenrod;
            btnEditarRe.FlatAppearance.BorderSize = 0;
            btnEditarRe.FlatStyle = FlatStyle.Flat;
            btnEditarRe.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnEditarRe.ForeColor = Color.White;
            btnEditarRe.Location = new Point(879, 417);
            btnEditarRe.Name = "btnEditarRe";
            btnEditarRe.Size = new Size(149, 41);
            btnEditarRe.TabIndex = 25;
            btnEditarRe.Text = "Editar";
            btnEditarRe.UseVisualStyleBackColor = false;
            btnEditarRe.Click += btnEditarRe_Click;
            // 
            // btnBuscarporfecha
            // 
            btnBuscarporfecha.BackColor = Color.DarkGoldenrod;
            btnBuscarporfecha.FlatAppearance.BorderSize = 0;
            btnBuscarporfecha.FlatStyle = FlatStyle.Flat;
            btnBuscarporfecha.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBuscarporfecha.ForeColor = Color.White;
            btnBuscarporfecha.Location = new Point(1310, 500);
            btnBuscarporfecha.Name = "btnBuscarporfecha";
            btnBuscarporfecha.Size = new Size(337, 40);
            btnBuscarporfecha.TabIndex = 28;
            btnBuscarporfecha.Text = "Buscar Reserva por Fecha";
            btnBuscarporfecha.UseVisualStyleBackColor = false;
            btnBuscarporfecha.Click += btnBuscarporfecha_Click;
            // 
            // dtpHASTA
            // 
            dtpHASTA.Format = DateTimePickerFormat.Short;
            dtpHASTA.Location = new Point(1479, 454);
            dtpHASTA.Name = "dtpHASTA";
            dtpHASTA.Size = new Size(168, 31);
            dtpHASTA.TabIndex = 30;
            // 
            // btnMostrartodo
            // 
            btnMostrartodo.BackColor = Color.DarkGoldenrod;
            btnMostrartodo.FlatAppearance.BorderSize = 0;
            btnMostrartodo.FlatStyle = FlatStyle.Flat;
            btnMostrartodo.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnMostrartodo.ForeColor = Color.White;
            btnMostrartodo.Location = new Point(525, 417);
            btnMostrartodo.Name = "btnMostrartodo";
            btnMostrartodo.Size = new Size(152, 39);
            btnMostrartodo.TabIndex = 31;
            btnMostrartodo.Text = "Mostrar Todo";
            btnMostrartodo.UseVisualStyleBackColor = false;
            btnMostrartodo.Click += btnMostrartodo_Click;
            // 
            // dtpDESDE
            // 
            dtpDESDE.Format = DateTimePickerFormat.Short;
            dtpDESDE.Location = new Point(1310, 454);
            dtpDESDE.Name = "dtpDESDE";
            dtpDESDE.Size = new Size(163, 31);
            dtpDESDE.TabIndex = 29;
            // 
            // FormEmpleados
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            BackgroundImage = Properties.Resources.piscina;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1694, 624);
            Controls.Add(btnMostrartodo);
            Controls.Add(dtpHASTA);
            Controls.Add(dtpDESDE);
            Controls.Add(btnBuscarporfecha);
            Controls.Add(btnEditarRe);
            Controls.Add(btnEliminar);
            Controls.Add(dgv);
            Controls.Add(dtpFecha);
            Controls.Add(cbHabitacion);
            Controls.Add(txtTotal);
            Controls.Add(txtDiasEstadia);
            Controls.Add(txtNumeroHabitacion);
            Controls.Add(txtCliente);
            Controls.Add(btnTotal);
            Controls.Add(btnReservar);
            Controls.Add(lblFecha);
            Controls.Add(lblDiasEstadia);
            Controls.Add(lblNumeroHabitacion);
            Controls.Add(lblHabitacion);
            Controls.Add(lblCliente);
            Controls.Add(lblHotel);
            Name = "FormEmpleados";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHotel;
        private Label lblCliente;
        private Label lblHabitacion;
        private Label lblNumeroHabitacion;
        private Label lblDiasEstadia;
        private Label lblFecha;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnReservar;
        private Button btnTotal;
        private TextBox txtCliente;
        private TextBox txtNumeroHabitacion;
        private TextBox txtDiasEstadia;
        private TextBox txtTotal;
        private ComboBox cbHabitacion;
        private DateTimePicker dtpFecha;
        private DataGridView dgv;
        private Button btnEliminar;
        private Button btnEditarRe;
        private Button btnBuscarporfecha;
        private DateTimePicker dtpHASTA;
        private Button btnMostrartodo;
        private DateTimePicker dtpDESDE;
    }
}