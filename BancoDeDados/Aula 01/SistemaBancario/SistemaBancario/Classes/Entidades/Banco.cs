

namespace SistemaBancario.Classes.Entidades
{
    /// <summary>
    ///   //Classe que representa uma conta bancária com operações básicas 
    //Implementa as regras de negócio
    /// </summary>

    internal class Banco
    {
        //Campo 
        /// <summary>
        /// Taxa fixa cobrada em cada operação de saque 
        /// </summary>
        private const double taxasaque = 5.00;


        //Propriedades
        /// <summary>
        /// Identificador único da conta bncária no banco de dados que vai ser gerado automaticamente
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Numero da conta bancária 
        /// 'init'garante que o valor só pode ser atribuido na criação (imutável após construção)
        /// </summary>
        public int NumeroConta { get; init; }

        /// <summary>
        /// Nome do titular da conta
        /// </summary>
        public string Titular { get; set; }

        /// <summary>
        /// Saldo atual da conta 
        /// 'private set' para impedir alteração direta - só pode mudar através de Depósito ou Saque 
        /// </summary>
        public double Saldo { get; private set; }

        //Construtores
        /// <summary>
        /// Construtor privado sem parâmetro 
        /// Necessário p/ o Entity instaciar a classe ao buscar no banco de dados 
        /// Não deve ser utilizado diretamente no código 
        /// </summary>
        private Banco()
        {
        }
        /// <summary>
        /// Construtor principal para criar uma nova conta bancária
        /// </summary>
        /// <param name="numeroConta">Número único da conta (não pode ser alterado depois)</param>
        /// <param name="titular">Nome do titular da conta </param>
        /// <param name="saldo">Valor do depósito inicial (opcional, padrão = 0)</param>
        public Banco(int numeroConta, string titular, double saldo = 0)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = saldo;
        }

        //Métodos
        ///<summary
        ///Realiza um depósito na conta, aumentando o saldo da conta.
        ///<sumary>
        ///<param name="valor">Valor a ser depositado deve ser positivo</param>
        ///
        public void Deposito(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor de depósito deve ser positivo");
                return;
            }
            Saldo += valor;
            Console.WriteLine($"Depósito de {valor:C} realizado com sucesso! ");
        }

        ///<summary>
        ///Realiza um saque na conta, diminuindo o saldo 
        ///Cobra automaticamente uma taxa de R$5.00 por saque
        ///IMPORTANTE: Permite saldo negativo se não houver fundos.
        ///</summary>
        ///<param> name="valor" Valor a ser sacado deve ser positivo, não inclui a taxa </param>
        public void Saque(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor de saque deve ser positivo");
                return;
            }
            Saldo -= (valor + taxasaque);
            Console.WriteLine($"Saque de {valor:C} realizado com sucesso! Taxa de {taxasaque:C} cobrada. ");
        }
    }
}
