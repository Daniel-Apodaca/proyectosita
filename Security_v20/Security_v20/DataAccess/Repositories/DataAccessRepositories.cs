using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encuesta.DataAccess.Models;
using Security_v20.DataAccess;

namespace Encuesta.DataAccess.Repositories
{
    public class UsoEquipamientoRepository
    {
        public bool Guardar(UsoEquipamiento uso)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                string query = @"INSERT INTO UsoEquipamiento (NumeroEmpleado, NombreEmpleado, NombreEquipo, MotivoDesuso, Fecha, Hora)
                                 VALUES (@Numero, @Nombre, @Equipo, @Motivo, @Fecha, @Hora)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Numero", uso.NumeroEmpleado);
                cmd.Parameters.AddWithValue("@Nombre", uso.NombreEmpleado);
                cmd.Parameters.AddWithValue("@Equipo", uso.NombreEquipo);
                cmd.Parameters.AddWithValue("@Motivo", uso.MotivoDesuso);
                cmd.Parameters.AddWithValue("@Fecha", uso.Fecha);
                cmd.Parameters.AddWithValue("@Hora", uso.Hora);

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }
    }
}
