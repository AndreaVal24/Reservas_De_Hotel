using CapaDatos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
                            int cedula = (int)reader["Cedula"];
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
        //el datatable es una tabla que se usa para mostrar los datos en el datagridview
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
    }
}
