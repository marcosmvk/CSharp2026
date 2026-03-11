using static System.Console;
Dictionary<int, double> produto = new Dictionary<int, double>()
{
    
    {1, 5.00},
    {2, 3.50},
    {3, 4.80},
    {4, 8.90},
    {5, 7.32},
};
try
{

int codigo, quantidade;
Write("Digite o código do produto: ");
codigo = int.Parse(ReadLine());
Write("Digite a quantidade: ");
quantidade = int.Parse(ReadLine());

WriteLine($"Total a pagar:{produto[codigo] * quantidade}");


}
catch(Exception ex)
{
    WriteLine($"Digite valores válidos, erro: {ex.Message}");
}