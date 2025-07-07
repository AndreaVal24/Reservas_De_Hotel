using CapaDatos;
using CapaNegocio;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNCorreo
    {

        private Conexion conexion = new Conexion();


        //metodo para marcar el correo como enviado, cuando se envia el correo de confirmacion de reserva
        public void MarcarCorreoComoEnviado(int idReserva)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "UPDATE Reserva SET CorreoEnviado = 1 WHERE ID = @ID";  // Actualiza el campo CorreoEnviado a 1 para la reserva especificada
                                                                                       //quotandolas asi del dgv del form correo confirmacion
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", idReserva);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        //metodo para obtener las reservas que no han sido confirmadas, es decir,
        //las reservas que tienen el campo CorreoEnviado en 0
        public DataTable ObtenerReservasNoConfirmadas()
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();

                string query = @"SELECT * FROM Reserva 
                         WHERE Fecha >= @Hoy AND CorreoEnviado = 0";  //si no se ha enviado correo, sale 0 en correoEnviado y aparecen en el dgv

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Hoy", DateTime.Today);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable tabla = new DataTable();
                    da.Fill(tabla);
                    return tabla;
                }
            }
        }

        public void EnviarCorreo(string destino, string asunto, string cuerpo) // Método para enviar el correo
        {
            MailMessage mensaje = new MailMessage();  // Crea una nueva instancia de MailMessage
            mensaje.From = new MailAddress("Lemonresort2025@gmail.com");   // Establece la dirección de correo del remitente
            mensaje.To.Add(destino);  // Agrega la dirección de correo del destinatario
            mensaje.Subject = asunto;  // Establece el asunto del correo
            mensaje.Body = cuerpo;  //Establece el cuerpo del correo

            // Configuracion SMTP
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587); // 587 es el puerto para TLS
                                                                     // TLS es un protocolo de seguridad para enviar correos electrónicos
            smtp.EnableSsl = true; // Habilita SSL para la conexión segura, SSL es un protocolo de seguridad para enviar correos electrónicos
            smtp.UseDefaultCredentials = false; // Esto indica que no se utilizarán las credenciales predeterminadas del sistema
            smtp.Credentials = new NetworkCredential("Lemonresort2025@gmail.com", "vvqf kdds agic rcwl"); // Aquí puse la contraseña de la cuenta de correo, 
                                                                                                          // que es una contraseña de aplicación generada en la cuenta de Google
            smtp.Send(mensaje); // Envía el mensaje de correo electrónico
        }

        //quiero aclarar que esto no verifica si el correo existe realmente, sea como sea, se envía el correo y si no existe,
        //el servidor de correo lo manejará como un error de entrega, pero no tiene que ver con la aplicación.

    }
}
