
using static System.Console;
// Declaração de variaveis
int codigo, quantidade;
// Entrada de dados 
Write("Digite o codigo do produto: ");
codigo = int.Parse(ReadLine());
Write("Digite a quantidade do produto: ");
quantidade = int.Parse(ReadLine());
switch(codigo)
{
    case 1:
        WriteLine($"O valor total é de: {quantidade * 5.00}");
        break;
    case 2:
        WriteLine($"O valor tota é de: {quantidade * 4.50}");
         break; 
    case 3:
         WriteLine($"O valor tota é de: {quantidade * 3.75}");
          break; 
    case 4: 
         WriteLine($"O valor tota é de: {quantidade * 8.99}");
          break; 
    case 5: 
         WriteLine($"O valor tota é de: {quantidade * 11.99}");
         break;              
}
