using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Security_v20.DataAccess.Models;


namespace Security_v20.DataAccess.Repositories

{
    public class RegistroEmpleadoRepository
    {
        public bool GuardarRegistro(RegistroEmpleado registro)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                string query = @"
                    INSERT INTO RegistroEmpleados 
                    (NombreEmpleado, NumeroEmpleado, Departamento, Turno, Casco, Arnes, LineaVida, EquipoElevacion, Fecha) 
                    VALUES 
                    (@NombreEmpleado, @NumeroEmpleado, @Departamento, @Turno, @Casco, @Arnes, @LineaVida, @EquipoElevacion, @Fecha)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@NombreEmpleado", registro.NombreEmpleado);
                cmd.Parameters.AddWithValue("@NumeroEmpleado", registro.NumeroEmpleado);
                cmd.Parameters.AddWithValue("@Departamento", registro.Departamento);
                cmd.Parameters.AddWithValue("@Turno", registro.Turno);
                cmd.Parameters.AddWithValue("@Casco", registro.Casco);
                cmd.Parameters.AddWithValue("@Arnes", registro.Arnes);
                cmd.Parameters.AddWithValue("@LineaVida", registro.LineaVida);
                cmd.Parameters.AddWithValue("@EquipoElevacion", registro.EquipoElevacion);
                cmd.Parameters.AddWithValue("@Fecha", registro.Fecha);

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        public RegistroEmpleado BuscarPorNumeroYFecha(string numeroEmpleado, string fecha)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                string query = "SELECT * FROM RegistroEmpleados WHERE NumeroEmpleado = @NumeroEmpleado AND Fecha = @Fecha";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NumeroEmpleado", numeroEmpleado);
                cmd.Parameters.AddWithValue("@Fecha", fecha);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new RegistroEmpleado
                    {
                        NombreEmpleado = reader["NombreEmpleado"].ToString(),
                        NumeroEmpleado = reader["NumeroEmpleado"].ToString(),
                        Departamento = reader["Departamento"].ToString(),
                        Turno = reader["Turno"].ToString(),
                        Casco = (bool)reader["Casco"],
                        Arnes = (bool)reader["Arnes"],
                        LineaVida = (bool)reader["LineaVida"],
                        EquipoElevacion = reader["EquipoElevacion"].ToString(),
                        Fecha = reader["Fecha"].ToString()
                    };
                }

                return null;
            }
        }

        public void EliminarPorNumeroYFecha(string numeroEmpleado, string fecha)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                string query = "DELETE FROM RegistroEmpleados WHERE NumeroEmpleado = @NumeroEmpleado AND Fecha = @Fecha";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NumeroEmpleado", numeroEmpleado);
                cmd.Parameters.AddWithValue("@Fecha", fecha);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
