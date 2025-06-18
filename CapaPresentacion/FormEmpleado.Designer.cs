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
            txtFechaIngresoEm = new TextBox();
            btnCalcularSueldo = new Button();
            cbCargo = new ComboBox();
            btnVolverEmpleado = new Button();
            btnEditarEm = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // lblEmpleados
            // 
            lblEmpleados.AutoSize = true;
            lblEmpleados.Location = new Point(83, 32);
            lblEmpleados.Name = "lblEmpleados";
            lblEmpleados.Size = new Size(202, 25);
            lblEmpleados.TabIndex = 0;
            lblEmpleados.Text = "Empleados Hotel Limon";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(83, 96);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Location = new Point(83, 152);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(66, 25);
            lblCedula.TabIndex = 2;
            lblCedula.Text = "Cedula";
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(83, 208);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(60, 25);
            lblCargo.TabIndex = 3;
            lblCargo.Text = "Cargo";
            // 
            // lblSueldo
            // 
            lblSueldo.AutoSize = true;
            lblSueldo.Location = new Point(83, 267);
            lblSueldo.Name = "lblSueldo";
            lblSueldo.Size = new Size(67, 25);
            lblSueldo.TabIndex = 4;
            lblSueldo.Text = "Sueldo";
            // 
            // lblFechaIngreso
            // 
            lblFechaIngreso.AutoSize = true;
            lblFechaIngreso.Location = new Point(83, 326);
            lblFechaIngreso.Name = "lblFechaIngreso";
            lblFechaIngreso.Size = new Size(147, 25);
            lblFechaIngreso.TabIndex = 5;
            lblFechaIngreso.Text = "Fecha de Ingreso";
            // 
            // btnAgregarEmpleado
            // 
            btnAgregarEmpleado.Location = new Point(105, 453);
            btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            btnAgregarEmpleado.Size = new Size(281, 34);
            btnAgregarEmpleado.TabIndex = 6;
            btnAgregarEmpleado.Text = "Agregar Empleado";
            btnAgregarEmpleado.UseVisualStyleBackColor = true;
            // 
            // btnEliminarEmpleado
            // 
            btnEliminarEmpleado.Location = new Point(783, 416);
            btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            btnEliminarEmpleado.Size = new Size(205, 34);
            btnEliminarEmpleado.TabIndex = 7;
            btnEliminarEmpleado.Text = "Eliminar Empleado";
            btnEliminarEmpleado.UseVisualStyleBackColor = true;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(445, 32);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 62;
            dgvEmpleados.Size = new Size(776, 343);
            dgvEmpleados.TabIndex = 8;
            // 
            // txtNombreEm
            // 
            txtNombreEm.Location = new Point(198, 96);
            txtNombreEm.Name = "txtNombreEm";
            txtNombreEm.Size = new Size(150, 31);
            txtNombreEm.TabIndex = 9;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(198, 146);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(150, 31);
            txtCedula.TabIndex = 10;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(198, 267);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(150, 31);
            txtSueldo.TabIndex = 11;
            // 
            // txtFechaIngresoEm
            // 
            txtFechaIngresoEm.Location = new Point(236, 326);
            txtFechaIngresoEm.Name = "txtFechaIngresoEm";
            txtFechaIngresoEm.Size = new Size(150, 31);
            txtFechaIngresoEm.TabIndex = 12;
            // 
            // btnCalcularSueldo
            // 
            btnCalcularSueldo.Location = new Point(174, 396);
            btnCalcularSueldo.Name = "btnCalcularSueldo";
            btnCalcularSueldo.Size = new Size(174, 34);
            btnCalcularSueldo.TabIndex = 13;
            btnCalcularSueldo.Text = "Calcular Sueldo";
            btnCalcularSueldo.UseVisualStyleBackColor = true;
            // 
            // cbCargo
            // 
            cbCargo.FormattingEnabled = true;
            cbCargo.Location = new Point(198, 200);
            cbCargo.Name = "cbCargo";
            cbCargo.Size = new Size(182, 33);
            cbCargo.TabIndex = 14;
            // 
            // btnVolverEmpleado
            // 
            btnVolverEmpleado.Location = new Point(531, 586);
            btnVolverEmpleado.Name = "btnVolverEmpleado";
            btnVolverEmpleado.Size = new Size(194, 34);
            btnVolverEmpleado.TabIndex = 15;
            btnVolverEmpleado.Text = "Volver al Menu";
            btnVolverEmpleado.UseVisualStyleBackColor = true;
            // 
            // btnEditarEm
            // 
            btnEditarEm.Location = new Point(1073, 416);
            btnEditarEm.Name = "btnEditarEm";
            btnEditarEm.Size = new Size(112, 34);
            btnEditarEm.TabIndex = 16;
            btnEditarEm.Text = "Editar";
            btnEditarEm.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1287, 690);
            Controls.Add(btnEditarEm);
            Controls.Add(btnVolverEmpleado);
            Controls.Add(cbCargo);
            Controls.Add(btnCalcularSueldo);
            Controls.Add(txtFechaIngresoEm);
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
        private TextBox txtFechaIngresoEm;
        private Button btnCalcularSueldo;
        private ComboBox cbCargo;
        private Button btnVolverEmpleado;
        private Button btnEditarEm;
    }
}