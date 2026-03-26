using static System.Console;
using Banco;
using static System.Globalization.CultureInfo;



Title = "Abertura de conta";
ContaBancaria conta;

WriteLine("Abertura de conta - Nika Investiment");
Write("Entre com um número de conta: ");
int numero = int.Parse(Console.ReadLine());
Write("Entre com o nome do titular: ");
string nome = Console.ReadLine();
Write("Deseja fazer deósito inicial (s/n): ");
char resposta = char.Parse(Console.ReadLine().ToLower());

if (resposta == 's')
{
    Write("Entre com o valor de depósito inicial: ");
    double deposito = double.Parse(ReadLine());
     conta = new ContaBancaria(numero, nome, deposito);

}

else
{
     conta = new ContaBancaria(numero, nome);
}


conta.Dados();

WriteLine("Entre com um valor para depósito: R$ ");
double quantia = double.Parse(Console.ReadLine());      
conta.Deposito(quantia);
conta.Dados();
WriteLine("Entre com um valor para saque: R$ ");
quantia = double.Parse(Console.ReadLine());
conta.Saque(quantia);
conta.Dados();





ReadKey();