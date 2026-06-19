using Microsoft.Data.SqlClient;
using ProjetoAPI01.Classes.DTO;

namespace ProjetoAPI01.Classes.Repositorio
{
    public class RepositorioUsuario
    {
        private readonly string stringConexao;

        public RepositorioUsuario(string conexao)
        {
            this.stringConexao = conexao;
        }

        //Consulta do usuário por email e senha, retorna somente dados necessários para o login

        public async Task<UsuarioDTO?> BuscarPorEmailesenha( 
         string email, string senha, CancellationToken cancellationToken)
        {
            await using var conexao = new SqlConnection(stringConexao);
            await conexao.OpenAsync(cancellationToken);

            const string comandoSQL = """
                 SELECT TOP 1 ID, Nome, Regra 
                 FROM Alunos 
                 WHERE Email = @email AND Senha = @senha  
                 """;
            await using var comando = new SqlCommand(comandoSQL, conexao);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@senha", senha);

            await using var leitor = await comando.ExecuteReaderAsync(cancellationToken);
            
            if (!await leitor.ReadAsync(cancellationToken))
            {
                return null;
            }

            return new UsuarioDTO
            {
                Id = leitor.GetInt32(leitor.GetOrdinal("ID")),
                Nome = leitor.GetString(leitor.GetOrdinal("Nome")),
                Regra = leitor.GetInt32(leitor.GetOrdinal("Regra"))
            };
            
        }

        public async Task<List<UsuarioDTO>> ListarTodos(CancellationToken cancellationToken)
        {
            var usuarios = new List<UsuarioDTO>();
            await using var conexao = new SqlConnection(stringConexao);
            await conexao.OpenAsync(cancellationToken);

            const string comandoSQL = "SELECT ID, Nome, Regra, Email FROM Alunos";
            await using var comando = new SqlCommand(comandoSQL, conexao);
            await using var leitor = await comando.ExecuteReaderAsync(cancellationToken);

            while (await leitor.ReadAsync(cancellationToken))
            {
                usuarios.Add(new UsuarioDTO
                {
                    Id = leitor.GetInt32(leitor.GetOrdinal("ID")),
                    Nome = leitor.GetString(leitor.GetOrdinal("Nome")),
                    Regra = leitor.GetInt32(leitor.GetOrdinal("Regra")),
                    Email = leitor.IsDBNull(leitor.GetOrdinal("Email")) ? string.Empty : leitor.GetString(leitor.GetOrdinal("Email"))
                });
            }

            return usuarios;
        }

        public async Task<bool> AprovarUsuario(int id, CancellationToken cancellationToken)
        {
            await using var conexao = new SqlConnection(stringConexao);
            await conexao.OpenAsync(cancellationToken);

            const string comandoSQL = "UPDATE Alunos SET Regra = 1 WHERE ID = @id";
            await using var comando = new SqlCommand(comandoSQL, conexao);
            comando.Parameters.AddWithValue("@id", id);

            var linhasAfetadas = await comando.ExecuteNonQueryAsync(cancellationToken);
            return linhasAfetadas > 0;
        }
    }

}
