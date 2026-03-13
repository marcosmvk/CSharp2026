using static System.Console;

int n;

Write(" Qual a ordem da matriz, no máximo até 10: ");
n = int.Parse(ReadLine());
if (n <= 10 | n > 0 )
{

    int[,] matriz = new int [n,n];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Write($"Digite o valor da posição {i}],[{j}]: ");
            matriz[i,j] = int.Parse(ReadLine());
        }
    }
    WriteLine("Diagonal principal: ");
    for (int i = 0; i < n; i++)
    {

            Write(matriz[i,i] + "\t");

        WriteLine();
    } 
     int negativos = 0;
     for (int i = 0; i < n; i++)
    
        for (int j = 0; j < n; j++)
        {
            if (matriz[i,j] < 0)
            {
                negativos++;
            }
        }
  WriteLine($"Quantidade de numeros negativos: {negativos}");
}


