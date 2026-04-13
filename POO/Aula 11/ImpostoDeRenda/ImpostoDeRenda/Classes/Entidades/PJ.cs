

namespace ImpostoDeRenda.Classes.Entidades
{
    internal class PJ : Contribuintes
    {
        private int funcionarios { get; set; }   
       
        public PJ(string nome, int rendaanual, int funcionarios) : base(nome, rendaanual)
        {
           this.funcionarios = funcionarios;
        }

        public override double Imposto()
        {
            if (funcionarios > 10)
                return RendaAnual * 0.14;
            else 
                return RendaAnual * 0.16;
        }
    }
}
