//Exercicio de lista com a esstrutura de repetição for
using static System.Console;

//Declaração de variaveis
int n;
List<double> numeros = new List<double>();
//Entrada de dados 
Write("Quantos números você vai digitar: ");
n = int.Parse(ReadLine());
for (int i = 0; i < n ; i++)
{
    Write("Digite um número: ");
    numeros.Add(double.Parse(ReadLine()));
}
    Write("Valores = ");

for (int i = 0; i < n ; i++)
{
    Write($" {numeros[i]}");
}

Write($"\nSoma= {numeros.Sum()}");
Write($"\nMedia= {numeros.Average()}");