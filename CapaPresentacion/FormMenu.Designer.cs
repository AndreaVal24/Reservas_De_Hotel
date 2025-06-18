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
            lblBIENVENIDOS = new Label();
            lblMenu = new Label();
            lblSeleccione = new Label();
            btnOpcionReserva = new Button();
            btnOpcionEmpleados = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // lblBIENVENIDOS
            // 
            lblBIENVENIDOS.AutoSize = true;
            lblBIENVENIDOS.Location = new Point(559, 42);
            lblBIENVENIDOS.Name = "lblBIENVENIDOS";
            lblBIENVENIDOS.Size = new Size(109, 25);
            lblBIENVENIDOS.TabIndex = 0;
            lblBIENVENIDOS.Text = "Hotel Limon";
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Location = new Point(583, 94);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(57, 25);
            lblMenu.TabIndex = 1;
            lblMenu.Text = "Menu";
            // 
            // lblSeleccione
            // 
            lblSeleccione.AutoSize = true;
            lblSeleccione.Location = new Point(482, 144);
            lblSeleccione.Name = "lblSeleccione";
            lblSeleccione.Size = new Size(243, 25);
            lblSeleccione.TabIndex = 2;
            lblSeleccione.Text = "Seleccione la opcion deseada";
            // 
            // btnOpcionReserva
            // 
            btnOpcionReserva.Location = new Point(559, 245);
            btnOpcionReserva.Name = "btnOpcionReserva";
            btnOpcionReserva.Size = new Size(112, 34);
            btnOpcionReserva.TabIndex = 3;
            btnOpcionReserva.Text = "Reservas";
            btnOpcionReserva.UseVisualStyleBackColor = true;
            btnOpcionReserva.Click += btnOpcionReserva_Click;
            // 
            // btnOpcionEmpleados
            // 
            btnOpcionEmpleados.Location = new Point(559, 334);
            btnOpcionEmpleados.Name = "btnOpcionEmpleados";
            btnOpcionEmpleados.Size = new Size(112, 34);
            btnOpcionEmpleados.TabIndex = 4;
            btnOpcionEmpleados.Text = "Empleados";
            btnOpcionEmpleados.UseVisualStyleBackColor = true;
            btnOpcionEmpleados.Click += btnOpcionEmpleados_Click;
            // 
            // button3
            // 
            button3.Location = new Point(535, 414);
            button3.Name = "button3";
            button3.Size = new Size(168, 34);
            button3.TabIndex = 5;
            button3.Text = "Salir del Sistema";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1295, 695);
            Controls.Add(button3);
            Controls.Add(btnOpcionEmpleados);
            Controls.Add(btnOpcionReserva);
            Controls.Add(lblSeleccione);
            Controls.Add(lblMenu);
            Controls.Add(lblBIENVENIDOS);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBIENVENIDOS;
        private Label lblMenu;
        private Label lblSeleccione;
        private Button btnOpcionReserva;
        private Button btnOpcionEmpleados;
        private Button button3;
    }
}