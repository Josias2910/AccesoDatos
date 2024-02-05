using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Josias_Schumacher
{
    public class VentaData
    {
        private string stringConnection;

        public VentaData()
        {
            this.stringConnection = "Server=DESKTOP-V3GCP17\\SQLEXPRESS;Database=coderhouse;Trusted_Connection=True;";
        }

        public static Venta ObtenerVenta(int id)
        {
            Venta venta = null;

            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {
                string query = "SELECT * FROM Venta WHERE id = @Id";
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
                    Console.WriteLine("Error al obtener venta: " + ex.Message);
                }
            }

            return venta;
        }

        public static List<Venta> ListarVentas()
        {
            List<Venta> ventas = new List<Venta>();

            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {
                string query = "SELECT * FROM Venta";

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
                    Console.WriteLine("Error al listar ventas: " + ex.Message);
                }
            }

            return ventas;
        }

        public static void CrearVenta(Venta venta)
        {
            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {
                
            }
        }

        public static void ModificarVenta(Venta venta)
        {
            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {
                
            }
        }

        public static void EliminarVenta(int id)
        {
            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {
                
            }
        }
    }

}
