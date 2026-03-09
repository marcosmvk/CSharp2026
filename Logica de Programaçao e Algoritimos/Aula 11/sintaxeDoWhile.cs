using static System.Console;

int n = 0;

do
{
    Write(n);
    n++;
    Task.Delay(1000).Wait();

}while(n < 5);
WriteLine(" Fim pogama 1");

n = 0;
do
{
    Write(n);
    n++;
    Task.Delay(1000).Wait();

}while(n < 5);
WriteLine(" Fim pogama 2");