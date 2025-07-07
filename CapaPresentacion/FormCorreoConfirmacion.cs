using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using CapaNegocio;
using CapaDatos;

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
            ReservaNegocio negocio = new ReservaNegocio();
            dgvConfirmaciones.DataSource = negocio.ObtenerReservasNoConfirmadas();


        }


        // boton para enviar correo
        private void btnEnviarCorreo_Click(object sender, EventArgs e)
        {
            if (dgvConfirmaciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una reserva para enviar el correo.");
                return;
            }

            DataGridViewRow fila = dgvConfirmaciones.SelectedRows[0];
            int id = Convert.ToInt32(fila.Cells["ID"].Value);
            string correoDestino = fila.Cells["Correo"].Value.ToString();
            string cliente = fila.Cells["Cliente"].Value.ToString();
            string habitacion = fila.Cells["Habitacion"].Value.ToString();
            string fecha = Convert.ToDateTime(fila.Cells["Fecha"].Value).ToString("dd/MM/yyyy");
            string dias = fila.Cells["DiasEstadia"].Value.ToString();
            string precio = Convert.ToDecimal(fila.Cells["Precio"].Value).ToString("F2");

            string asunto = "Confirmación de Reserva - Lemon Resort";
            string cuerpo = $"Hola {cliente},\n\n" +
                            $"Tu reserva en Lemon Resort ha sido confirmada:\n" +
                            $"- Tipo de habitación: {habitacion}\n" +
                            $"- Fecha de entrada: {fecha}\n" +
                            $"- Días de estadía: {dias}\n" +
                            $"- Total a pagar: ${precio}\n\n" +
                            $"¡Gracias por elegirnos!\n\n" +
                            $"Atentamente,\nLemon Resort";

            try
            {
                // Verifica si el correo de destino es válido antes de intentar enviar
                if (string.IsNullOrWhiteSpace(correoDestino) || !correoDestino.Contains("@") || !correoDestino.Contains("."))
                {
                    MessageBox.Show("El correo electrónico del cliente no es válido o está vacío. No se puede enviar la confirmación.", "Error de Correo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Detiene la ejecución si el correo no es válido
                }

                EnviarCorreo(correoDestino, asunto, cuerpo);

                // Marca la reserva como correo enviado
                ReservaNegocio negocio = new ReservaNegocio();
                negocio.MarcarCorreoComoEnviado(id);

                MessageBox.Show("Correo enviado correctamente.");
                CargarReservasPendientes(); // recarga el DGV para que la reserva desaparezca
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar el correo: " + ex.Message);
            }
        }

        // Método para enviar correo
        private void EnviarCorreo(string destino, string asunto, string cuerpo)
        {
            MailMessage mensaje = new MailMessage();
            mensaje.From = new MailAddress("Lemonresort2025@gmail.com");
            mensaje.To.Add(destino);
            mensaje.Subject = asunto;
            mensaje.Body = cuerpo;

            // Configura SMTP
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("Lemonresort2025@gmail.com", "vvqf kdds agic rcwl");
            smtp.Send(mensaje);
        }

        private void dgvConfirmaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
