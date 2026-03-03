using System.Reflection;
using static System.Console;
// Declaração de variaveis 
double contagem = 0, alturaMaxima, alturaMinima, pessoas;
try
{
    WriteLine("Digite o número de alturas das pessoas: ");
    pessoas = double.Parse(ReadLine());
    WriteLine("Digite a altura mínima (cm): ");
    alturaMinima = double.Parse(ReadLine());
    WriteLine("Digite a altura máxima (cm): ");
    alturaMaxima = double.Parse(ReadLine());
   for (double pessoa = 0; pessoa < pessoas; pessoa++)
    {
        WriteLine($"Digite a altura da pessoa {pessoa +1}:");
        double alturaPessoa = double.Parse(ReadLine());
        if (alturaPessoa >= alturaMinima && alturaPessoa <= alturaMaxima)
        {
            WriteLine($"A altura da pessoa {pessoa+1} está dentro do intervalo permitido.");
            contagem++;
        }
        else
        {
            WriteLine($"A altura da pessoa {pessoa +1} está fora do intervalo permitido.");
        }
    }
    WriteLine($"O número de pessoas com altura dentro do intervalo é: {contagem}");
}
catch (Exception ex)
{
    WriteLine($"Valor inválido, erro = {ex.Message}");
}