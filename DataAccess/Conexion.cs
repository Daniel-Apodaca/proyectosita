using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_v20.DataAccess
{
    public static class Conexion
    {
        private static readonly string connectionString = "Server=Vampel;Database=SecurityDB;Trusted_Connection=True;";

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(connectionString);
        }
    }
}
