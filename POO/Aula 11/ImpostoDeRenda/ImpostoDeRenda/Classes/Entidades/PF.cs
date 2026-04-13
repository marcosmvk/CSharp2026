

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
            double imposto;
            if (RendaAnual < 20.000)
                imposto = RendaAnual * 0.15;
            else
                imposto = RendaAnual * 0.25;
            imposto -= saude * 0.5;
            return imposto;
        }
    }
}
