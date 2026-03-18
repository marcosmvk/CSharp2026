

using System.Security.Cryptography.X509Certificates;

namespace RetanguloComPOO
{
    internal class Retangulo1
    {
        public double basA;
        public double alturaB;

        //Método

        public double Area()
        {
            double area = basA * alturaB;
            return area;
        }
        public double perimetro()
        {
            double perimetro = 2 * (basA + alturaB);
            return perimetro;
        }
        public double diagonal()
        {
            double diagonal = Math.Sqrt((basA * basA) + (alturaB * alturaB));
            return diagonal;
        }

      



    }
}
