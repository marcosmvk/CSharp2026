using Figuras.Classes.Contratos;
using Figuras.Classes.Enumeracoes;

namespace Figuras.Classes.Entidades
{
    abstract internal class Forma : IArea
    {

        /// <summary>
        /// Cores disponiveis: Vermelho, Azul, Amarelo e Rosa
        /// </summary>

        private Cor cor;
        protected Cor CorDaForma
        {
            get { return cor; }
            set { cor = value; }
        }

        public Forma(Cor corDaForma)
        {
            CorDaForma = corDaForma;
        }

        abstract public double Area();

    }
}
