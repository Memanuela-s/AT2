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

  public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Criando ListView
            ListView listView1 = new ListView();
            listView1.Bounds = new System.Drawing.Rectangle(10, 10, 300, 200);
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            // Adicionando colunas
            listView1.Columns.Add("Nome", 150);
            listView1.Columns.Add("Telefone", 130);

            // Adicionar ao formulário
            this.Controls.Add(listView1);

            // Buscar dados do banco e preencher ListView
            CarregarDados(listView1);
        }

        private void CarregarDados(ListView listView)
        {
            string connectionString = "Server=SEU_SERVIDOR;Database=MeuBanco;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Nome, Telefone FROM Contatos";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            listView.Items.Clear();

                            while (reader.Read())
                            {
                                string nome = reader["Nome"].ToString();
                                string telefone = reader["Telefone"].ToString();

                                listView.Items.Add(new ListViewItem(new[] { nome, telefone }));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar dados: " + ex.Message);
                }
            }
        }
    }
}