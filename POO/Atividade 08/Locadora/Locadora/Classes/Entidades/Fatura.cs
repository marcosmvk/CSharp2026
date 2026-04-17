using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Text;

namespace Locadora.Classes.Entidades
{
    internal class Fatura
    {
        //Campos
        private int pagamentoBasico;
        private double taxa;
        private double totalPagmento;


        //Propriedades
        public int PagamentoBasico { get; set; }
        public double Taxa { get; set; }
        public double TotalPagmento { get; set; }

        //Construtor
        public Fatura(int pagamentoBasico, double taxa, double totalPagmento)
        {
            PagamentoBasico = pagamentoBasico;
            Taxa = taxa;
            TotalPagmento = totalPagmento;
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }
 }

