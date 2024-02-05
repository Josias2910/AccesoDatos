using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Josias_Schumacher
{
    public class UsuarioData
    {
        private string stringConnection;

        public UsuarioData()
        {
            this.stringConnection = "Server=DESKTOP-V3GCP17\\SQLEXPRESS;Database=coderhouse;Trusted_Connection=True;";
        }
        public static Usuario ObtenerUsuario(int id)
        {
            Usuario usuario = null;

            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {
                string query = "SELECT * FROM Usuario WHERE id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string nombre = reader.GetString(1);
                        string apellido = reader.GetString(2);
                        string nombreUsuario = reader.GetString(3);
                        string password = reader.GetString(4);
                        string mail = reader.GetString(5);

                        Usuario usuarios = new Usuario(id, nombre, apellido, nombreUsuario, password, mail);
                        return usuarios;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener usuario: " + ex.Message);
                }
            }

            return usuario;
        }
        public static List<Usuario> ListarUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {
                string query = "SELECT * FROM Usuario";

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
                    Console.WriteLine("Error al listar usuarios: " + ex.Message);
                }
            }

            return usuarios;
        }

        public static void CrearUsuario(Usuario usuario)
        {
            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {
                
            }
        }

        public static void ModificarUsuario(Usuario usuario)
        {
            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {

            }
        }

        public static void EliminarUsuario(int id)
        {
            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {

            }
        }
    }
}
