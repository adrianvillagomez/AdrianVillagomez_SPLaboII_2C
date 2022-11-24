using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.GestorSQL
{
    public class SacaPuntasDAO
    {
        private static string cadenaConexion;
        static SacaPuntasDAO()
        {
            cadenaConexion = "Server=.;Database=UtilesTP;Trusted_Connection=True;";
        }
        public static SacaPuntas LeerPorID(int id)
        {
            SacaPuntas sacapuntas = null;

            string query = "select * from SacaPuntas where id=@id";
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
                    string material = reader.GetString(3);
                    sacapuntas = new SacaPuntas(marca, precio, material);
                    sacapuntas.Id = id;
                }
            }
            return sacapuntas;
        }
        public static void Alta(SacaPuntas sacapuntas)
        {
            string query = "insert into SacaPuntas (marca, precio, material) values (@marca,@precio,@material)";
            try
            {
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {

                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("marca", sacapuntas.Marca);
                    cmd.Parameters.AddWithValue("precio", sacapuntas.Precio);
                    cmd.Parameters.AddWithValue("material", sacapuntas.Material);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al dar de alta", ex);
            }
        }
        public static void Eliminar(int id)
        {
            try
            {
                string query = "delete from SacaPuntas where id = @id";
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("id", id);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al dar de baja", ex);
            }
        }
        public static List<Utiles> LeerListaSacaPuntas()
        {
            List<Utiles> SacaPuntas = new List<Utiles>();
            string query = "select * from SacaPuntas";
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
                        string material = reader.GetString(3);

                        SacaPuntas sacaPuntas = new SacaPuntas(marca, precio, material);
                        sacaPuntas.Id = id;
                        SacaPuntas.Add(sacaPuntas);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Al Leer Lista", ex);
            }
            return SacaPuntas;
        }
        public static void Actualizar(SacaPuntas sacapuntas, int id)
        {


            string query = "update Sacapuntas set marca=@marca, precio=@precio, material=@material where id = @id";
            try
            {
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("marca", sacapuntas.Marca);
                    cmd.Parameters.AddWithValue("precio", sacapuntas.Precio);
                    cmd.Parameters.AddWithValue("material", sacapuntas.Material);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Erro al intentar actualizar");
            }
        }
    }
}
