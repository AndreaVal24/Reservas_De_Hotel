namespace CapaPresentacion
{
    partial class Form1
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
            btnVolverEmpleado = new Button();
            btnEditarEm = new Button();
            dtpFechasIngresoEm = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // lblEmpleados
            // 
            lblEmpleados.AutoSize = true;
            lblEmpleados.BackColor = Color.Transparent;
            lblEmpleados.Font = new Font("Lucida Calligraphy", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmpleados.Location = new Point(12, 32);
            lblEmpleados.Name = "lblEmpleados";
            lblEmpleados.Size = new Size(413, 36);
            lblEmpleados.TabIndex = 0;
            lblEmpleados.Text = "Empleados Lemon Resort";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(59, 96);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(89, 28);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCedula.Location = new Point(59, 152);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(76, 28);
            lblCedula.TabIndex = 2;
            lblCedula.Text = "Cédula";
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCargo.Location = new Point(59, 210);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(67, 28);
            lblCargo.TabIndex = 3;
            lblCargo.Text = "Cargo";
            // 
            // lblSueldo
            // 
            lblSueldo.AutoSize = true;
            lblSueldo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSueldo.Location = new Point(59, 264);
            lblSueldo.Name = "lblSueldo";
            lblSueldo.Size = new Size(76, 28);
            lblSueldo.TabIndex = 4;
            lblSueldo.Text = "Sueldo";
            // 
            // lblFechaIngreso
            // 
            lblFechaIngreso.AutoSize = true;
            lblFechaIngreso.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaIngreso.Location = new Point(59, 326);
            lblFechaIngreso.Name = "lblFechaIngreso";
            lblFechaIngreso.Size = new Size(171, 28);
            lblFechaIngreso.TabIndex = 5;
            lblFechaIngreso.Text = "Fecha de Ingreso";
            // 
            // btnAgregarEmpleado
            // 
            btnAgregarEmpleado.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarEmpleado.Location = new Point(96, 469);
            btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            btnAgregarEmpleado.Size = new Size(281, 34);
            btnAgregarEmpleado.TabIndex = 6;
            btnAgregarEmpleado.Text = "Agregar Empleado";
            btnAgregarEmpleado.UseVisualStyleBackColor = true;
            btnAgregarEmpleado.Click += btnAgregarEmpleado_Click;
            // 
            // btnEliminarEmpleado
            // 
            btnEliminarEmpleado.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarEmpleado.Location = new Point(912, 381);
            btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            btnEliminarEmpleado.Size = new Size(205, 34);
            btnEliminarEmpleado.TabIndex = 7;
            btnEliminarEmpleado.Text = "Eliminar Empleado";
            btnEliminarEmpleado.UseVisualStyleBackColor = true;
            btnEliminarEmpleado.Click += btnEliminarEmpleado_Click;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.AllowUserToDeleteRows = false;
            dgvEmpleados.AllowUserToResizeColumns = false;
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
            dgvEmpleados.Location = new Point(482, 32);
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
            dgvEmpleados.Size = new Size(894, 343);
            dgvEmpleados.TabIndex = 22;
            dgvEmpleados.CellContentClick += dgvEmpleados_CellContentClick;
            // 
            // txtNombreEm
            // 
            txtNombreEm.Location = new Point(230, 96);
            txtNombreEm.Name = "txtNombreEm";
            txtNombreEm.Size = new Size(211, 31);
            txtNombreEm.TabIndex = 9;
            txtNombreEm.KeyPress += txtNombreEm_KeyPress;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(230, 149);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(211, 31);
            txtCedula.TabIndex = 10;
            txtCedula.KeyPress += txtCedula_KeyPress;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(230, 261);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.ReadOnly = true;
            txtSueldo.Size = new Size(211, 31);
            txtSueldo.TabIndex = 11;
            // 
            // btnCalcularSueldo
            // 
            btnCalcularSueldo.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcularSueldo.Location = new Point(161, 403);
            btnCalcularSueldo.Name = "btnCalcularSueldo";
            btnCalcularSueldo.Size = new Size(174, 34);
            btnCalcularSueldo.TabIndex = 13;
            btnCalcularSueldo.Text = "Calcular Sueldo";
            btnCalcularSueldo.UseVisualStyleBackColor = true;
            btnCalcularSueldo.Click += btnCalcularSueldo_Click;
            // 
            // cbCargo
            // 
            cbCargo.FormattingEnabled = true;
            cbCargo.Location = new Point(228, 205);
            cbCargo.Name = "cbCargo";
            cbCargo.Size = new Size(213, 33);
            cbCargo.TabIndex = 14;
            cbCargo.SelectedIndexChanged += cbCargo_SelectedIndexChanged;
            // 
            // btnVolverEmpleado
            // 
            btnVolverEmpleado.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolverEmpleado.Location = new Point(531, 586);
            btnVolverEmpleado.Name = "btnVolverEmpleado";
            btnVolverEmpleado.Size = new Size(194, 34);
            btnVolverEmpleado.TabIndex = 15;
            btnVolverEmpleado.Text = "Volver al Menu";
            btnVolverEmpleado.UseVisualStyleBackColor = true;
            btnVolverEmpleado.Click += btnVolverEmpleado_Click;
            // 
            // btnEditarEm
            // 
            btnEditarEm.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarEm.Location = new Point(1193, 381);
            btnEditarEm.Name = "btnEditarEm";
            btnEditarEm.Size = new Size(112, 34);
            btnEditarEm.TabIndex = 16;
            btnEditarEm.Text = "Editar";
            btnEditarEm.UseVisualStyleBackColor = true;
            btnEditarEm.Click += btnEditarEm_Click;
            // 
            // dtpFechasIngresoEm
            // 
            dtpFechasIngresoEm.Format = DateTimePickerFormat.Short;
            dtpFechasIngresoEm.Location = new Point(236, 326);
            dtpFechasIngresoEm.Name = "dtpFechasIngresoEm";
            dtpFechasIngresoEm.Size = new Size(205, 31);
            dtpFechasIngresoEm.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.piscina;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1410, 690);
            Controls.Add(dtpFechasIngresoEm);
            Controls.Add(btnEditarEm);
            Controls.Add(btnVolverEmpleado);
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
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
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
        private Button btnVolverEmpleado;
        private Button btnEditarEm;
        private DateTimePicker dtpFechasIngresoEm;
    }
}