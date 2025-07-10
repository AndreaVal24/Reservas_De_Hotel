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
using ClosedXML.Excel;
using System.Diagnostics;


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
                            (Fecha < DATEADD(DAY, @DiasEstadia, @NuevaFecha) AND DATEADD(DAY, DiasEstadia, Fecha) > @NuevaFecha)";
                //!= es el operador de desigualdad que se utiliza para comparar dos valores y devuelve verdadero si son diferentes
                //DATEADD es una función que se utiliza para agreciagar un intervalo de tiempo a una fecha específica
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


        //metodo para exportar reservas a un archivo Excel
        public void ExportarReservasAExcel(DataTable tabla, string rutaArchivo)
        {
            using (var wb = new XLWorkbook()) //variable wb es una instancia de XLWorkbook, que representa un libro de trabajo de Excel
            {
                var ws = wb.Worksheets.Add("Reservas"); //ws es una instancia de la hoja de trabajo de Excel,
                                                        //que se agrega al libro de trabajo con el nombre "Reservas"

                //la estructura de la hoja de trabajo se define aquí, incluyendo el título y la fecha del reporte
                ws.Cell("A1").Value = "Lemon Resort";
                ws.Cell("A2").Value = $"Reporte de Reservas - {DateTime.Now:dd/MM/yyyy hh:mm tt}";
                ws.Range("A1:E1").Merge().Style.Font.SetBold().Font.FontSize = 16;
                ws.Range("A2:E2").Merge().Style.Font.SetItalic().Font.FontSize = 12;
                ws.Range("A1:E2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                
                for (int i = 0; i < tabla.Columns.Count; i++) 
                {
                    ws.Cell(4, i + 1).Value = tabla.Columns[i].ColumnName;
                    ws.Cell(4, i + 1).Style.Font.Bold = true;
                    ws.Cell(4, i + 1).Style.Fill.BackgroundColor = XLColor.LightGoldenrodYellow;
                }

                for (int i = 0; i < tabla.Rows.Count; i++) 
                {
                    for (int j = 0; j < tabla.Columns.Count; j++)
                    {
                        ws.Cell(i + 5, j + 1).Value = tabla.Rows[i][j]?.ToString();
                    }
                }

                ws.Columns().AdjustToContents(); // Ajusta el ancho de las columnas al contenido
                wb.SaveAs(rutaArchivo); // Guarda el libro de trabajo en la ruta especificada
                Process.Start(new ProcessStartInfo(rutaArchivo) { UseShellExecute = true }); // Abre el archivo Excel después de guardarlo
            }
        }



    }
}

