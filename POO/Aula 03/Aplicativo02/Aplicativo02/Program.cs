using Aplicativo02;
using static System.Console;


WriteLine("Entre com os dados do funcionario: ");
Write("Nome: ");
string nome = ReadLine();
Write("Salário Bruto: ");
double salariobruto = double.Parse(ReadLine());
Write("Imposto: ");
double imposto = double.Parse(ReadLine());

Funcionario f = new Funcionario(nome,salariobruto, imposto);

WriteLine("Dados do Funcionario");
WriteLine($"Nome do Funcionario: {nome}");
WriteLine($"Salario Liquido: {f.SalarioLiquido()}");

Write("Digite a porcentagem de aumento do salario do funcionario:");
double porcentagem = double.Parse(ReadLine());
f.AdicionarAumento(porcentagem);
WriteLine($"Salario do funcionario aumentado em: {porcentagem}%");

WriteLine("Dados do funcinário atualizado");
WriteLine($"Nome do Funcionario: {nome}");
WriteLine($"Salario Liquido: {f.SalarioLiquido()}");






ReadKey();