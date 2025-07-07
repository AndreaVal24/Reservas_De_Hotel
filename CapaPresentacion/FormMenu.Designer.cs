namespace CapaPresentacion
{
    partial class Form2
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
            panelContenido = new Panel();
            iconbtnConfirmaciones = new FontAwesome.Sharp.IconButton();
            iconbtnSalir = new FontAwesome.Sharp.IconButton();
            iconbtnEmpleado = new FontAwesome.Sharp.IconButton();
            iconbtnReservas = new FontAwesome.Sharp.IconButton();
            panellogoesquina = new Panel();
            pbinicio = new PictureBox();
            panelBarrasuperior = new Panel();
            lblHome = new Label();
            iconBarra = new FontAwesome.Sharp.IconPictureBox();
            iconlogocentro = new FontAwesome.Sharp.IconPictureBox();
            panelFORMULARIOS = new Panel();
            panelContenido.SuspendLayout();
            panellogoesquina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbinicio).BeginInit();
            panelBarrasuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconBarra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconlogocentro).BeginInit();
            panelFORMULARIOS.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenido
            // 
            panelContenido.BackColor = Color.DarkGoldenrod;
            panelContenido.Controls.Add(iconbtnConfirmaciones);
            panelContenido.Controls.Add(iconbtnSalir);
            panelContenido.Controls.Add(iconbtnEmpleado);
            panelContenido.Controls.Add(iconbtnReservas);
            panelContenido.Controls.Add(panellogoesquina);
            panelContenido.Dock = DockStyle.Left;
            panelContenido.Location = new Point(0, 0);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(253, 727);
            panelContenido.TabIndex = 12;
            // 
            // iconbtnConfirmaciones
            // 
            iconbtnConfirmaciones.Dock = DockStyle.Top;
            iconbtnConfirmaciones.FlatAppearance.BorderSize = 0;
            iconbtnConfirmaciones.FlatStyle = FlatStyle.Flat;
            iconbtnConfirmaciones.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconbtnConfirmaciones.ForeColor = Color.Gainsboro;
            iconbtnConfirmaciones.IconChar = FontAwesome.Sharp.IconChar.MailReplyAll;
            iconbtnConfirmaciones.IconColor = Color.Gainsboro;
            iconbtnConfirmaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnConfirmaciones.IconSize = 32;
            iconbtnConfirmaciones.ImageAlign = ContentAlignment.MiddleLeft;
            iconbtnConfirmaciones.Location = new Point(0, 380);
            iconbtnConfirmaciones.Name = "iconbtnConfirmaciones";
            iconbtnConfirmaciones.Padding = new Padding(10, 0, 20, 0);
            iconbtnConfirmaciones.Size = new Size(253, 120);
            iconbtnConfirmaciones.TabIndex = 3;
            iconbtnConfirmaciones.Text = "CONFIRMACIONES";
            iconbtnConfirmaciones.TextAlign = ContentAlignment.MiddleLeft;
            iconbtnConfirmaciones.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconbtnConfirmaciones.UseVisualStyleBackColor = true;
            iconbtnConfirmaciones.Click += iconbtnConfirmaciones_Click;
            // 
            // iconbtnSalir
            // 
            iconbtnSalir.Dock = DockStyle.Bottom;
            iconbtnSalir.FlatAppearance.BorderSize = 0;
            iconbtnSalir.FlatStyle = FlatStyle.Flat;
            iconbtnSalir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconbtnSalir.ForeColor = Color.Gainsboro;
            iconbtnSalir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            iconbtnSalir.IconColor = Color.Gainsboro;
            iconbtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnSalir.IconSize = 32;
            iconbtnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            iconbtnSalir.Location = new Point(0, 607);
            iconbtnSalir.Name = "iconbtnSalir";
            iconbtnSalir.Padding = new Padding(10, 0, 20, 0);
            iconbtnSalir.Size = new Size(253, 120);
            iconbtnSalir.TabIndex = 2;
            iconbtnSalir.Text = "Salir del Sistema";
            iconbtnSalir.TextAlign = ContentAlignment.MiddleLeft;
            iconbtnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconbtnSalir.UseVisualStyleBackColor = true;
            iconbtnSalir.Click += iconbtnSalir_Click;
            // 
            // iconbtnEmpleado
            // 
            iconbtnEmpleado.Dock = DockStyle.Top;
            iconbtnEmpleado.FlatAppearance.BorderSize = 0;
            iconbtnEmpleado.FlatStyle = FlatStyle.Flat;
            iconbtnEmpleado.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconbtnEmpleado.ForeColor = Color.Gainsboro;
            iconbtnEmpleado.IconChar = FontAwesome.Sharp.IconChar.Users;
            iconbtnEmpleado.IconColor = Color.Gainsboro;
            iconbtnEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnEmpleado.IconSize = 32;
            iconbtnEmpleado.ImageAlign = ContentAlignment.MiddleLeft;
            iconbtnEmpleado.Location = new Point(0, 260);
            iconbtnEmpleado.Name = "iconbtnEmpleado";
            iconbtnEmpleado.Padding = new Padding(10, 0, 20, 0);
            iconbtnEmpleado.Size = new Size(253, 120);
            iconbtnEmpleado.TabIndex = 1;
            iconbtnEmpleado.Text = "EMPLEADOS";
            iconbtnEmpleado.TextAlign = ContentAlignment.MiddleLeft;
            iconbtnEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconbtnEmpleado.UseVisualStyleBackColor = true;
            iconbtnEmpleado.Click += iconbtnEmpleado_Click;
            // 
            // iconbtnReservas
            // 
            iconbtnReservas.Dock = DockStyle.Top;
            iconbtnReservas.FlatAppearance.BorderSize = 0;
            iconbtnReservas.FlatStyle = FlatStyle.Flat;
            iconbtnReservas.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconbtnReservas.ForeColor = Color.Gainsboro;
            iconbtnReservas.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            iconbtnReservas.IconColor = Color.Gainsboro;
            iconbtnReservas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnReservas.IconSize = 32;
            iconbtnReservas.ImageAlign = ContentAlignment.MiddleLeft;
            iconbtnReservas.Location = new Point(0, 140);
            iconbtnReservas.Name = "iconbtnReservas";
            iconbtnReservas.Padding = new Padding(10, 0, 20, 0);
            iconbtnReservas.Size = new Size(253, 120);
            iconbtnReservas.TabIndex = 0;
            iconbtnReservas.Text = "RESERVAS";
            iconbtnReservas.TextAlign = ContentAlignment.MiddleLeft;
            iconbtnReservas.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconbtnReservas.UseVisualStyleBackColor = true;
            iconbtnReservas.Click += iconbtnReservas_Click;
            // 
            // panellogoesquina
            // 
            panellogoesquina.Controls.Add(pbinicio);
            panellogoesquina.Dock = DockStyle.Top;
            panellogoesquina.Location = new Point(0, 0);
            panellogoesquina.Name = "panellogoesquina";
            panellogoesquina.Size = new Size(253, 140);
            panellogoesquina.TabIndex = 0;
            // 
            // pbinicio
            // 
            pbinicio.Image = Properties.Resources.Black_and_Yellow_Flat_Illustrative_Sunset_Tour_Logo__3_;
            pbinicio.Location = new Point(-1, -1);
            pbinicio.Name = "pbinicio";
            pbinicio.Size = new Size(254, 141);
            pbinicio.SizeMode = PictureBoxSizeMode.Zoom;
            pbinicio.TabIndex = 0;
            pbinicio.TabStop = false;
            pbinicio.Click += pbinicio_Click;
            // 
            // panelBarrasuperior
            // 
            panelBarrasuperior.BackColor = Color.DarkGoldenrod;
            panelBarrasuperior.Controls.Add(lblHome);
            panelBarrasuperior.Controls.Add(iconBarra);
            panelBarrasuperior.Dock = DockStyle.Top;
            panelBarrasuperior.Location = new Point(253, 0);
            panelBarrasuperior.Name = "panelBarrasuperior";
            panelBarrasuperior.Size = new Size(1216, 70);
            panelBarrasuperior.TabIndex = 26;
            panelBarrasuperior.Paint += panelBarrasuperior_Paint;
            // 
            // lblHome
            // 
            lblHome.AutoSize = true;
            lblHome.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHome.ForeColor = Color.White;
            lblHome.Location = new Point(73, 25);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(64, 28);
            lblHome.TabIndex = 28;
            lblHome.Text = "Inicio";
            // 
            // iconBarra
            // 
            iconBarra.BackColor = Color.DarkGoldenrod;
            iconBarra.IconChar = FontAwesome.Sharp.IconChar.House;
            iconBarra.IconColor = Color.White;
            iconBarra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBarra.IconSize = 48;
            iconBarra.Location = new Point(19, 12);
            iconBarra.Name = "iconBarra";
            iconBarra.Size = new Size(48, 55);
            iconBarra.TabIndex = 27;
            iconBarra.TabStop = false;
            // 
            // iconlogocentro
            // 
            iconlogocentro.Anchor = AnchorStyles.None;
            iconlogocentro.BackColor = Color.Transparent;
            iconlogocentro.BackgroundImage = Properties.Resources.Black_and_Yellow_Flat_Illustrative_Sunset_Tour_Logo;
            iconlogocentro.ErrorImage = null;
            iconlogocentro.ForeColor = SystemColors.ControlText;
            iconlogocentro.IconChar = FontAwesome.Sharp.IconChar.None;
            iconlogocentro.IconColor = SystemColors.ControlText;
            iconlogocentro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconlogocentro.IconSize = 438;
            iconlogocentro.InitialImage = null;
            iconlogocentro.Location = new Point(357, 104);
            iconlogocentro.Name = "iconlogocentro";
            iconlogocentro.Size = new Size(491, 438);
            iconlogocentro.SizeMode = PictureBoxSizeMode.Zoom;
            iconlogocentro.TabIndex = 3;
            iconlogocentro.TabStop = false;
            // 
            // panelFORMULARIOS
            // 
            panelFORMULARIOS.BackColor = Color.Transparent;
            panelFORMULARIOS.Controls.Add(iconlogocentro);
            panelFORMULARIOS.Dock = DockStyle.Fill;
            panelFORMULARIOS.Location = new Point(253, 70);
            panelFORMULARIOS.Name = "panelFORMULARIOS";
            panelFORMULARIOS.Size = new Size(1216, 657);
            panelFORMULARIOS.TabIndex = 28;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1469, 727);
            ControlBox = false;
            Controls.Add(panelFORMULARIOS);
            Controls.Add(panelBarrasuperior);
            Controls.Add(panelContenido);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += Form2_Load;
            panelContenido.ResumeLayout(false);
            panellogoesquina.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbinicio).EndInit();
            panelBarrasuperior.ResumeLayout(false);
            panelBarrasuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconBarra).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconlogocentro).EndInit();
            panelFORMULARIOS.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelContenido;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label lblSeleccione;
        private Label lblMenu;
        private FontAwesome.Sharp.IconButton iconbtnReservas;
        private FontAwesome.Sharp.IconButton iconbtnSalir;
        private FontAwesome.Sharp.IconButton iconbtnEmpleado;
        private Panel panelBarrasuperior;
        private Label lblHome;
        private FontAwesome.Sharp.IconPictureBox iconBarra;
        private FontAwesome.Sharp.IconPictureBox iconlogocentro;
        private Panel panellogoesquina;
        private PictureBox pbinicio;
        private Panel panelFORMULARIOS;
        private FontAwesome.Sharp.IconButton iconbtnConfirmaciones;
    }
}