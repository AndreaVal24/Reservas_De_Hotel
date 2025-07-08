namespace CapaPresentacion
{
    partial class FormGraficos
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
            lblEmpleados = new Label();
            lblNombre = new Label();
            lblCedula = new Label();
            lblCargo = new Label();
            lblSueldo = new Label();
            lblFechaIngreso = new Label();
            btnAgregarEmpleado = new Button();
            btnEliminarEmpleado = new Button();
            dgvEmpleados = new DataGridView();
            txtNombreEm = new TextBox();
            txtCedula = new TextBox();
            txtSueldo = new TextBox();
            btnCalcularSueldo = new Button();
            cbCargo = new ComboBox();
            btnEditarEm = new Button();
            dtpFechasIngresoEm = new DateTimePicker();
            btnBuscarporcedula = new Button();
            txtBuscarporcedula = new TextBox();
            btnMostrar = new Button();
            btnExportarEmpleados = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblEmpleados
            // 
            lblEmpleados.AutoSize = true;
            lblEmpleados.BackColor = Color.White;
            lblEmpleados.Font = new Font("Lucida Calligraphy", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmpleados.Location = new Point(59, 34);
            lblEmpleados.Name = "lblEmpleados";
            lblEmpleados.Size = new Size(467, 41);
            lblEmpleados.TabIndex = 0;
            lblEmpleados.Text = "Empleados Lemon Resort";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.White;
            lblNombre.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblNombre.Location = new Point(149, 99);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(98, 30);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.BackColor = Color.White;
            lblCedula.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCedula.Location = new Point(163, 152);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(84, 30);
            lblCedula.TabIndex = 2;
            lblCedula.Text = "Cédula";
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.BackColor = Color.White;
            lblCargo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCargo.Location = new Point(173, 210);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(75, 30);
            lblCargo.TabIndex = 3;
            lblCargo.Text = "Cargo";
            // 
            // lblSueldo
            // 
            lblSueldo.AutoSize = true;
            lblSueldo.BackColor = Color.White;
            lblSueldo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSueldo.Location = new Point(164, 264);
            lblSueldo.Name = "lblSueldo";
            lblSueldo.Size = new Size(83, 30);
            lblSueldo.TabIndex = 4;
            lblSueldo.Text = "Sueldo";
            // 
            // lblFechaIngreso
            // 
            lblFechaIngreso.AutoSize = true;
            lblFechaIngreso.BackColor = Color.White;
            lblFechaIngreso.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblFechaIngreso.Location = new Point(59, 326);
            lblFechaIngreso.Name = "lblFechaIngreso";
            lblFechaIngreso.Size = new Size(188, 30);
            lblFechaIngreso.TabIndex = 5;
            lblFechaIngreso.Text = "Fecha de Ingreso";
            // 
            // btnAgregarEmpleado
            // 
            btnAgregarEmpleado.BackColor = Color.DarkGoldenrod;
            btnAgregarEmpleado.FlatAppearance.BorderSize = 0;
            btnAgregarEmpleado.FlatStyle = FlatStyle.Flat;
            btnAgregarEmpleado.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAgregarEmpleado.ForeColor = Color.White;
            btnAgregarEmpleado.Location = new Point(96, 478);
            btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            btnAgregarEmpleado.Size = new Size(281, 38);
            btnAgregarEmpleado.TabIndex = 6;
            btnAgregarEmpleado.Text = "Agregar Empleado";
            btnAgregarEmpleado.UseVisualStyleBackColor = false;
            btnAgregarEmpleado.Click += btnAgregarEmpleado_Click;
            // 
            // btnEliminarEmpleado
            // 
            btnEliminarEmpleado.BackColor = Color.DarkGoldenrod;
            btnEliminarEmpleado.FlatAppearance.BorderSize = 0;
            btnEliminarEmpleado.FlatStyle = FlatStyle.Flat;
            btnEliminarEmpleado.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            btnEliminarEmpleado.ForeColor = Color.White;
            btnEliminarEmpleado.Location = new Point(811, 381);
            btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            btnEliminarEmpleado.Size = new Size(205, 34);
            btnEliminarEmpleado.TabIndex = 7;
            btnEliminarEmpleado.Text = "Eliminar Empleado";
            btnEliminarEmpleado.UseVisualStyleBackColor = false;
            btnEliminarEmpleado.Click += btnEliminarEmpleado_Click;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.AllowUserToDeleteRows = false;
            dgvEmpleados.AllowUserToResizeColumns = false;
            dgvEmpleados.AllowUserToResizeRows = false;
            dgvEmpleados.BackgroundColor = Color.Snow;
            dgvEmpleados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkGoldenrod;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvEmpleados.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEmpleados.EnableHeadersVisualStyles = false;
            dgvEmpleados.GridColor = Color.Black;
            dgvEmpleados.Location = new Point(573, 32);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LightYellow;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightYellow;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvEmpleados.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = Color.Ivory;
            dgvEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvEmpleados.Size = new Size(963, 343);
            dgvEmpleados.TabIndex = 22;
            dgvEmpleados.CellContentClick += dgvEmpleados_CellContentClick;
            // 
            // txtNombreEm
            // 
            txtNombreEm.Location = new Point(281, 98);
            txtNombreEm.Name = "txtNombreEm";
            txtNombreEm.Size = new Size(223, 31);
            txtNombreEm.TabIndex = 9;
            txtNombreEm.KeyPress += txtNombreEm_KeyPress;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(281, 151);
            txtCedula.MaxLength = 13;
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(223, 31);
            txtCedula.TabIndex = 10;
            txtCedula.KeyPress += txtCedula_KeyPress;
            // 
            // txtSueldo
            // 
            txtSueldo.BackColor = Color.White;
            txtSueldo.Location = new Point(281, 263);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.ReadOnly = true;
            txtSueldo.Size = new Size(223, 31);
            txtSueldo.TabIndex = 11;
            // 
            // btnCalcularSueldo
            // 
            btnCalcularSueldo.BackColor = Color.DarkGoldenrod;
            btnCalcularSueldo.FlatAppearance.BorderSize = 0;
            btnCalcularSueldo.FlatStyle = FlatStyle.Flat;
            btnCalcularSueldo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCalcularSueldo.ForeColor = Color.White;
            btnCalcularSueldo.Location = new Point(96, 404);
            btnCalcularSueldo.Name = "btnCalcularSueldo";
            btnCalcularSueldo.Size = new Size(281, 38);
            btnCalcularSueldo.TabIndex = 13;
            btnCalcularSueldo.Text = "Calcular Sueldo";
            btnCalcularSueldo.UseVisualStyleBackColor = false;
            btnCalcularSueldo.Click += btnCalcularSueldo_Click;
            // 
            // cbCargo
            // 
            cbCargo.FormattingEnabled = true;
            cbCargo.Location = new Point(279, 207);
            cbCargo.Name = "cbCargo";
            cbCargo.Size = new Size(225, 33);
            cbCargo.TabIndex = 14;
            cbCargo.SelectedIndexChanged += cbCargo_SelectedIndexChanged;
            // 
            // btnEditarEm
            // 
            btnEditarEm.BackColor = Color.DarkGoldenrod;
            btnEditarEm.FlatAppearance.BorderSize = 0;
            btnEditarEm.FlatStyle = FlatStyle.Flat;
            btnEditarEm.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            btnEditarEm.ForeColor = Color.White;
            btnEditarEm.Location = new Point(1048, 381);
            btnEditarEm.Name = "btnEditarEm";
            btnEditarEm.Size = new Size(205, 34);
            btnEditarEm.TabIndex = 16;
            btnEditarEm.Text = "Editar";
            btnEditarEm.UseVisualStyleBackColor = false;
            btnEditarEm.Click += btnEditarEm_Click;
            // 
            // dtpFechasIngresoEm
            // 
            dtpFechasIngresoEm.Format = DateTimePickerFormat.Short;
            dtpFechasIngresoEm.Location = new Point(281, 326);
            dtpFechasIngresoEm.Name = "dtpFechasIngresoEm";
            dtpFechasIngresoEm.Size = new Size(223, 31);
            dtpFechasIngresoEm.TabIndex = 17;
            // 
            // btnBuscarporcedula
            // 
            btnBuscarporcedula.BackColor = Color.DarkGoldenrod;
            btnBuscarporcedula.FlatAppearance.BorderSize = 0;
            btnBuscarporcedula.FlatStyle = FlatStyle.Flat;
            btnBuscarporcedula.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarporcedula.ForeColor = Color.White;
            btnBuscarporcedula.Location = new Point(1316, 493);
            btnBuscarporcedula.Name = "btnBuscarporcedula";
            btnBuscarporcedula.Size = new Size(220, 41);
            btnBuscarporcedula.TabIndex = 23;
            btnBuscarporcedula.Text = "Buscar Por Cédula";
            btnBuscarporcedula.UseVisualStyleBackColor = false;
            btnBuscarporcedula.Click += btnBuscarporcedula_Click;
            // 
            // txtBuscarporcedula
            // 
            txtBuscarporcedula.Location = new Point(1316, 454);
            txtBuscarporcedula.Name = "txtBuscarporcedula";
            txtBuscarporcedula.Size = new Size(220, 31);
            txtBuscarporcedula.TabIndex = 24;
            txtBuscarporcedula.KeyPress += txtBuscarporcedula_KeyPress;
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = Color.DarkGoldenrod;
            btnMostrar.FlatAppearance.BorderSize = 0;
            btnMostrar.FlatStyle = FlatStyle.Flat;
            btnMostrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            btnMostrar.ForeColor = Color.White;
            btnMostrar.Location = new Point(574, 381);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(205, 34);
            btnMostrar.TabIndex = 25;
            btnMostrar.Text = "Mostrar Todo";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnExportarEmpleados
            // 
            btnExportarEmpleados.BackColor = Color.ForestGreen;
            btnExportarEmpleados.FlatAppearance.BorderSize = 0;
            btnExportarEmpleados.FlatStyle = FlatStyle.Flat;
            btnExportarEmpleados.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportarEmpleados.ForeColor = Color.White;
            btnExportarEmpleados.Location = new Point(1316, 556);
            btnExportarEmpleados.Name = "btnExportarEmpleados";
            btnExportarEmpleados.Size = new Size(220, 41);
            btnExportarEmpleados.TabIndex = 26;
            btnExportarEmpleados.Text = "Exportar a Excel";
            btnExportarEmpleados.UseVisualStyleBackColor = false;
            btnExportarEmpleados.Click += btnExportarEmpleados_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.piscina;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1647, 690);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // FormGraficos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1647, 690);
            Controls.Add(btnExportarEmpleados);
            Controls.Add(btnMostrar);
            Controls.Add(txtBuscarporcedula);
            Controls.Add(btnBuscarporcedula);
            Controls.Add(dtpFechasIngresoEm);
            Controls.Add(btnEditarEm);
            Controls.Add(cbCargo);
            Controls.Add(btnCalcularSueldo);
            Controls.Add(txtSueldo);
            Controls.Add(txtCedula);
            Controls.Add(txtNombreEm);
            Controls.Add(dgvEmpleados);
            Controls.Add(btnEliminarEmpleado);
            Controls.Add(btnAgregarEmpleado);
            Controls.Add(lblFechaIngreso);
            Controls.Add(lblSueldo);
            Controls.Add(lblCargo);
            Controls.Add(lblCedula);
            Controls.Add(lblNombre);
            Controls.Add(lblEmpleados);
            Controls.Add(pictureBox1);
            Name = "FormGraficos";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmpleados;
        private Label lblNombre;
        private Label lblCedula;
        private Label lblCargo;
        private Label lblSueldo;
        private Label lblFechaIngreso;
        private Button btnAgregarEmpleado;
        private Button btnEliminarEmpleado;
        private DataGridView dgvEmpleados;
        private TextBox txtNombreEm;
        private TextBox txtCedula;
        private TextBox txtSueldo;
        private Button btnCalcularSueldo;
        private ComboBox cbCargo;
        private Button btnEditarEm;
        private DateTimePicker dtpFechasIngresoEm;
        private Button btnBuscarporcedula;
        private TextBox txtBuscarporcedula;
        private Button btnMostrar;
        private Button btnExportarEmpleados;
        private PictureBox pictureBox1;
    }
}