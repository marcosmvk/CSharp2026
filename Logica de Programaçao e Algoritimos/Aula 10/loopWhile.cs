using static System.Console;
//Declaração de variaveis
int turistas = 0, quantidade, contagem = 0;
string entrada;
//Entrada de dados
WriteLine("Bem-vindo ao controle de fluxo de turistas no parque!");
while(true)
{
Write("Digite o fluxo de carro (entrada/saida) ou 'sair' para encerrar: ");
entrada = ReadLine(); 
if (entrada == "sair")
{
    WriteLine("Programa encerrado");
   break;
}
Write("Digite o numero de turistas: ");
quantidade = int.Parse(ReadLine());
if (entrada == "entrada")
{
    turistas += quantidade;
    contagem++;
}
else if (entrada == "saida")
{
    turistas -= quantidade;
    contagem--;
}
else
{
    WriteLine("Entrada inválida, tente novamente.");
}
}
WriteLine($"Total de turistas no parque: {turistas}");
WriteLine($"Contagem de entradas e saídas: {contagem}");