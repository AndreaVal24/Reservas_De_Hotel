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
            btnVolverReservas = new Button();
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
            lblHotel.Font = new Font("Lucida Calligraphy", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHotel.Location = new Point(114, 34);
            lblHotel.Name = "lblHotel";
            lblHotel.Size = new Size(387, 36);
            lblHotel.TabIndex = 0;
            lblHotel.Text = "Reservas Lemon Resort";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.BackColor = Color.Transparent;
            lblCliente.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.Location = new Point(197, 90);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(86, 26);
            lblCliente.TabIndex = 2;
            lblCliente.Text = "Cliente";
            // 
            // lblHabitacion
            // 
            lblHabitacion.AutoSize = true;
            lblHabitacion.BackColor = Color.Transparent;
            lblHabitacion.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHabitacion.Location = new Point(157, 146);
            lblHabitacion.Name = "lblHabitacion";
            lblHabitacion.Size = new Size(126, 26);
            lblHabitacion.TabIndex = 3;
            lblHabitacion.Text = "Habitación";
            // 
            // lblNumeroHabitacion
            // 
            lblNumeroHabitacion.AutoSize = true;
            lblNumeroHabitacion.BackColor = Color.Transparent;
            lblNumeroHabitacion.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumeroHabitacion.Location = new Point(38, 202);
            lblNumeroHabitacion.Name = "lblNumeroHabitacion";
            lblNumeroHabitacion.Size = new Size(245, 26);
            lblNumeroHabitacion.TabIndex = 4;
            lblNumeroHabitacion.Text = "Número de Habitación";
            // 
            // lblDiasEstadia
            // 
            lblDiasEstadia.AutoSize = true;
            lblDiasEstadia.BackColor = Color.Transparent;
            lblDiasEstadia.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiasEstadia.Location = new Point(143, 253);
            lblDiasEstadia.Name = "lblDiasEstadia";
            lblDiasEstadia.Size = new Size(140, 26);
            lblDiasEstadia.TabIndex = 5;
            lblDiasEstadia.Text = "Días Estadía";
            lblDiasEstadia.Click += label6_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(209, 312);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(74, 26);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "Fecha";
            // 
            // btnReservar
            // 
            btnReservar.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReservar.ForeColor = Color.DarkGoldenrod;
            btnReservar.Location = new Point(197, 450);
            btnReservar.Name = "btnReservar";
            btnReservar.Size = new Size(191, 34);
            btnReservar.TabIndex = 10;
            btnReservar.Text = "Guardar Reserva";
            btnReservar.UseVisualStyleBackColor = true;
            btnReservar.Click += btnReservar_Click;
            // 
            // btnTotal
            // 
            btnTotal.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTotal.ForeColor = Color.DarkGoldenrod;
            btnTotal.Location = new Point(100, 371);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(183, 34);
            btnTotal.TabIndex = 11;
            btnTotal.Text = "Calcular Total";
            btnTotal.UseVisualStyleBackColor = true;
            btnTotal.Click += btnTotal_Click;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(309, 88);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(150, 31);
            txtCliente.TabIndex = 13;
            txtCliente.KeyPress += txtCliente_KeyPress;
            // 
            // txtNumeroHabitacion
            // 
            txtNumeroHabitacion.Location = new Point(309, 197);
            txtNumeroHabitacion.Name = "txtNumeroHabitacion";
            txtNumeroHabitacion.Size = new Size(150, 31);
            txtNumeroHabitacion.TabIndex = 15;
            txtNumeroHabitacion.KeyPress += txtNumeroHabitacion_KeyPress;
            // 
            // txtDiasEstadia
            // 
            txtDiasEstadia.Location = new Point(309, 248);
            txtDiasEstadia.Name = "txtDiasEstadia";
            txtDiasEstadia.Size = new Size(150, 31);
            txtDiasEstadia.TabIndex = 16;
            txtDiasEstadia.TextChanged += txtDiasEstadia_TextChanged;
            txtDiasEstadia.KeyPress += txtDiasEstadia_KeyPress;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(309, 371);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(150, 31);
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
            dtpFecha.Size = new Size(150, 31);
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
            dataGridViewCellStyle1.Font = new Font("Calisto MT", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            dgv.Size = new Size(876, 340);
            dgv.TabIndex = 22;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.DarkGoldenrod;
            btnEliminar.Location = new Point(986, 380);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(198, 34);
            btnEliminar.TabIndex = 23;
            btnEliminar.Text = "Eliminar Reserva";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVolverReservas
            // 
            btnVolverReservas.BackgroundImageLayout = ImageLayout.None;
            btnVolverReservas.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolverReservas.Location = new Point(197, 559);
            btnVolverReservas.Name = "btnVolverReservas";
            btnVolverReservas.Size = new Size(195, 34);
            btnVolverReservas.TabIndex = 24;
            btnVolverReservas.Text = "Volver al Menu";
            btnVolverReservas.UseVisualStyleBackColor = true;
            btnVolverReservas.Click += btnVolverReservas_Click;
            // 
            // btnEditarRe
            // 
            btnEditarRe.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarRe.ForeColor = Color.DarkGoldenrod;
            btnEditarRe.Location = new Point(1224, 380);
            btnEditarRe.Name = "btnEditarRe";
            btnEditarRe.Size = new Size(112, 34);
            btnEditarRe.TabIndex = 25;
            btnEditarRe.Text = "Editar";
            btnEditarRe.UseVisualStyleBackColor = true;
            btnEditarRe.Click += btnEditarRe_Click;
            // 
            // btnBuscarporfecha
            // 
            btnBuscarporfecha.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarporfecha.ForeColor = Color.DarkGoldenrod;
            btnBuscarporfecha.Location = new Point(797, 530);
            btnBuscarporfecha.Name = "btnBuscarporfecha";
            btnBuscarporfecha.Size = new Size(286, 34);
            btnBuscarporfecha.TabIndex = 28;
            btnBuscarporfecha.Text = "Buscar Reserva por Fecha";
            btnBuscarporfecha.UseVisualStyleBackColor = true;
            btnBuscarporfecha.Click += btnBuscarporfecha_Click;
            // 
            // dtpHASTA
            // 
            dtpHASTA.Format = DateTimePickerFormat.Short;
            dtpHASTA.Location = new Point(950, 485);
            dtpHASTA.Name = "dtpHASTA";
            dtpHASTA.Size = new Size(133, 31);
            dtpHASTA.TabIndex = 30;
            // 
            // btnMostrartodo
            // 
            btnMostrartodo.Font = new Font("Times New Roman", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnMostrartodo.ForeColor = Color.DarkSlateGray;
            btnMostrartodo.Location = new Point(525, 380);
            btnMostrartodo.Name = "btnMostrartodo";
            btnMostrartodo.Size = new Size(168, 34);
            btnMostrartodo.TabIndex = 31;
            btnMostrartodo.Text = "Mostrar Todo";
            btnMostrartodo.UseVisualStyleBackColor = true;
            btnMostrartodo.Click += btnMostrartodo_Click;
            // 
            // dtpDESDE
            // 
            dtpDESDE.Format = DateTimePickerFormat.Short;
            dtpDESDE.Location = new Point(797, 486);
            dtpDESDE.Name = "dtpDESDE";
            dtpDESDE.Size = new Size(133, 31);
            dtpDESDE.TabIndex = 29;
            // 
            // FormEmpleados
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2025_05_31_at_17_04_16_73714994;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1426, 624);
            Controls.Add(btnMostrartodo);
            Controls.Add(dtpHASTA);
            Controls.Add(dtpDESDE);
            Controls.Add(btnBuscarporfecha);
            Controls.Add(btnEditarRe);
            Controls.Add(btnVolverReservas);
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
            Text = "Form1";
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
        private Button btnVolverReservas;
        private Button btnEditarRe;
        private Button btnBuscarporfecha;
        private DateTimePicker dtpHASTA;
        private Button btnMostrartodo;
        private DateTimePicker dtpDESDE;
    }
}