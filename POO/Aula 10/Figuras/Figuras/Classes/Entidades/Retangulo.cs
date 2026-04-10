
using Figuras.Classes.Enumeracoes;

namespace Figuras.Classes.Entidades
{
    internal class Retangulo : Forma
    {
        private double largura;
        private double altura;


        protected double Largura
        {
            get { return largura; }
            set { largura = value; }
        }
        protected double Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        public Retangulo(Cor corDaForma, double largura, double altura) : base(corDaForma)
        {
            Largura = largura;
            Altura = altura;
        }
        /// <summary>
        /// Calculates the area of the rectangle by multiplying its width and height.
        /// </summary>
        /// <returns>The area of the rectangle as a double-precision floating-point value.</returns>
        public override double Area() => Largura * Altura;











    }
}