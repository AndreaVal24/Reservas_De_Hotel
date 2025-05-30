using System;
using Microsoft.Data.SqlClient;
using Microsoft.Win32.SafeHandles;

namespace CapaDatos
{
    public class Reserva
    {
        //atributos de la base de datos
        public int ID;
        public string Cliente;
        public string Habitacion;
        public int Numero_Habitacion;
        public DateTime Fecha;
      
    }
    public class Simple : Reserva 
    {
        public decimal Precio = 10000;
    }

    public class ConDesayuno : Reserva
    {
        public decimal Precio = 15000;
    }
    //clase para la conexion de datos
    public class ReservaDatos
    {
        public string conexion = "Server=.;Database=Hotel;Integrated Security=true" + " ;TrustServerCertificate=True;";

        //metodo para calcular el costo final
        public Reserva CalcularCostoFinal(int idReserva)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();

                string query = "SELECT * FROM Reserva WHERE ID = @ID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", idReserva);

                //EJECUTAR CONSULTA
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) 
                { 
                    //determina tipo de habitacion
                string habitacion = reader["Habitacion"].ToString();
                    Reserva reserva;

                    if (habitacion == "Simple")
                    {
                        reserva = new Simple();
                        
                    }
                    else
                    {
                        reserva = new ConDesayuno();
                       
                    }

                    //asignar valores desde  sql
                    reserva.ID = (int)reader["ID"];
                    reserva.Cliente = reader["Cliente"].ToString();
                    reserva.Habitacion = habitacion;
                    reserva.Numero_Habitacion = (int)reader["Numero_Habitacion"];
                    reserva.Fecha = (DateTime)reader["Fecha"];

                    return reserva;
                }
                return null;
            }
        }
    }
    

}
