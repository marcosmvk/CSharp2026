


namespace Banco1
{
    internal class ContaBancaria
    {
		//Campo 
		private int numero;
		private string titular;
		private double saldo;

		//Propriedades

		public int Numero
		{
			get { return numero; }
			set { numero = value; }
		}
		public string Titular
		{
			get { return titular; }
			set { titular = value; }
		}
        public double Saldo
        {
            get { return saldo; }
            set 
			{ 
				if (value > 0) 
				{ saldo = value; } 
				else { saldo = 0; }
			   
			}
        }

		//Construtor

		public ContaBancaria(int  numero, string titular)
		{
			Numero = numero;
			Titular = titular;
			Saldo = 0;
		}

		public ContaBancaria(int numero, string titular, double saldo):this(numero, titular)
        {
			Saldo = saldo;
		}

		//Métodos 
		
		public void Deposito(double quantia)
		{
			saldo += quantia;
		}

		public void Saque(double quantia)
		{
			saldo -= quantia; 
		}

		public void Dados()
		{
			Console.WriteLine($"Dados da conta: \n " + 
				$"\tConta: {numero}\n" +
				$"\tTitular: { Titular}\n" +
				$"\tSaldo: {Saldo:C}");
		}

    }
}
