using CapaDatos;
using CapaNegocio;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormCorreoReservas : Form
    {
        public FormCorreoReservas()
        {
            InitializeComponent();
        }

        private void FormEstadisticas_Load(object sender, EventArgs e)
        {
            CargarReservasPendientes();

        }

        //Cargar reservas pendientes para enviar correos de confirmación en el dgv
        private void CargarReservasPendientes()
        {
            CNCorreo negocio = new CNCorreo(); // Instancia de la clase ReservaNegocio que maneja la lógica de negocio para las reservas
            dgvConfirmaciones.DataSource = negocio.ObtenerReservasNoConfirmadas(); // Obtiene las reservas pendientes de confirmación
                                                                                   // desde la base de datos
            if (dgvConfirmaciones.Columns.Contains("CorreoEnviado"))
            {
                dgvConfirmaciones.Columns["CorreoEnviado"].Visible = false;  // Oculta la columna CorreoEnviado en el DataGridView
            }

        }


        // boton para enviar correo
        private void btnEnviarCorreo_Click(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada en el DataGridView
            if (dgvConfirmaciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una reserva para enviar el correo.");
                return;
            }

            // Obtiene los datos de la fila seleccionada
            DataGridViewRow fila = dgvConfirmaciones.SelectedRows[0];
            int id = Convert.ToInt32(fila.Cells["ID"].Value);
            string correoDestino = fila.Cells["Correo"].Value.ToString();
            string cliente = fila.Cells["Cliente"].Value.ToString();
            string habitacion = fila.Cells["Habitacion"].Value.ToString();
            string fecha = Convert.ToDateTime(fila.Cells["Fecha"].Value).ToString("dd/MM/yyyy");
            string dias = fila.Cells["DiasEstadia"].Value.ToString();
            string precio = Convert.ToDecimal(fila.Cells["Precio"].Value).ToString("F2");

            // Construye el asunto y el cuerpo del correo
            string asunto = "Confirmación de Reserva - Lemon Resort";
            string cuerpo = $"Hola {cliente},\n\n" +
                            $"Tu reserva en Lemon Resort ha sido confirmada:\n" +
                            $"- Tipo de habitación: {habitacion}\n" +
                            $"- Fecha de entrada: {fecha}\n" +
                            $"- Días de estadía: {dias}\n" +
                            $"- Total a pagar: ${precio}\n\n" +
                            $"¡Gracias por elegirnos!\n\n" +
                            $"Atentamente,\nLemon Resort";

            // Intenta enviar el correo
            try
            {
                // Verifica si el correo de destino es válido antes de intentar enviar
                if (string.IsNullOrWhiteSpace(correoDestino) || !correoDestino.Contains("@") || !correoDestino.Contains("."))
                {
                    MessageBox.Show("El correo electrónico del cliente no es válido o está vacío. No se puede enviar la confirmación.", "Error de Correo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Detiene la ejecución si el correo no es válido
                }

                // Envía el correo
                CNCorreo negocioCorreo = new CNCorreo(); // Instancia de la clase CNCorreo que maneja la lógica de negocio para el envío de correos
                negocioCorreo.EnviarCorreo(correoDestino, asunto, cuerpo); // Llama al método para enviar el correo
        

                // Marca la reserva como correo enviado
                CNCorreo negocio = new CNCorreo();
                negocio.MarcarCorreoComoEnviado(id);

                MessageBox.Show("Correo enviado correctamente.");
                CargarReservasPendientes(); // recarga el DGV para que la reserva desaparezca
            }
            // Captura cualquier excepción al enviar el correo
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar el correo: " + ex.Message);
            }
        }

        
        
        private void dgvConfirmaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTituloConfirmaciones_Click(object sender, EventArgs e)
        {

        }
    }
}
