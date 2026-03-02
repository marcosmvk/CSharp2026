using static System.Console;
// Declaração de variaveis 
int numero, valor;

try
{
    WriteLine("Quantos números você vai digitar?");
    numero = int.Parse(ReadLine());
    //Processamento de dados 
    for (int i = 0; i<numero; i++)
    {
        WriteLine("Digite um número");
        valor = int.Parse(ReadLine());
        if (valor < 0)
        {
            Write("Negativo ");
        }
        else if (valor > 0)
        {
            Write("Positivo" );
        }
        else
        {
            Write("Nulo ");    
        }

        if ((valor % 2) == 0)
        {
            WriteLine(" PAR");
        }
        else if ((valor %2) != 0)
        {
            WriteLine(" IMPAR");
        }
    
        
    }
}
catch (Exception ex)
{
    WriteLine("Valor inválido, erro = ", ex.Message);
}