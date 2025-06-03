using System;
using Microsoft.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class Reserva
    {

        public Reserva() { }
        public int ID { get; set; }
        public string Cliente { get; set; }
        public string Habitacion { get; set; }
        public int Numero_Habitacion { get; set; }
        public DateTime Fecha { get; set; }
        public int DiasEstadia { get; set; }
        public decimal Precio { get; set; }
    }

    public class Simple : Reserva
    {
        public decimal Precio1 { get; set; } = 10000;
    }

    public class ConDesayuno : Reserva
    {
        public decimal Precio2 { get; set; } = 15000;
    }

    public class ReservaNegocio
    {
        private Conexion conexion = new Conexion();

        public int InsertarReserva(Reserva reserva)
        {

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();

                string query = "INSERT INTO Reserva (Cliente, Habitacion, Numero_Habitacion, Fecha, Precio, DiasEstadia) " +
                               "VALUES (@Cliente, @Habitacion, @Numero_Habitacion, @Fecha, @Precio, @DiasEstadia)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Cliente", reserva.Cliente);
                    cmd.Parameters.AddWithValue("@Habitacion", reserva.Habitacion);
                    cmd.Parameters.AddWithValue("@Numero_Habitacion", reserva.Numero_Habitacion);
                    cmd.Parameters.AddWithValue("@Fecha", reserva.Fecha);
                    cmd.Parameters.AddWithValue("@Precio", reserva.Precio);
                    cmd.Parameters.AddWithValue("@DiasEstadia", reserva.DiasEstadia);

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

                            return reserva;
                        }
                    }
                }
            }

            return null;
        }
    }
}

