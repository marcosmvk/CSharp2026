using System.Net;
using static System.Console;
//Declaração de variaveis
double bas, altura, area, perimetro, diagonal;
//Entrada de dados 
Write("Digite a base do retangulo: ");
bas = double.Parse(ReadLine());
Write("Digite a altura do retangulo: ");
altura = double.Parse(ReadLine());
//Processamento de dados 
area = bas * altura;
perimetro = 2 * (bas + altura);
diagonal = Math.Sqrt((bas * bas) + (altura * altura));
//Saida de dados 
WriteLine($"O valor da area é {area}, perimetro {perimetro} e diagonal  {diagonal}");

