using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using EntidadesExcepciones;
using EntidadesTp3;

namespace BaseDatos
{
    public class EquipoDao
    {
        private static string cadenaConexion;
        private static SqlCommand comando;
        private static SqlConnection conexion;

        static EquipoDao()
        {
            cadenaConexion = @"Data Source=.;Initial Catalog=TP4;Integrated Security=True";

            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;
            // comando = new SqlCommand(commandtype,conexion);

        }
        public static List<Equipo> Leer()
        {
            try
            {
                List<Equipo> listBibliotecas = new List<Equipo>();
                conexion.Open();

                comando.CommandText = "SELECT *FROM EQUIPOS";

                using (SqlDataReader dataReader = comando.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        double montoPagado = 0;
                        DateTime fechaPago = new DateTime();
                        string historiaPago = "";

                        if (!System.DBNull.Value.Equals(dataReader["MONTO_PAGADO"]))
                            montoPagado = Convert.ToDouble(dataReader["MONTO_PAGADO"]);

                        if (!System.DBNull.Value.Equals(dataReader["FECHA_PAGO"]))
                            fechaPago = Convert.ToDateTime(dataReader["FECHA_PAGO"]);

                        if (!System.DBNull.Value.Equals(dataReader["HISTORIAL_PAGO"]))
                            historiaPago += dataReader["HISTORIAL_PAGO"].ToString();


                        listBibliotecas.Add(new Equipo(Convert.ToInt32(dataReader["CODIGO_EQUIPO"]),
                            dataReader["NOMBRE"].ToString(),
                            montoPagado,
                            fechaPago,
                            historiaPago));


                    }
                }
                return listBibliotecas;

            }
            catch (Exception ex)
            {

                throw new ArchivoInvalidoIdException($"Error al cargar Base de Datos");
            }
            finally
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
            }

        }

        public static Equipo LeerPorId(int codigoJuego)
        {
            try
            {
                Equipo equipo = null;
                comando.Parameters.Clear();
                conexion.Open();
                //modificar Ruta
                comando.CommandText = $"SELECT * FROM EQUIPOS WHERE CODIGO_EQUIPO= @CODIGO_EQUIPO";
                comando.Parameters.AddWithValue("@CODIGO_EQUIPO", codigoJuego); //Parametrizar Consulta

                using (SqlDataReader dataReader = comando.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        equipo = new Equipo(Convert.ToInt32(dataReader["CODIGO_EQUIPO"]),
                            dataReader["NOMBRE"].ToString(),
                            Convert.ToInt32(dataReader["MONTO_PAGADO"]),
                            Convert.ToDateTime(dataReader["FECHA_PAGO"]),
                            dataReader["HISTORIAL_PAGO"].ToString()
                            );

                    }
                }

                return equipo;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
            }
        }
        public static bool Guardar(Equipo equipo)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                //Guarda
                comando.CommandText = $"INSERT INTO EQUIPOS (NOMBRE) VALUES (@NOMBRE)";
                comando.Parameters.AddWithValue("@NOMBRE", equipo.NombreEquipo);

                int rows = comando.ExecuteNonQuery();
                if (rows > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
            }

        }
        public static void GuardarListaEquipos(List<Equipo> lista)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                //Guarda
                foreach (Equipo item in lista)
                {
                    comando.CommandText = $"INSERT INTO EQUIPOS (NOMBRE,MONTO_PAGADO,HISTORIAL_PAGO,FECHA_PAGO) VALUES (@NOMBRE,@MONTO_PAGADO,@HISTORIAL_PAGO,@FECHA_PAGO)";
                    comando.Parameters.AddWithValue("@NOMBRE", item.NombreEquipo);
                    comando.Parameters.AddWithValue("@MONTO_PAGADO", item.MontoPagado);

                    if (item.HistorialDePago is not null)
                    {
                        comando.Parameters.AddWithValue("@HISTORIAL_PAGO", item.HistorialDePago);

                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@HISTORIAL_PAGO", " ");

                    }

                    comando.Parameters.AddWithValue("@FECHA_PAGO", item.FechaDePgo1);


                    int rows = comando.ExecuteNonQuery();
                    comando.Parameters.Clear();

                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
            }

        }
        public static bool Eliminar(int id)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();

                comando.CommandText = $"DELETE FROM EQUIPOS where CODIGO_EQUIPO = @CODIGO_EQUIPO";
                comando.Parameters.AddWithValue("@CODIGO_EQUIPO", id);

                int rows = comando.ExecuteNonQuery();
                if (rows > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
            }

        }
        public static bool Modificar(Equipo equipo, string nombre)
        {
            try
            {
                conexion.Open();
                // comando.CommandText = $"UPDATE JUEGOS SET NOMBRE = '{juego.Nombre}' WHERE CODIGO_JUEGO={juego.CodigoJuego}"
                //Guarda
                comando.CommandText = $"UPDATE EQUIPOS SET NOMBRE = '{nombre}' WHERE CODIGO_EQUIPO='{equipo.Id}'";

                int rows = comando.ExecuteNonQuery();
                if (rows > 0)
                {
                    return true;
                }
                return false;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
            }

        }
        public static bool CargarBaseDatoPagoEquipo(Equipo equipo)
        {
            try
            {
                conexion.Open();
                // comando.CommandText = $"UPDATE JUEGOS SET NOMBRE = '{juego.Nombre}' WHERE CODIGO_JUEGO={juego.CodigoJuego}"
                //Guarda

                comando.CommandText = $"UPDATE EQUIPOS SET MONTO_PAGADO = (@MONTO_PAGADO)" +
                    $",HISTORIAL_PAGO = (@HISTORIAL_PAGO)" +
                    $",FECHA_PAGO = (@FECHA_PAGO)" +
                    $" where CODIGO_EQUIPO = '{equipo.Id}'";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@MONTO_PAGADO", equipo.MontoPagado);
                comando.Parameters.AddWithValue("@HISTORIAL_PAGO", equipo.HistorialDePago);
                comando.Parameters.AddWithValue("@FECHA_PAGO", equipo.FechaDePgo1);

                int rows = comando.ExecuteNonQuery();
                if (rows > 0)
                {
                    return true;
                }
                return false;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
            }

        }
    }
}
