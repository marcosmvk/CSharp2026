using static System.Console;
//Declaração de variaveis
int turistas = 0, quantidade, contagem = 0;
string entrada, saida, sair;
//Entrada de dados
WriteLine("Bem-vindo ao controle de fluxo de turistas no parque!");
Write("Digite o fluxo de carro (entrada/saida) ou 'sair' para encerrar: ");
entrada = ReadLine(); 
Write("Digite o numero de turistas: ");
quantidade = int.Parse(ReadLine());
while(true)
if (entrada == "entrada")
{
    turistas += quantidade;
}
else if (entrada == "saida")
{
    turistas -= quantidade;
}
else if (entrada == "sair")
{
    WriteLine("Programa encerrado");
   break;
}
else
{
    WriteLine("Entrada inválida, tente novamente.");
}
WriteLine($"Total de turistas no parque: {turistas}");
WriteLine($"Contagem de entradas e saídas: {contagem}");