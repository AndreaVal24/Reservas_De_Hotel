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
    public partial class FormEmpleados : Form
    {
        public FormEmpleados()
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


            txtCliente.MaxLength = 30; // Limita el número de caracteres del campo Cliente a 50
            txtNumeroHabitacion.MaxLength = 3; // Limita el número de caracteres del campo NumeroHabitacion a 4
            txtDiasEstadia.MaxLength = 3; // Limita el número de caracteres del campo DiasEstadia a 3

            cbHabitacion.DropDownStyle = ComboBoxStyle.DropDownList; // Evita que el usuario pueda escribir en el ComboBox
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

            // Verifica el tipo de habitación y asigna el precio correspondiente
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
            txtTotal.Text = total.ToString("F2"); // Formatea el total a dos decimales

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

            // VALIDACIÓN DE FECHA: debe ser al menos con 24h de anticipación
            if (idReservaEditando == -1)  // Solo se aplica si NO estamos editando
            {
                DateTime fechaSeleccionada = dtpFecha.Value.Date;
                if (fechaSeleccionada <= DateTime.Today)
                {
                    MessageBox.Show("La fecha de la reserva debe hacerse con al menos 24 horas de anticipación.");
                    return;
                }
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

            // Validar que el campo de total no esté vacío y sea un número válido
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

            
            int idConsulta = (idReservaEditando != -1) ? idReservaEditando : -1; // Esto permite que el método de negocio
                                                                                 // pueda manejar tanto la creación como
                                                                                 // la edición de reservas.

            if (negocio.ExisteConflictoReserva(reserva.Numero_Habitacion, reserva.Fecha, reserva.DiasEstadia, idConsulta)) // Verifica si ya existe una reserva para esa habitación en las mismas fechas
            {
                MessageBox.Show("Esa habitación ya está reservada para esas fechas. Por favor, elija otra.");
                return;
            }

            //caso de editar 

            if (idReservaEditando != -1) // Si estamos editando una reserva existente
            {
                reserva.ID = idReservaEditando; // Asignamos el ID de la reserva que se está editando
                negocio.EditarReserva(reserva); // Llamamos al método para editar la reserva
                MessageBox.Show("Reserva actualizada correctamente.");
                idReservaEditando = -1; // Reseteamos el ID de edición

                btnReservar.Text = "Guardar reserva"; // Cambiamos el texto del botón de nuevo a "Guardar reserva"
                btnReservar.BackColor = Color.White;
                btnReservar.ForeColor = Color.DarkGoldenrod;

            }

            else // caso RESERVA
            {
                int resultadoSql = negocio.InsertarReserva(reserva);
                if (resultadoSql > 0)
                    MessageBox.Show("Se guardó la reserva correctamente.");
                else
                    MessageBox.Show("No se guardó la reserva.");
            }


            limpiarCampos();  //limpiamos los campos 
            ObtenerReservas(); // Actualiza el DataGridView para mostrar la nueva reserva
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




        //BOTON ELIMINAR RESERVA
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada en el DGV
            if (dgv.SelectedRows.Count > 0)
            {
                // Confirma la eliminación
                DialogResult confirmacion = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar esta reserva?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    // Si el usuario confirma, procede a eliminar la reserva
                    //Si el usuario selecciona no, no se hace nada
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



        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Evita que se ingresen caracteres no permitidos
            }
        }

        private void btnVolverReservas_Click(object sender, EventArgs e)  //boton para volver al menu principal
        {
            Form2 menu = new Form2(); // Form2 es el formulario de menu principal
            menu.Show();
            this.Hide();
        }


        private int idReservaEditando = -1; // Variable para almacenar el ID de la reserva que se está editando

        // Botón para editar una reserva
        private void btnEditarRe_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una reserva para editar.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "¿Estás seguro de que deseas editar los datos del empleado seleccionado?",
                "Confirmar Edición",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.No)
            {
                return; // Si el usuario cancela, no hace nada, el return hace que se salga del metodo
                //si el usuario presiona No, no se ejecuta el resto del código, si presiona Si, se continua con el resto del código
            }

            DataGridViewRow fila = dgv.SelectedRows[0]; //esto obtiene la fila seleccionada en el DataGridView

            idReservaEditando = Convert.ToInt32(fila.Cells["ID"].Value); //guardar el ID de la reserva seleccionada


            // Quitar restricciones antes de asignar la fecha pasada
            dtpFecha.MinDate = DateTimePicker.MinimumDateTime;

            //pasar los datos al textbox y combobox
            txtCliente.Text = fila.Cells["Cliente"].Value.ToString();
            cbHabitacion.SelectedItem = fila.Cells["Habitacion"].Value.ToString();
            txtNumeroHabitacion.Text = fila.Cells["Numero_Habitacion"].Value.ToString();
            txtDiasEstadia.Text = fila.Cells["DiasEstadia"].Value.ToString();
            dtpFecha.Value = Convert.ToDateTime(fila.Cells["Fecha"].Value);

            dtpFecha.MinDate = DateTimePicker.MinimumDateTime;
            dtpFecha.Value = Convert.ToDateTime(fila.Cells["Fecha"].Value);

            btnReservar.Text = "Guardar cambios"; // Cambia el texto del botón
            btnReservar.BackColor = Color.DarkOliveGreen;
            btnReservar.ForeColor = Color.White;



        }

        private void txtDiasEstadia_TextChanged(object sender, EventArgs e)
        {
            txtTotal.Text = ""; // Limpia el campo de total al cambiar los días de estadía
        }

        private void txtNumeroHabitacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // permite solo números
            }
        }

        private void txtDiasEstadia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; //permite solo numeros 
            }
        }


        //agregue un boton para buscar por fecha

        private void btnBuscarporfecha_Click(object sender, EventArgs e)
        {
            //leera la fecha desde y hasta

            DateTime fechaDesde = dtpDESDE.Value.Date;
            DateTime fechaHasta = dtpHASTA.Value.Date;
            if (fechaDesde > fechaHasta)
            {
                MessageBox.Show("La fecha desde no puede ser mayor que la fecha hasta.");
                return;
            }
            ReservaNegocio negocio = new ReservaNegocio();
            dgv.DataSource = negocio.BuscarReservaPorFecha(fechaDesde, fechaHasta);
            //limpiar los campos de búsqueda
            dtpDESDE.Value = DateTime.Today;
            dtpHASTA.Value = DateTime.Today;
        }

        //agregue un boton para mostrar todas las reservas 
        private void btnMostrartodo_Click(object sender, EventArgs e)
        {
            ReservaNegocio negocio = new ReservaNegocio();
            dgv.DataSource = negocio.ObtenerTodasLasReservas();
        }

        private void cbHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTotal.Clear();

        }
    }
}
