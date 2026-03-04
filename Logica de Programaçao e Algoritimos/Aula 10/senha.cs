using static System.Console;
//Declaração de variaveis 
const int SENHAFIXA = 2002;
int senha;
//Entrada de dados
Write("Digite a senha: ");
senha = int.Parse(ReadLine());
//Processamento de dados
while (senha != SENHAFIXA)
{
    Write("Senha incorreta, digite novamente");
    senha = int.Parse(ReadLine());
}
WriteLine("Acesso permitido!");



