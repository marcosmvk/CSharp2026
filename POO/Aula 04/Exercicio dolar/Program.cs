using Exercicio1;
using static System.Console;

double cotacao, qtde;

//Entrada de dados
Write("Qual é cotação do dolar ");
cotacao = double.Parse(Console.ReadLine());
Write("Quantos dolares você vai comprar? ");
qtde = double.Parse(Console.ReadLine());

double total = ConversorDeMoeda.Converter(cotacao,qtde);
//Saida de dados 
WriteLine($"Total a pagar em reais:{total}");

ReadKey();