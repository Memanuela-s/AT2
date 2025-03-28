namespace AT2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            {// Cria um novo usuário com os dados do formulário
                Usuario novoUsuario = new Usuario()
                {
                    Nome = textNome.Text,
                    Telefone = textTel.Text,
                };

                // Chama o método para salvar no banco de dados 
                bool sucesso = Database.SalvarUsuario(novoUsuario);
                //Implemente um messagebox para caso dê sucesso ou caso não dê sucesso;
                if (sucesso)
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar usuário! Telefone já existe ou ocorreu um problema.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView listView = sender as ListView;

            if (listView.SelectedItems.Count > 0) // Verifica se há um item selecionado
            {
                string nome = listView.SelectedItems[0].SubItems[0].Text;
                string telefone = listView.SelectedItems[0].SubItems[1].Text;

                MessageBox.Show($"Nome: {nome}\nTelefone: {telefone}", "Contato Selecionado");
            }
        }
    }
}
