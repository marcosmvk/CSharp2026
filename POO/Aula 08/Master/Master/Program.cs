using Master;

Conta conta = new Conta(12345, 1500.26, new Pessoa("Clodoaldo", 1245));
var a = conta.ToString();
Console.WriteLine(a);

Console.ReadKey();
