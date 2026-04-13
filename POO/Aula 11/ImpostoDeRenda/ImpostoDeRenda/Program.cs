using ImpostoDeRenda.Classes.Entidades;
using static System.Console;
List <Contribuintes> lista = new List <Contribuintes> ();
Write("Digite o número de contribuintes: ");
int n = int.Parse(ReadLine());
for (int i = 1; i <= n; i++)
{
    WriteLine($"\nContribuinte {i}: ");
    Write("Pessoa física ou jurídica (f/j)?");
    char t = char.Parse(ReadLine());
    Console.Write("Nome: ");
    string nome = Console.ReadLine();

    Console.Write("Renda anual: ");
    int renda = int.Parse(Console.ReadLine());

    if (t == 'f')
    {
        Console.Write("Gastos com saúde: ");
        double gastos = double.Parse(Console.ReadLine());

        lista.Add(new PF (nome, renda, gastos));
    }
    else
    {
        Console.Write("Número de funcionários: ");
        int funcionarios = int.Parse(Console.ReadLine());

        lista.Add(new PJ(nome, renda, funcionarios));
    }
}

Console.WriteLine("\nIMPOSTOS PAGOS:");
double total = 0;

foreach (Contribuintes c in lista)
{
    double imposto = c.Imposto();
    Console.WriteLine($"{c.Nome}: R$ {imposto:F2}");
    total += imposto;
}

            Console.WriteLine($"\nTOTAL DE IMPOSTO: R$ {total:F2}");


ReadKey();