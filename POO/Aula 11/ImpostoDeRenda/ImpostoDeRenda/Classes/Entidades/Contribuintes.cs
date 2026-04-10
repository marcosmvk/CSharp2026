

using ImpostoDeRenda.Classes.Contratos;
using System.Runtime.CompilerServices;

namespace ImpostoDeRenda.Classes.Entidades
{
    abstract class Contribuintes : Iimposto
    {
        public string Nome { get; set; }
        public int RendaAnual { get; set; }
        protected Contribuintes (string nome, int rendaanual)
        {
            Nome = nome;
            RendaAnual = rendaanual;

        }
        public abstract double Imposto();
    }
}
