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
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // lblHotel
            // 
            lblHotel.AutoSize = true;
            lblHotel.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHotel.Location = new Point(114, 34);
            lblHotel.Name = "lblHotel";
            lblHotel.Size = new Size(278, 32);
            lblHotel.TabIndex = 0;
            lblHotel.Text = "Reservas Hotel Limon";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
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
            lblHabitacion.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHabitacion.Location = new Point(157, 146);
            lblHabitacion.Name = "lblHabitacion";
            lblHabitacion.Size = new Size(126, 26);
            lblHabitacion.TabIndex = 3;
            lblHabitacion.Text = "Habitacion";
            // 
            // lblNumeroHabitacion
            // 
            lblNumeroHabitacion.AutoSize = true;
            lblNumeroHabitacion.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumeroHabitacion.Location = new Point(38, 202);
            lblNumeroHabitacion.Name = "lblNumeroHabitacion";
            lblNumeroHabitacion.Size = new Size(245, 26);
            lblNumeroHabitacion.TabIndex = 4;
            lblNumeroHabitacion.Text = "Numero de Habitacion";
            // 
            // lblDiasEstadia
            // 
            lblDiasEstadia.AutoSize = true;
            lblDiasEstadia.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiasEstadia.Location = new Point(143, 253);
            lblDiasEstadia.Name = "lblDiasEstadia";
            lblDiasEstadia.Size = new Size(140, 26);
            lblDiasEstadia.TabIndex = 5;
            lblDiasEstadia.Text = "Dias Estadia";
            lblDiasEstadia.Click += label6_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
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
            btnReservar.ForeColor = Color.DarkRed;
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
            btnTotal.ForeColor = Color.DarkRed;
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
            // 
            // txtDiasEstadia
            // 
            txtDiasEstadia.Location = new Point(309, 248);
            txtDiasEstadia.Name = "txtDiasEstadia";
            txtDiasEstadia.Size = new Size(150, 31);
            txtDiasEstadia.TabIndex = 16;
            txtDiasEstadia.TextChanged += txtDiasEstadia_TextChanged;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(309, 371);
            txtTotal.Name = "txtTotal";
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
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Navy;
            dataGridViewCellStyle1.Font = new Font("Calisto MT", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.EnableHeadersVisualStyles = false;
            dgv.Location = new Point(525, 34);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersWidth = 62;
            dgv.Size = new Size(807, 413);
            dgv.TabIndex = 22;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.DarkRed;
            btnEliminar.Location = new Point(894, 466);
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
            btnVolverReservas.Location = new Point(563, 539);
            btnVolverReservas.Name = "btnVolverReservas";
            btnVolverReservas.Size = new Size(195, 34);
            btnVolverReservas.TabIndex = 24;
            btnVolverReservas.Text = "Volver al Menu";
            btnVolverReservas.UseVisualStyleBackColor = true;
            btnVolverReservas.Click += btnVolverReservas_Click;
            // 
            // btnEditarRe
            // 
            btnEditarRe.Location = new Point(1170, 466);
            btnEditarRe.Name = "btnEditarRe";
            btnEditarRe.Size = new Size(112, 34);
            btnEditarRe.TabIndex = 25;
            btnEditarRe.Text = "Editar";
            btnEditarRe.UseVisualStyleBackColor = true;
            btnEditarRe.Click += btnEditarRe_Click;
            // 
            // FormEmpleados
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2025_05_31_at_17_04_16_73714994;
            ClientSize = new Size(1344, 585);
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
    }
}