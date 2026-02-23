
using static System.Console;
try{
    //Declaração de variaveis
    double a, b, c, areaQuadrado, areaTriangulo, areaTrapezio;
    Write("Digite a medida A:");
    a = double.Parse(ReadLine());
    Write("Digite a medida B:");
    b = double.Parse(ReadLine());
    Write("Digite a medida C:");
    c = double.Parse(ReadLine());
    // Processamento de dados
    areaQuadrado = a * a;
    areaTriangulo = (a * b)/2;
    areaTrapezio = ((a + b) * c) /2;
    //Saida de dados
    WriteLine($"Area do Quadrado = {areaQuadrado:F4}");
    WriteLine($"Area do Triangulo = {areaTriangulo:F4}");
    WriteLine($"Area do Trapezio = {areaTrapezio:F4}");
}catch (Exception)
{
   WriteLine("Valores invalidos inseridos, programa encerrado!");

}


