using RetanguloComPOO;
using static System.Console;
//Instanciação dos retangulo
Retangulo1 x = new Retangulo1();
Retangulo1 y = new Retangulo1();
Write("Digite a base do retangulo X: ");
x.basA = double.Parse(ReadLine());
Write("Digite a altura do retangulo X: ");
x.alturaB = double.Parse(ReadLine());

Write("Digite a base do retangulo Y: ");
y.basA = double.Parse(ReadLine());
Write("Digite a altura do retangulo Y: ");
y.alturaB = double.Parse(ReadLine());

//Saida de dados 
WriteLine($"O valor da area do retangulo X é: {x.Area()}, perimetro {x.perimetro()} e diagonal  {x.diagonal()}");
WriteLine($"O valor da area do retangulo Y é: {y.Area()}, perimetro {y.perimetro()} e diagonal  {y.diagonal()}");
