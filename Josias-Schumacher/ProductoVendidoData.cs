using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Josias_Schumacher
{
    public class ProductoVendidoData
    {
        private string stringConnection;

        public ProductoVendidoData()
        {
            this.stringConnection = "Server=DESKTOP-V3GCP17\\SQLEXPRESS;Database=coderhouse;Trusted_Connection=True;";
        }

        public static ProductoVendido ObtenerProductoVendido(int id)
        {
            ProductoVendido productoVendido = null;

            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {
                string query = "SELECT * FROM ProductoVendido WHERE id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                       
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener producto vendido: " + ex.Message);
                }
            }

            return productoVendido;
        }

        public static List<ProductoVendido> ListarProductosVendidos()
        {
            List<ProductoVendido> productosVendidos = new List<ProductoVendido>();

            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {
                string query = "SELECT * FROM ProductoVendido";

                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                       
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al listar productos vendidos: " + ex.Message);
                }
            }

            return productosVendidos;
        }

        public static void CrearProductoVendido(ProductoVendido productoVendido)
        {
            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {
                
            }
        }

        public static void ModificarProductoVendido(ProductoVendido productoVendido)
        {
            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {
              
            }
        }

        public static void EliminarProductoVendido(int id)
        {
            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {
                
            }
        }
    }

}
