using CapaDatos;
using CapaNegocio;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ReservaNegocio
    {
        private Conexion conexion = new Conexion();

        public int InsertarReserva(Reserva reserva)
        {

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();

                string query = "INSERT INTO Reserva (Cliente, Habitacion, Numero_Habitacion, Fecha, Precio, DiasEstadia, Correo, CorreoEnviado) " +
                               "VALUES (@Cliente, @Habitacion, @Numero_Habitacion, @Fecha, @Precio, @DiasEstadia, @Correo, @CorreoEnviado)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Cliente", reserva.Cliente);
                    cmd.Parameters.AddWithValue("@Habitacion", reserva.Habitacion);
                    cmd.Parameters.AddWithValue("@Numero_Habitacion", reserva.Numero_Habitacion);
                    cmd.Parameters.AddWithValue("@Fecha", reserva.Fecha);
                    cmd.Parameters.AddWithValue("@Precio", reserva.Precio);
                    cmd.Parameters.AddWithValue("@DiasEstadia", reserva.DiasEstadia);
                    cmd.Parameters.AddWithValue("@Correo", reserva.Correo);
                    cmd.Parameters.AddWithValue("@CorreoEnviado", reserva.CorreoEnviado);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarReserva(int idReserva)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "DELETE FROM Reserva WHERE ID = @ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", idReserva);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Reserva CalcularCostoFinal(int idReserva)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();

                string query = "SELECT * FROM Reserva WHERE ID = @ID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", idReserva);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string habitacion = reader["Habitacion"].ToString();
                            Reserva reserva;

                            if (habitacion == "Simple")
                                reserva = new Simple();
                            else
                                reserva = new ConDesayuno();

                            reserva.ID = (int)reader["ID"];
                            reserva.Cliente = reader["Cliente"].ToString();
                            reserva.Habitacion = habitacion;
                            reserva.Numero_Habitacion = (int)reader["Numero_Habitacion"];
                            reserva.Fecha = (DateTime)reader["Fecha"];
                            reserva.DiasEstadia = (int)reader["DiasEstadia"];
                            reserva.Correo = reader["Correo"].ToString();
                            reserva.CorreoEnviado = Convert.ToBoolean(reader["CorreoEnviado"]); 
                            //to boolean se usa para convertir un valor de tipo bit a un valor booleano en C#


                            return reserva;
                        }
                    }
                }
            }

            return null;
        }

        //metodo para editar los datos de una reserva
        public void EditarReserva(Reserva reserva)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "UPDATE Reserva SET Cliente = @Cliente, Habitacion = @Habitacion, Numero_Habitacion = @Numero_Habitacion, " +
                               "Fecha = @Fecha, Precio = @Precio, DiasEstadia = @DiasEstadia, Correo = @Correo, CorreoEnviado = @CorreoEnviado " +
                               "WHERE ID = @ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", reserva.ID);
                    cmd.Parameters.AddWithValue("@Cliente", reserva.Cliente);
                    cmd.Parameters.AddWithValue("@Habitacion", reserva.Habitacion);
                    cmd.Parameters.AddWithValue("@Numero_Habitacion", reserva.Numero_Habitacion);
                    cmd.Parameters.AddWithValue("@Fecha", reserva.Fecha);
                    cmd.Parameters.AddWithValue("@Precio", reserva.Precio);
                    cmd.Parameters.AddWithValue("@DiasEstadia", reserva.DiasEstadia);
                    cmd.Parameters.AddWithValue("@Correo", reserva.Correo);
                    cmd.Parameters.AddWithValue("@CorreoEnviado", reserva.CorreoEnviado);   
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Utilice DataTable para la búsqueda y mostrar reservas
        //DataTable se usa para manejar los resultados de las consultas SQL de manera más flexible y eficiente
        //DataTable es una estructura de datos que permite almacenar y manipular datos tabulares en memoria, similar a una hoja de cálculo

      

        // Buscar en un rango de fechas
        public DataTable BuscarReservaPorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT * FROM Reserva WHERE Fecha BETWEEN @FechaDesde AND @FechaHasta"; // se usa BETWEEN para buscar reservas
                                                                                                        // en un rango de fechas
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FechaDesde", fechaDesde);
                    cmd.Parameters.AddWithValue("@FechaHasta", fechaHasta);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable tabla = new DataTable();
                    da.Fill(tabla);
                    return tabla;
                }
            }
        }

        // Mostrar todas las reservas
        public DataTable ObtenerTodasLasReservas()
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT * FROM Reserva";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable tabla = new DataTable();
                    da.Fill(tabla);
                    return tabla;
                }
            }
        }

        //metodo para no dejar reservar una habitacion que ya esta reservada en la misma fecha al reservar y al editar

        public bool ExisteConflictoReserva(int numeroHabitacion, DateTime nuevaFecha, int diasEstadia, int idReserva) 
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();

                //Count es una función de agregación que devuelve el número de filas que cumplen con la condición especificada
                string query = @"SELECT COUNT(*) FROM Reserva WHERE Numero_Habitacion = @Numero_Habitacion AND ID != @ID AND 
(@NuevaFecha < DATEADD(DAY, DiasEstadia, Fecha) AND DATEADD(DAY, @DiasEstadia, @NuevaFecha) > Fecha )";
                //!= es el operador de desigualdad que se utiliza para comparar dos valores y devuelve verdadero si son diferentes
                //DATEADD es una función que se utiliza para agregar un intervalo de tiempo a una fecha específica
                //NuevaFecha es la fecha de inicio de la nueva reserva, DAY es el intervalo de tiempo que se va a agregar,
                //y Fecha es la fecha de la reserva existente

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Numero_Habitacion", numeroHabitacion);
                    cmd.Parameters.AddWithValue("@NuevaFecha", nuevaFecha);
                    cmd.Parameters.AddWithValue("@DiasEstadia", diasEstadia);
                    cmd.Parameters.AddWithValue("@ID", idReserva);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        //metodo para marcar el correo como enviado, cuando se envia el correo de confirmacion de reserva
        public void MarcarCorreoComoEnviado(int idReserva)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "UPDATE Reserva SET CorreoEnviado = 1 WHERE ID = @ID";
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
                         WHERE Fecha >= @Hoy AND CorreoEnviado = 0";

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




    }
}

