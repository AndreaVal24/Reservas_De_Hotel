namespace CapaPresentacion
{
    partial class FormLogin
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
            panelLogo = new Panel();
            pbLogo = new PictureBox();
            txtuser = new TextBox();
            txtpass = new TextBox();
            lblLogin = new Label();
            btnLogin = new Button();
            pbCerrar = new PictureBox();
            pbMinimizar = new PictureBox();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMinimizar).BeginInit();
            SuspendLayout();
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.LightGoldenrodYellow;
            panelLogo.Controls.Add(pbLogo);
            panelLogo.Dock = DockStyle.Left;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 330);
            panelLogo.TabIndex = 0;
            panelLogo.Paint += panel1_Paint;
            panelLogo.MouseDown += panel1_MouseDown;
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.Black_and_Yellow_Flat_Illustrative_Sunset_Tour_Logo;
            pbLogo.Location = new Point(0, 85);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(250, 184);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 8;
            pbLogo.TabStop = false;
            // 
            // txtuser
            // 
            txtuser.BackColor = Color.Black;
            txtuser.BorderStyle = BorderStyle.FixedSingle;
            txtuser.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtuser.ForeColor = Color.DimGray;
            txtuser.Location = new Point(326, 94);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(390, 37);
            txtuser.TabIndex = 1;
            txtuser.Text = "USUARIO";
            txtuser.Enter += txtuser_Enter;
            txtuser.Leave += txtuser_Leave;
            // 
            // txtpass
            // 
            txtpass.BackColor = Color.Black;
            txtpass.BorderStyle = BorderStyle.FixedSingle;
            txtpass.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpass.ForeColor = Color.DimGray;
            txtpass.Location = new Point(326, 154);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(390, 37);
            txtpass.TabIndex = 2;
            txtpass.Text = "CONTRASEÑA";
            txtpass.Enter += txtpass_Enter;
            txtpass.Leave += txtpass_Leave;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.DimGray;
            lblLogin.Location = new Point(447, 9);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(151, 49);
            lblLogin.TabIndex = 3;
            lblLogin.Text = "LOGIN";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(40, 40, 40);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.LightGray;
            btnLogin.Location = new Point(326, 217);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(390, 40);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "ACCEDER";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pbCerrar
            // 
            pbCerrar.Image = Properties.Resources.png_s803q;
            pbCerrar.Location = new Point(756, 0);
            pbCerrar.Name = "pbCerrar";
            pbCerrar.Size = new Size(23, 20);
            pbCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            pbCerrar.TabIndex = 6;
            pbCerrar.TabStop = false;
            pbCerrar.Click += pbCerrar_Click;
            // 
            // pbMinimizar
            // 
            pbMinimizar.Image = Properties.Resources.png_n7tga1;
            pbMinimizar.Location = new Point(732, 0);
            pbMinimizar.Name = "pbMinimizar";
            pbMinimizar.Size = new Size(23, 20);
            pbMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            pbMinimizar.TabIndex = 7;
            pbMinimizar.TabStop = false;
            pbMinimizar.Click += pbMinimizar_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(780, 330);
            Controls.Add(pbMinimizar);
            Controls.Add(pbCerrar);
            Controls.Add(btnLogin);
            Controls.Add(lblLogin);
            Controls.Add(txtpass);
            Controls.Add(txtuser);
            Controls.Add(panelLogo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            MouseDown += FormLogin_MouseDown;
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMinimizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelLogo;
        private TextBox txtuser;
        private TextBox txtpass;
        private Label lblLogin;
        private Button btnLogin;
        private PictureBox pbCerrar;
        private PictureBox pbMinimizar;
        private PictureBox pbLogo;
    }
}