

namespace BancoMaster
{
    internal class ContaJuridica : Conta
    {
        //Campo
        private double  limite;

        //Propriedade
        public double  LimiteEmprestimo
        {
            get { return limite; }
            set { limite = value; }
        }

        //Consrutores
        public ContaJuridica(int numeroConta, string titularConta, double limiteConta) : base(numeroConta, titularConta)
        {
            LimiteEmprestimo = limiteConta;
        }

        public ContaJuridica(int numeroConta, string titularConta, double saldoConta, double limiteConta) : base(numeroConta, titularConta, saldoConta)
        {
            LimiteEmprestimo = limiteConta;
        }

        //Método
        public void Emprestimo(double quantia)
        {
            LimiteEmprestimo -= quantia;
            SaldoConta += quantia;

        }
      

    }
}
