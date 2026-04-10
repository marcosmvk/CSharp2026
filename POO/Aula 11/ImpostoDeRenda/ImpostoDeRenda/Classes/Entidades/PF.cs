

namespace ImpostoDeRenda.Classes.Entidades
{
    internal class PF : Contribuintes
    {
        private double saude { get; set; }
        public PF(string nome, int rendaanual, double saude) : base(nome, rendaanual)
        {
            this.saude = saude;
        }

        public override double Imposto()
        {
            throw new NotImplementedException();
        }
    }
}
