using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.GestorSQL
{
    public class GomaDao
    {
        private static string cadenaConexion;
        static GomaDao()
        {
            cadenaConexion = "Server=.;Database=UtilesTP;Trusted_Connection=True;";
        }
        public static void Alta(Goma goma)
        {
            string query = "insert into Goma (marca, precio) values (@marca,@precio)";
            try
            {
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {

                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("marca", goma.Marca);
                    cmd.Parameters.AddWithValue("precio", goma.Precio);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al dar de alta", ex);
            }
        }
        public static List<Utiles> LeerListaDeGomas()
        {
            List<Utiles> gomas = new List<Utiles>();
            string query = "select * from Goma";
            try
            {
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //Mientras pueda leer - tenga contenido en mi reader--lee fila a fila
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string marca = reader.GetString(1);
                        int precio = reader.GetInt32(2);

                        Goma Goma = new Goma(marca, precio);
                        Goma.Id = id;
                        gomas.Add(Goma);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Al Leer Lista", ex);
            }
            return gomas;
        }

    }
}
