using System.Reflection;
using static System.Console;
// Declaração de variaveis 
double contagem = 0, alturaMaxima, alturaMinima, visitantes;
try
{
    WriteLine("Digite o número de visitantes: ");
    visitantes = double.Parse(ReadLine());
    WriteLine("Digite a altura mínima (cm): ");
    alturaMinima = double.Parse(ReadLine());
    WriteLine("Digite a altura máxima (cm): ");
    alturaMaxima = double.Parse(ReadLine());
   for (double pessoa = 0; pessoa < visitantes; pessoa++)
    {
        WriteLine($"Digite a altura do visitante {pessoa +1}:");
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