using AplicativoDesktop01.Classes.DTO;
using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using static System.Net.WebRequestMethods;



namespace AplicativoDesktop01
{
    public partial class TelaLogin : Form
    {

        private static readonly HttpClient clientHttp = new();
        private const string urlApiLogin = "http://localhost:5004/api/ususarios/login";



        public TelaLogin()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var dadosLogin = new LoginRequestDTO
            {
                Email = textBox1.Text.Trim(),
                Senha = textBox2.Text.Trim(),
            };

            try
            {
                var resposta = await clientHttp.PostAsJsonAsync(urlApiLogin, dadosLogin);
                
                if (resposta.StatusCode == HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("Usuário ou senha incorretos.");
                    return;
                }

                else if (!resposta.IsSuccessStatusCode)
                {
                    var mensagemErro = await resposta.Content.ReadAsStringAsync();
                    MessageBox.Show($"Não foi possível autenticar. Detalhes {mensagemErro}");
                        return;
                }

                var resultado = await resposta.Content.ReadFromJsonAsync<LoginResponseDTO>();
                
                if (resultado.Regra != 1)
                {
                    MessageBox.Show("Acesso Negado. Este usário não tem privilégios administrativo");
                    return;
                }

                MessageBox.Show("Login realizado com sucesso");
                this.Hide();
                using (var telaAdmin = new TelaAdmin())
                {
                    telaAdmin.ShowDialog();
                }
                this.Close();
            }

            catch (HttpRequestException)
            {
                MessageBox.Show("Não foi possível conectar na API");
            }

        }
         
    }
}



namespace AplicativoDesktop01
{
    public partial class TelaLogin
    {
        // Tratador de eventos referenciado no Designer:
        private void label2_Click(object sender, EventArgs e)
        {
            // Ação segura e útil ao clicar no rótulo:
            // por exemplo, mover o foco para o campo de usuário (textBox1).
            if (textBox1 != null && !textBox1.IsDisposed)
            {
                textBox1.Focus();
            }
        }
    }
}
