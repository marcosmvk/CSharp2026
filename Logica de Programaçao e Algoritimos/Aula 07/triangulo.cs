using static System.Console;
//Declaração de variaveis
double a, b, c, areatriangulo, p, areatrapezio;
bool triangulo;
Write("Digite o valor de a:");
a = double.Parse(ReadLine());
Write("Digite o valor de b:");
b = double.Parse(ReadLine());
Write("Digite o valor de c:");
c = double.Parse(ReadLine());
//Processamento de dados
triangulo = (a+b)>c & (a+c)>b & (b+c)>a;
if (triangulo == true)
{
    p = (a+b+c)/2;
    areatriangulo = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
    WriteLine($"A area do triangulo é:{areatriangulo}");
}
else
{
    areatrapezio = ((a+b)*c)/2;  
    WriteLine($"A area do trapezio é:{areatrapezio}");
}









