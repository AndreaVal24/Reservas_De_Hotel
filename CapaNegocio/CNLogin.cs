using CapaDatos;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;



namespace CapaNegocio
{
    //clase CNUsuario, donde se maneja la logica de negocio relacionada con los usuarios
    public class CNUsuario
    {
        
    private Conexion conexion = new Conexion();

        //metodo para verificar el login de un usuario

        public string VerificarLogin(string usuario, string contrasena)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT Rol FROM Usuarios WHERE Usuario = @Usuario AND Contrasena = @Contrasena"; // Consulta SQL para verificar
                                                                                                                 // el usuario y contraseña

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Usuario", usuario);  // Agrega el parámetro de usuario a la consulta
                    cmd.Parameters.AddWithValue("@Contrasena", contrasena); // Agrega el parámetro de contraseña a la consulta

                    object resultado = cmd.ExecuteScalar(); // Ejecuta la consulta y obtiene el resultado
                    return resultado != null ? resultado.ToString() : null; // Si el resultado no es nulo, devuelve el rol del usuario,
                                                                            // de lo contrario devuelve null
                }
            }
        }
    }




}

