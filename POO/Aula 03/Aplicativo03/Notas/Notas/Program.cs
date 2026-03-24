using Aplicativo03;
using static System.Console;

WriteLine("Nome do aluno");
string nome  = Console.ReadLine();
Write("Digite as tres notas do aluno: ");
double nota01 = double.Parse(Console.ReadLine());
double nota02 = double.Parse(Console.ReadLine());
double nota03 = double.Parse(Console.ReadLine());

Notas n = new Notas(nome,nota01, nota02,nota03);

WriteLine($"Nota final do aluno:{n.NotaFinal()} ");

WriteLine(n.AprovadoReprovado() ? "Aprovado" : "Reprovado");
if(!n.AprovadoReprovado())
{
    WriteLine($"Faltaram {n.Ponto()} pontos ");
}




ReadKey();