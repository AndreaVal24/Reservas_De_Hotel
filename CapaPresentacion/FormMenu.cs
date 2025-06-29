﻿using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //no pude cambiar los nombres de los formularios, me daba error
        //formEmpleados es el formulario de reservas y Form1 es el de empleados


        private void btnOpcionReserva_Click(object sender, EventArgs e)
        {
            //este boton llama al formulario reserva y oculta al menu
            FormEmpleados formReserva = new FormEmpleados();
            formReserva.Show();
            this.Hide(); //oculta el formulario de menu
            formReserva.FormClosed += (s, args) => this.Show(); //este evento permite que al cerrar el formulario de reservas, se vuelva a mostrar el menu
        }

        private void btnOpcionEmpleados_Click(object sender, EventArgs e)
        {
            Form1 formEmpleados = new Form1();
            formEmpleados.Show();
            this.Hide();
            formEmpleados.FormClosed += (s, args) => this.Show(); //este evento permite que al cerrar el formulario de empleados, se vuelva a mostrar el menu
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //salir del programa
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres salir?", "Confirmar salida",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit(); //cierra la aplicacion
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
