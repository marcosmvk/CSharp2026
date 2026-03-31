

namespace BancoMaster
{
    internal class ContaPoupanca : Conta
    {
        //Campos 
        private double taxa;

        //Propriedades
        public double taxaJuros
        {
            get { return taxa; }
            set { taxa = 0; }
        }

        //Construtores
        public ContaPoupanca(int numeroConta, string titularConta, double taxaJuros) : base(numeroConta, titularConta)
        {
            taxa = 0;
        }

        public ContaPoupanca(int numeroConta, string titularConta, double saldoConta, double taxaJuros) : base(numeroConta, titularConta, saldoConta)
        {
            taxa = 0;
        }

        //Métodos 
        public void Saque(double quantia)
        {
            SaldoConta += quantia;
        }
            
    }
}
