using PPAI_Grupo14.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Grupo14
{
    public class AccesoADatos
    {
        public static DataTable ObtenerEscuelas()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM Escuela";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                cn.Close();

            }

        }

        public static DataTable ObtenerSedes()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM Sede";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                cn.Close();

            }

        }

        public static DataTable ObtenerTiposVisitas()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM TipoVisita";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                cn.Close();

            }

        }

        internal static DataTable Obtener_exposiciones(string tipo_visita)
        {
            // Selecciona todas las exposiciones que tengan el tipo de visita "tipo visita"
            throw new NotImplementedException();
        }

        internal static DateTime Calcular_duracion(List<Exposicion> lista_expo_selecc)
        {
            // Por cada exposicion de la lista va al detalleExposicion y desde ahi a la/s obra/s que tiene asignada y obtiene la suma de sus duraciones.
            // DEVUELVE UN SOLO TIEMPO TOTAL
            throw new NotImplementedException();
        }
    }
}
