
namespace Exercicio1
{
    internal class ConversorDeMoeda
    {
        public static double IOF = 6;
    
    
    public static double Converter(double cotacao, double qtde)
        {
            double valorbase = cotacao * qtde;
            double imposto = valorbase * (IOF / 100);
            double total = valorbase + imposto;
            return total;
        }
    }
}
        
      
    



