using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT2
{
    public static class Database
    {
        private static string connectionString = "server=localhost;port=3306;user id=root;database=ti_113_windowsforms;";

        public static bool SalvarUsuario(Usuario usuario)
        {
            using (MySqlConnection conexão = new MySqlConnection(connectionString))
            {
                conexão.Open();
                string queryCheck = "SELECT COUNT(*) FROM Usuarios WHERE Telefone = @Telefone";
                using (MySqlCommand cmdCheck = new MySqlCommand(queryCheck, conexão))
                {
                    cmdCheck.Parameters.AddWithValue("@Telefone", usuario.Telefone);
                    int count = Convert.ToInt32(cmdCheck.ExecuteScalar());
                    if (count > 0) return false;
                }

                string queryInsert = "INSERT INTO Usuarios (Nome, Telefone) VALUES (@Nome, @Telefone)";
                using (MySqlCommand cmdInsert = new MySqlCommand(queryInsert, conexão))
                {
                    cmdInsert.Parameters.AddWithValue("@Nome", usuario.Nome);
                    cmdInsert.Parameters.AddWithValue("@Telefone", usuario.Telefone);
                    cmdInsert.ExecuteNonQuery();
                }
            }
            return true;
        }
    }
}

 