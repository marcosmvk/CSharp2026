using DepartamentoPessoal.Classes.Entidades;
using static System.Console;

List<Funcionario> colaboradores = new();

Write("Quantos funcionários irá cadastrar: ");
int n = int.Parse(Console.ReadLine());

for (int i =0;  i < n; i++)
{
    WriteLine($"Colaborador n° {i + 1}");
    Write("O funcionário é terceirizado? (s/n): ");
    char e = char.Parse(Console.ReadLine().ToLower());
    if (e == 'n')
    {
        Write("Nome: ");
        string nome = ReadLine();
        Write("Horas trabalhadas: ");
        int h = int.Parse(Console.ReadLine());
        Write("Valor da hora");
        double v = double.Parse(ReadLine());
        colaboradores.Add(new Funcionario (nome,h,v));
    }
    else
    {
        Write("Nome: ");
        string nome = ReadLine();
        Write("Horas trabalhadas: ");
        int h = int.Parse(Console.ReadLine());
        Write("Valor da hora");
        double v = double.Parse(ReadLine());
        Write("Despesa adicional: R$ ");
        double d = double.Parse(ReadLine());
        colaboradores.Add(new Terceiro(nome, h, v,d));

    }

    WriteLine("-Pagamentos-");
    foreach (var colab in  colaboradores)
    {
        colaboradores[colab].ToString();
    }
}

