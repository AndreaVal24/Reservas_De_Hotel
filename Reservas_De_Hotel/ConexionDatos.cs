using System;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        public string CadenaConexion = "Server=.;Database=Hotel;Integrated Security=true;TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(CadenaConexion);
        }
    }
}
