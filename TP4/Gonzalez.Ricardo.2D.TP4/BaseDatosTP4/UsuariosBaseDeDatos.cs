using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BaseDatosTP4
{
    public static class UsuariosBaseDeDatos
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static UsuariosBaseDeDatos()
        {

            //connectionString = @"Data Source =.;Initial Catalog=UTN_DB;Integrated Segurity = True";
            connectionString = @"Data Source=.;Initial Catalog=Empresa_DB;Integrated Security=True";

            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.CommandType = CommandType.Text;
            command.Connection = connection;
        }
        public static List<> Leer()
        {
            try
            {
                List<Persona> list = new List<Persona>();
                connection.Open();

                command.CommandText = "SELECT *FROM EMPLEADO";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Persona(reader["NOMBRE"].ToString(), Convert.ToInt32(reader["ID_EMPLEADO"])));
                    }
                }
                return list;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
