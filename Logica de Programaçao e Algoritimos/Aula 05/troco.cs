using static System.Console;
double preco, dinheiro;
int quantidade;
Console.Write("Preço unitário:");
preco = double.Parse(ReadLine());
Console.Write("Quantidade:");
quantidade = int.Parse(ReadLine());
Console.Write("Dinheiro recebido:");
dinheiro = double.Parse(ReadLine());
double troco = dinheiro - (preco * quantidade);
Console.WriteLine($"Troco: {troco}");





