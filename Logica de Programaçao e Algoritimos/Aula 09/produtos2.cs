using static System.Console;
try
{
static void Total(int qtd, double valor)
{
    WriteLine($"O valor total é de: {qtd * valor}");
}

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
    Total(quantidade, 5.00);
       // WriteLine($"O valor total é de: {quantidade * 5.00}");
        break;
    case 2:
     Total(quantidade, 4.50);
       // WriteLine($"O valor total é de: {quantidade * 4.50}");
         break; 
    case 3:
     Total(quantidade, 3.75);
        // WriteLine($"O valor tota é de: {quantidade * 3.75}");
          break; 
    case 4: 
     Total(quantidade, 8.99);
        // WriteLine($"O valor total é de: {quantidade * 8.99}");
          break; 
    case 5: 
     Total(quantidade, 11.99);
         //WriteLine($"O valor total é de: {quantidade * 11.33}");
         break;   
       default:
           WriteLine("Código do produto não cadastrado");
           break;             
   }
}
catch(Exception)
{
    WriteLine("Digite valores válidos");
}