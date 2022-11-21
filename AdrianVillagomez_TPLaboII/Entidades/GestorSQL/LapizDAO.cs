using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.GestorSQL
{
    public static class LapizDAO
    {
        private static string cadenaConexion;
        static LapizDAO()
        {
            cadenaConexion = "Server=.;Database=UtilesTP;Trusted_Connection=True;";
        }
        public static Lapiz LeerPorID(int id)
        {
            Lapiz lapiz = null;

            string query = "select * from Lapiz where id=@id";
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("id", id);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    string marca = reader.GetString(1);
                    int precio = reader.GetInt32(2);
                    int color = reader.GetInt32(3);
                    Color color2;
                    Enum.TryParse<Color>(color.ToString(), out color2);
                    lapiz = new Lapiz( marca, precio, color2);
                    lapiz.Id= id;
                }
            }
            return lapiz;
        }
        public static void Alta(Lapiz lapiz)
        {
            string query = "insert into Lapiz (marca, precio, color) values (@marca,@precio,@color)";
            try
            {
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {

                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("marca", lapiz.Marca);
                    cmd.Parameters.AddWithValue("precio", lapiz.Precio);
                    cmd.Parameters.AddWithValue("color", lapiz.Color);
                   
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception ("Error al dar de alta",ex);
            }         
        }
    }
}
