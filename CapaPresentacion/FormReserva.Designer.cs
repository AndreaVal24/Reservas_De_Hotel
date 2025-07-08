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
            PictureBox pictureBox1;
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
            btnExportarReservas = new Button();
            txtCorreo = new TextBox();
            lblCorreo = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.piscina;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1694, 624);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // lblHotel
            // 
            lblHotel.AutoSize = true;
            lblHotel.BackColor = Color.Transparent;
            lblHotel.Font = new Font("Lucida Calligraphy", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHotel.Location = new Point(54, 35);
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
            lblCliente.Location = new Point(198, 105);
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
            lblHabitacion.Location = new Point(157, 162);
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
            lblNumeroHabitacion.Location = new Point(34, 213);
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
            lblDiasEstadia.Location = new Point(143, 269);
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
            lblFecha.Location = new Point(209, 328);
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
            btnReservar.Location = new Point(100, 516);
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
            btnTotal.Location = new Point(98, 447);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(183, 40);
            btnTotal.TabIndex = 11;
            btnTotal.Text = "Calcular Total";
            btnTotal.UseVisualStyleBackColor = false;
            btnTotal.Click += btnTotal_Click;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(309, 104);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(182, 31);
            txtCliente.TabIndex = 13;
            txtCliente.KeyPress += txtCliente_KeyPress;
            // 
            // txtNumeroHabitacion
            // 
            txtNumeroHabitacion.Location = new Point(309, 213);
            txtNumeroHabitacion.Name = "txtNumeroHabitacion";
            txtNumeroHabitacion.Size = new Size(182, 31);
            txtNumeroHabitacion.TabIndex = 15;
            txtNumeroHabitacion.KeyPress += txtNumeroHabitacion_KeyPress;
            // 
            // txtDiasEstadia
            // 
            txtDiasEstadia.Location = new Point(309, 268);
            txtDiasEstadia.Name = "txtDiasEstadia";
            txtDiasEstadia.Size = new Size(182, 31);
            txtDiasEstadia.TabIndex = 16;
            txtDiasEstadia.TextChanged += txtDiasEstadia_TextChanged;
            txtDiasEstadia.KeyPress += txtDiasEstadia_KeyPress;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = SystemColors.Window;
            txtTotal.Location = new Point(309, 452);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(182, 31);
            txtTotal.TabIndex = 18;
            // 
            // cbHabitacion
            // 
            cbHabitacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbHabitacion.FormattingEnabled = true;
            cbHabitacion.Location = new Point(309, 160);
            cbHabitacion.Name = "cbHabitacion";
            cbHabitacion.Size = new Size(182, 33);
            cbHabitacion.TabIndex = 19;
            cbHabitacion.SelectedIndexChanged += cbHabitacion_SelectedIndexChanged;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(309, 324);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(182, 31);
            dtpFecha.TabIndex = 21;
            dtpFecha.Value = new DateTime(2025, 7, 8, 12, 52, 54, 0);
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.BackgroundColor = Color.Snow;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkGoldenrod;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkGoldenrod;
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
            dgv.Location = new Point(554, 34);
            dgv.MultiSelect = false;
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
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = Color.Ivory;
            dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgv.Size = new Size(1036, 406);
            dgv.TabIndex = 22;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DarkGoldenrod;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(734, 446);
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
            btnEditarRe.Location = new Point(908, 446);
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
            btnBuscarporfecha.Location = new Point(1243, 544);
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
            dtpHASTA.Location = new Point(1412, 498);
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
            btnMostrartodo.Location = new Point(554, 446);
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
            dtpDESDE.Location = new Point(1243, 498);
            dtpDESDE.Name = "dtpDESDE";
            dtpDESDE.Size = new Size(163, 31);
            dtpDESDE.TabIndex = 29;
            // 
            // btnExportarReservas
            // 
            btnExportarReservas.BackColor = Color.ForestGreen;
            btnExportarReservas.FlatAppearance.BorderSize = 0;
            btnExportarReservas.FlatStyle = FlatStyle.Flat;
            btnExportarReservas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportarReservas.ForeColor = Color.White;
            btnExportarReservas.Location = new Point(1243, 601);
            btnExportarReservas.Name = "btnExportarReservas";
            btnExportarReservas.Size = new Size(337, 40);
            btnExportarReservas.TabIndex = 32;
            btnExportarReservas.Text = "Exportar a Excel";
            btnExportarReservas.UseVisualStyleBackColor = false;
            btnExportarReservas.Click += btnExportarReservas_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(309, 387);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(182, 31);
            txtCorreo.TabIndex = 35;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.BackColor = Color.Transparent;
            lblCorreo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCorreo.Location = new Point(200, 388);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(83, 30);
            lblCorreo.TabIndex = 36;
            lblCorreo.Text = "Correo";
            // 
            // FormEmpleados
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1694, 624);
            Controls.Add(lblCorreo);
            Controls.Add(txtCorreo);
            Controls.Add(btnExportarReservas);
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
            Controls.Add(pictureBox1);
            Name = "FormEmpleados";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Button btnExportarReservas;
        private Label label1;
        private TextBox txtCorreo;
        private Label lblCorreo;
    }
}