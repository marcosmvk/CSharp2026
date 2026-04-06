using BancoMaster;
using static System.Console;

WriteLine("Escolha qual conta deseja abrir: \n" +
    "\t1 - Conta comum\n" +
    "\t2 - Conta Poupança\n" +
    "\t3 - Conta empresa");

int opcao = int.Parse(Console.ReadLine());  

switch (opcao)
{
  case 1:
    Conta conta;
    Write("Digite o titular da conta: ");
    string titular = ReadLine();
    Write("Digite o número da conta: ");
    int numero = int.Parse(ReadLine());
    Write("Deseja fazer depósito inicial (s/n): ");
    char escolha = char.Parse(ReadLine().ToLower());
    if (escolha == 's')
    {
    Write("Digite o depósito inicial: ");
    double deposito = double.Parse(ReadLine());
    conta = new Conta(numero, titular, deposito);
    }
   else
    {
       conta = new Conta(numero, titular);
    }
break;
        case 2:
    ContaPoupanca poupanca;
    Write("Digite o titular da conta: ");
    titular = ReadLine();
    Write("Digite o número da conta: ");
    numero = int.Parse(ReadLine());
    Write("Digite a taxa de juros: ");
    double juros = double.Parse(ReadLine());
    Write("Deseja fazer depósito inicial (s/n): ");
    escolha = char.Parse(ReadLine().ToLower());

    if (escolha == 's')
    {
        Write("Digite o depósito inicial: ");
        double deposito = double.Parse(ReadLine());
        poupanca = new ContaPoupanca(numero, titular, deposito, juros);
    }
    else
    {
        poupanca = new ContaPoupanca(numero, titular, juros);
    }
    break;

case 3:
    ContaJuridica empresa;
    Write("Digite o titular da conta: ");
    titular = ReadLine();
    Write("Digite o número da conta: ");
    numero = int.Parse(ReadLine());
    Write("Digite o limite de empréstimo: ");
    double limite = double.Parse(ReadLine());
    Write("Deseja fazer depósito inicial (s/n): ");
    escolha = char.Parse(ReadLine().ToLower());

    if (escolha == 's')
    {
        Write("Digite o depósito inicial: ");
        double deposito = double.Parse(ReadLine());
        empresa = new ContaJuridica(numero, titular, deposito, limite);
    }
    else
    {
        empresa = new ContaJuridica(numero, titular, limite);
    }
    break;

}

ReadKey();
