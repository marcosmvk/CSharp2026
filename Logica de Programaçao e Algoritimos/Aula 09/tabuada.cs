using static System.Console;
//Declaração de Variavel
int numero;
//Entrada de dados 
numero = int.Parse(ReadLine());
//Processamentos de dados 
for (int i = 0; i < 10; i++)
{
    WriteLine($"{numero} X {i+1} = {numero * (i+1)}");

}
