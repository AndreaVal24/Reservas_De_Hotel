using CapaDatos;
using ClosedXML.Excel;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaNegocio
{
    public class EmpleadoNegocio
    {
        private Conexion conexion = new Conexion();


        //metodo para obtener todos los empleados
        public int InsertarEmpleado(Empleado empleado)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "INSERT INTO Empleados (Nombre, Cedula, Cargo, Sueldo, Fecha_Ingreso) " +
                               "VALUES (@Nombre, @Cedula, @Cargo, @Sueldo, @Fecha_Ingreso)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                    cmd.Parameters.AddWithValue("@Cedula", empleado.Cedula);
                    cmd.Parameters.AddWithValue("@Cargo", empleado.Cargo);
                    cmd.Parameters.AddWithValue("@Sueldo", empleado.Sueldo);
                    cmd.Parameters.AddWithValue("@Fecha_Ingreso", empleado.Fecha_Ingreso);
                    return cmd.ExecuteNonQuery(); // Devuelve el número de filas afectadas
                }
            }
        }

        //metodo para eliminar empleado
        public void EliminarEmpleado(int idEmpleado)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "DELETE FROM Empleados WHERE ID = @ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", idEmpleado);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        //metodo para calcular el sueldo de un empleado segun su cargo
        public Empleado CalcularSueldo(int idEmpleado)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT * FROM Empleados WHERE ID = @ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", idEmpleado);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nombre = reader["Nombre"].ToString();
                            string cedula = reader["Cedula"].ToString();
                            string cargo = reader["Cargo"].ToString();
                            DateTime fechaIngreso = (DateTime)reader["Fecha_Ingreso"];
                            int id = (int)reader["ID"];

                            Empleado empleado;

                            // Instanciamos según el cargo
                            if (cargo == "Gerente")
                                empleado = new Gerente(nombre, cedula, fechaIngreso);
                            else if (cargo == "Chef")
                                empleado = new Chef(nombre, cedula, fechaIngreso);
                            else if (cargo == "Recepcionista")
                                empleado = new Recepcionista(nombre, cedula, fechaIngreso);
                            else if (cargo == "Personal de Limpieza")
                                empleado = new Limpieza(nombre, cedula, fechaIngreso);
                            else if (cargo == "Personal de Mantenimiento")
                                empleado = new Mantenimiento(nombre, cedula, fechaIngreso);
                            else if (cargo == "Personal de Seguridad")
                                empleado = new Seguridad(nombre, cedula, fechaIngreso);
                            else
                                return null; // Si el cargo no coincide con ninguno conocido

                            empleado.ID = id;
                            empleado.Cargo = cargo;

                            // Asignamos el sueldo
                            if (empleado is Recepcionista r)
                                empleado.Sueldo = r.sueldoR();
                            else
                                empleado.Sueldo = empleado.sueldoGC();

                            return empleado;
                        }
                    }
                }
            }

            return null; // Si no se encuentra el empleado
        }



        //metodo para editar empleado
        public void EditarEmpleado(Empleado empleado)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "UPDATE Empleados SET Nombre = @Nombre, Cedula = @Cedula, Cargo = @Cargo, Sueldo = @Sueldo, " +
                    "Fecha_Ingreso = @Fecha_Ingreso WHERE ID = @ID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", empleado.ID);
                    cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                    cmd.Parameters.AddWithValue("@Cedula", empleado.Cedula);
                    cmd.Parameters.AddWithValue("@Cargo", empleado.Cargo);
                    cmd.Parameters.AddWithValue("@Sueldo", empleado.Sueldo);
                    cmd.Parameters.AddWithValue("@Fecha_Ingreso", empleado.Fecha_Ingreso);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        // Buscar por cédula
        //el datatable es un tipo de dato que permite almacenar datos en forma de tabla, similar a una hoja de cálculo
        public DataTable BuscarEmpleadoPorCedula(string cedula)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT * FROM Empleados WHERE Cedula = @Cedula";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Cedula", cedula);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable tabla = new DataTable();
                    da.Fill(tabla);
                    return tabla;
                }
            }
        }

        //boton para mostrar de nuevo todos los empleados
        public DataTable MostrarEmpleados()
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT * FROM Empleados";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable tabla = new DataTable();
                    da.Fill(tabla);
                    return tabla;
                }
            }

        }


        //metodo para exportar los empleados a un archivo Excel
        public void ExportarEmpleadosAExcel(DataTable tabla, string rutaArchivo)
        {
            using (var wb = new XLWorkbook()) // Crea un nuevo libro de Excel
            {
                var ws = wb.Worksheets.Add("Empleados"); // Agrega una nueva hoja de trabajo llamada "Empleados"

                // Configura el encabezado del reporte
                ws.Cell("A1").Value = "Lemon Resort";
                ws.Cell("A2").Value = $"Reporte de Empleados - {DateTime.Now:dd/MM/yyyy hh:mm tt}";
                ws.Range("A1:E1").Merge().Style.Font.SetBold().Font.FontSize = 16;
                ws.Range("A2:E2").Merge().Style.Font.SetItalic().Font.FontSize = 12;
                ws.Range("A1:E2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                for (int i = 0; i < tabla.Columns.Count; i++)
                {
                    ws.Cell(4, i + 1).Value = tabla.Columns[i].ColumnName;
                    ws.Cell(4, i + 1).Style.Font.Bold = true;
                    ws.Cell(4, i + 1).Style.Fill.BackgroundColor = XLColor.LightBlue;
                }
                
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    for (int j = 0; j < tabla.Columns.Count; j++)
                    {
                        ws.Cell(i + 5, j + 1).Value = tabla.Rows[i][j]?.ToString();
                    }
                }

                ws.Columns().AdjustToContents(); // Ajusta el ancho de las columnas al contenido
                wb.SaveAs(rutaArchivo);  // Guarda el libro de Excel en la ruta especificada
                Process.Start(new ProcessStartInfo(rutaArchivo) { UseShellExecute = true }); // Abre el archivo Excel después de guardarlo
            }
        }
    }
}
