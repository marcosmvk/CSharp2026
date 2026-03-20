using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicativo02
{
    internal class Funcionario
    {
        //Campos da classe
        public string nome;
        public double salariobruto;
        public double imposto;

        //Construtor 
        public Funcionario(string nome, double salariobruto, double imposto)
        {
            this.nome = nome;
            this.salariobruto = salariobruto;
            this.imposto = imposto;
        }

        //Metodos 
        public double SalarioLiquido()
        {
            return salariobruto -= imposto;
        }

        public void AdicionarAumento(double porcentagem)
        {
            salariobruto = salariobruto * porcentagem
     
           
        }
    
        public string Dados_Do_Funcionario()
        {
            return $"Nome{nome} Salario Bruto: {salariobruto} Imposto: {imposto}" +
                $"Salario Liquido: {SalarioLiquido()}";

        }
        
        public string Salario_Atualizado()

        {
            
            return $"Nome{nome} Salario liquiddo: {SalarioLiquido} ";

        }
    }
}

