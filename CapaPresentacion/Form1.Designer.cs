namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTITULO = new Label();
            lblID = new Label();
            lblCLIENTE = new Label();
            lblHABITACION = new Label();
            lblNUMERO = new Label();
            lblFECHA = new Label();
            txtID = new TextBox();
            txtCLIENTE = new TextBox();
            txtHABITACION = new TextBox();
            txtNUMERO = new TextBox();
            txtFECHA = new TextBox();
            btnBUSCAR = new Button();
            btnCALCULAR = new Button();
            txtPRECIO = new TextBox();
            SuspendLayout();
            // 
            // lblTITULO
            // 
            lblTITULO.AutoSize = true;
            lblTITULO.Location = new Point(317, 9);
            lblTITULO.Name = "lblTITULO";
            lblTITULO.Size = new Size(113, 25);
            lblTITULO.TabIndex = 0;
            lblTITULO.Text = "Hotel Dinero";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(185, 62);
            lblID.Name = "lblID";
            lblID.Size = new Size(30, 25);
            lblID.TabIndex = 1;
            lblID.Text = "ID";
            // 
            // lblCLIENTE
            // 
            lblCLIENTE.AutoSize = true;
            lblCLIENTE.Location = new Point(185, 112);
            lblCLIENTE.Name = "lblCLIENTE";
            lblCLIENTE.Size = new Size(65, 25);
            lblCLIENTE.TabIndex = 2;
            lblCLIENTE.Text = "Cliente";
            // 
            // lblHABITACION
            // 
            lblHABITACION.AutoSize = true;
            lblHABITACION.Location = new Point(185, 171);
            lblHABITACION.Name = "lblHABITACION";
            lblHABITACION.Size = new Size(97, 25);
            lblHABITACION.TabIndex = 3;
            lblHABITACION.Text = "Habitacion";
            // 
            // lblNUMERO
            // 
            lblNUMERO.AutoSize = true;
            lblNUMERO.Location = new Point(185, 223);
            lblNUMERO.Name = "lblNUMERO";
            lblNUMERO.Size = new Size(192, 25);
            lblNUMERO.TabIndex = 4;
            lblNUMERO.Text = "Numero de Habitacion";
            // 
            // lblFECHA
            // 
            lblFECHA.AutoSize = true;
            lblFECHA.Location = new Point(185, 280);
            lblFECHA.Name = "lblFECHA";
            lblFECHA.Size = new Size(57, 25);
            lblFECHA.TabIndex = 5;
            lblFECHA.Text = "Fecha";
            // 
            // txtID
            // 
            txtID.Location = new Point(383, 62);
            txtID.Name = "txtID";
            txtID.Size = new Size(150, 31);
            txtID.TabIndex = 6;
            // 
            // txtCLIENTE
            // 
            txtCLIENTE.Location = new Point(383, 112);
            txtCLIENTE.Name = "txtCLIENTE";
            txtCLIENTE.Size = new Size(150, 31);
            txtCLIENTE.TabIndex = 7;
            // 
            // txtHABITACION
            // 
            txtHABITACION.Location = new Point(383, 171);
            txtHABITACION.Name = "txtHABITACION";
            txtHABITACION.Size = new Size(150, 31);
            txtHABITACION.TabIndex = 8;
            // 
            // txtNUMERO
            // 
            txtNUMERO.Location = new Point(383, 223);
            txtNUMERO.Name = "txtNUMERO";
            txtNUMERO.Size = new Size(150, 31);
            txtNUMERO.TabIndex = 9;
            // 
            // txtFECHA
            // 
            txtFECHA.Location = new Point(383, 280);
            txtFECHA.Name = "txtFECHA";
            txtFECHA.Size = new Size(150, 31);
            txtFECHA.TabIndex = 10;
            // 
            // btnBUSCAR
            // 
            btnBUSCAR.Location = new Point(293, 332);
            btnBUSCAR.Name = "btnBUSCAR";
            btnBUSCAR.Size = new Size(112, 34);
            btnBUSCAR.TabIndex = 11;
            btnBUSCAR.Text = "BUSCAR";
            btnBUSCAR.UseVisualStyleBackColor = true;
            btnBUSCAR.Click += btnBUSCAR_Click;
            // 
            // btnCALCULAR
            // 
            btnCALCULAR.Location = new Point(56, 388);
            btnCALCULAR.Name = "btnCALCULAR";
            btnCALCULAR.Size = new Size(294, 31);
            btnCALCULAR.TabIndex = 12;
            btnCALCULAR.Text = "CALCULAR TOTAL A PAGAR";
            btnCALCULAR.UseVisualStyleBackColor = true;
            btnCALCULAR.Click += btnCALCULAR_Click;
            // 
            // txtPRECIO
            // 
            txtPRECIO.Location = new Point(383, 388);
            txtPRECIO.Name = "txtPRECIO";
            txtPRECIO.Size = new Size(150, 31);
            txtPRECIO.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPRECIO);
            Controls.Add(btnCALCULAR);
            Controls.Add(btnBUSCAR);
            Controls.Add(txtFECHA);
            Controls.Add(txtNUMERO);
            Controls.Add(txtHABITACION);
            Controls.Add(txtCLIENTE);
            Controls.Add(txtID);
            Controls.Add(lblFECHA);
            Controls.Add(lblNUMERO);
            Controls.Add(lblHABITACION);
            Controls.Add(lblCLIENTE);
            Controls.Add(lblID);
            Controls.Add(lblTITULO);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTITULO;
        private Label lblID;
        private Label lblCLIENTE;
        private Label lblHABITACION;
        private Label lblNUMERO;
        private Label lblFECHA;
        private TextBox txtID;
        private TextBox txtCLIENTE;
        private TextBox txtHABITACION;
        private TextBox txtNUMERO;
        private TextBox txtFECHA;
        private Button btnBUSCAR;
        private Button btnCALCULAR;
        private TextBox txtPRECIO;
    }
}
