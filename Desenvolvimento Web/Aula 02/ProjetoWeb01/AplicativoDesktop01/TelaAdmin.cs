using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicativoDesktop01
{
    public partial class TelaAdmin : Form
    {


        private static readonly HttpClient clientHttp = new();
        private const string urlApiBase = "http://localhost:5034/api/usuarios";


        public TelaAdmin()
        {
            InitializeComponent();
            Load += TelaAdmin_Load;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void TelaAdmin_Load(object? sender, EventArgs e)
        {
            await CarregarUsuarios();
        }

        private async Task CarregarUsuarios()
        {
            try
            {
                var usuarios = await clientHttp.GetFromJsonAsync<List<Classes.DTO.AdminResponseDTO>>(urlApiBase);
                if (usuarios is null) return;

                var binding = new BindingList<Classes.DTO.AdminResponseDTO>(usuarios);
                dataGridView1.DataSource = binding;
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("Não foi possível carregar usuários. Verifique se a API está em execução.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione um usuário para aprovar.");
                return;
            }

            if (dataGridView1.CurrentRow.DataBoundItem is not Classes.DTO.AdminResponseDTO usuario)
            {
                MessageBox.Show("Usuário inválido.");
                return;
            }

            var confirm = MessageBox.Show($"Aprovar o usuário '{usuario.Nome}'?", "Confirmação", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            try
            {
                var resposta = await clientHttp.PutAsync($"{urlApiBase}/{usuario.Id}/aprovar", null);
                if (resposta.IsSuccessStatusCode)
                {
                    MessageBox.Show("Usuário aprovado com sucesso.");
                    await CarregarUsuarios();
                }
                else if (resposta.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Usuário não encontrado.");
                }
                else
                {
                    var msg = await resposta.Content.ReadAsStringAsync();
                    MessageBox.Show($"Erro ao aprovar: {msg}");
                }
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("Erro de conexão com a API.");
            }
        }
    }
}
