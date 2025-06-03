using CapaDatos;
using CapaNegocio;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ObtenerReservas();  //para que se muestren las nuevas reservas en el dgv



        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbHabitacion.Items.Clear(); // Asegura que no se dupliquen

            cbHabitacion.Items.Add("Simple");
            cbHabitacion.Items.Add("Con Desayuno");
            cbHabitacion.SelectedIndex = 0; // Selecciona el primer elemento por defecto
        }
        private void limpiarCampos() //metodo para limpiar los campos del formulario
        {
            txtCliente.Text = "";
            cbHabitacion.SelectedIndex = 0;
            txtNumeroHabitacion.Text = "";
            txtDiasEstadia.Text = "";
            dtpFecha.Value = DateTime.Today;
            txtTotal.Text = "";

        }
        //BOTON CALCULAR TOTAL
        public void btnTotal_Click(object sender, EventArgs e)
        {
            //calcular precio
            string tipo = cbHabitacion.SelectedItem.ToString();
            decimal preciopornoche = 0;

            if (tipo == "Simple")
            {
                Simple simple = new Simple();
                preciopornoche = simple.Precio1;
            }
            else if (tipo == "Con Desayuno")
            {
                ConDesayuno condesayuno = new ConDesayuno();
                preciopornoche = condesayuno.Precio2;
            }
            int dias;
            if (!int.TryParse(txtDiasEstadia.Text, out dias))
            {

                MessageBox.Show("Ingrese una cantidad valida de dias");
                return;
            }
            decimal total = preciopornoche * dias;
            txtTotal.Text = total.ToString();

        }

        //BOTON RESERVAR
        public void btnReservar_Click(object sender, EventArgs e)
        {
            //validacion de campos
            if (string.IsNullOrWhiteSpace(txtCliente.Text) ||
            string.IsNullOrWhiteSpace(txtNumeroHabitacion.Text) ||
            string.IsNullOrWhiteSpace(txtDiasEstadia.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Validacion de numeros validos
            if (!int.TryParse(txtNumeroHabitacion.Text, out int numeroHabitacion))
            {
                MessageBox.Show("El número de habitación debe ser un número válido.");
                return;
            }

            if (!int.TryParse(txtDiasEstadia.Text, out int diasEstadia))
            {
                MessageBox.Show("Los días de estadía deben ser un número válido.");
                return;
            }

            //insertar datos
            Reserva reserva = new Reserva();
            if (cbHabitacion.SelectedItem.ToString() == "Simple")
                reserva = new Simple();
            else
                reserva = new ConDesayuno();

            reserva.Cliente = txtCliente.Text;
            reserva.Habitacion = cbHabitacion.Text;
            reserva.Numero_Habitacion = numeroHabitacion;
            reserva.DiasEstadia = diasEstadia;
            reserva.Fecha = dtpFecha.Value;


            if (decimal.TryParse(txtTotal.Text, out decimal total))
            {
                reserva.Precio = total;
            }
            else
            {
                MessageBox.Show("Debe calcular el total antes de guardar la reserva.");
                return;
            }

            ReservaNegocio negocio = new ReservaNegocio();

            int resultadoSql = negocio.InsertarReserva(reserva);
            if (resultadoSql > 0)
            {
                MessageBox.Show("Se guardo la reserva correctamente");
                ObtenerReservas();
                limpiarCampos();
            }
            else
            {
                MessageBox.Show("No se guardo la reserva ");
            }

        }
        //DGV
        private void ObtenerReservas()
        {
            Conexion data = new Conexion();
            using (SqlConnection conn = new SqlConnection(data.CadenaConexion))
            {
                SqlDataAdapter adapt;
                conn.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("SELECT * FROM Reserva", conn);
                adapt.Fill(dt);
                dgv.DataSource = dt;
                conn.Close();
            }
        }


        private void cbHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cbHabitacion_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                DialogResult confirmacion = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar esta reserva?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    try
                    {
                        int idReserva = Convert.ToInt32(dgv.SelectedRows[0].Cells["ID"].Value);
                        ReservaNegocio negocio = new ReservaNegocio();
                        negocio.EliminarReserva(idReserva);
                        ObtenerReservas(); // Recarga el DataGridView

                        MessageBox.Show("Reserva eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar la reserva: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una reserva para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
