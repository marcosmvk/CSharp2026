using Master;



//Console.WriteLine(Tipo.ContaNormal);
Conta conta = new Conta(12345, 1500.26, new Pessoa("Clodoaldo", 1245));
var a = conta.ToString();
Console.WriteLine(a);

//Console.WriteLine(Tipo.ContaPJ);
ContaPJ pj = new ContaPJ(54321, 50000, new Pessoa("Cesar", 5197810010), 20000);

var b = pj.ToString();
Console.WriteLine(b);


//Console.WriteLine(Tipo.Contapoupanca);
ContaPoupanca pp = new ContaPoupanca(666666, 666.66, new Pessoa("Lu", 6666666666), 5.0);

pp.Consulta();



Console.ReadKey();
