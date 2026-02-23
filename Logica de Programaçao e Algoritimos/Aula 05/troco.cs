using static System.Console;
Console.Write("Preço unitário:");
double preco = double.Parse(ReadLine());
Console.Write("Quantidade:");
int quantidade = int.Parse(ReadLine());
Console.Write("Dinheiro recebido:");
double dinheiro = double.Parse(ReadLine());
double troco = dinheiro - (preco * quantidade);
Console.WriteLine($"Troco: {troco}");





