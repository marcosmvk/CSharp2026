using Projet_Web_01.Dados;
using Projet_Web_01.Classes.Entidades;

namespace ProjetoWeb01.Classes.Serv
{
    public class AlunoService
    {
        //campo 
        private readonly AlunoContext dbContext;

        //Construtor
        public AlunoService(AlunoContext dbContext)
        {
            this.dbContext = dbContext;
        }

        //Tarefa
        public async Task<ResultadoCadastro> CadastrarAluno(Aluno aluno)
        {
            try
            {
                //Validãção básica
                if (string.IsNullOrWhiteSpace(aluno.Nome))
                {
                    return new ResultadoCadastro
                    {
                        Sucesso = false,
                        Mensagem = "Por favor, informe o nome válido de aluno"
                    };
                }

                if 
                    (aluno.RA<= 0)
                {
                    return new ResultadoCadastro
                    {
                        Sucesso = false,
                        Mensagem = "Por favor, informe o RA válido"
                    };
                }

                if (aluno.CursoID<=0)
                { 
                    return new ResultadoCadastro
                       {
                        Sucesso = false,
                        Mensagem = "Por favor, informe o RA válido"
                       };
                }

                //Definir os status padrão para novos cadastros 
                aluno.StatusWIFI = "Inativo";
                aluno.StatusAction = "Aguardando aprovação";

                //Adicionar o aluno ao banco de dados
                dbContext.Alunos.Add(aluno);
                await dbContext.SaveChangesAsync();

                return new ResultadoCadastro
                {
                    Sucesso = true,
                    Mensagem = "Aluno cadastrado com sucesso!"
                };

            }
            catch (Exception ex)
            {
                return new ResultadoCadastro
                {
                    Sucesso = false,
                    Mensagem = $"Erro ao cadastrar o aluno: {ex.Message}"
                };
            }
        }


    }
}
