using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Classes.Entidades
{
    internal class AluguelCarro
    {
        //Campos
        private DateTime inicio;
        private DateTime fim;
        private string veiculo;



        //Propriedades
        public DateTime iNicio
        {
            get { return iNicio; }
            set { iNicio = value; }
        }

        public DateTime fIm
        {
            get { return fIm; }
            set { fIm = value; }
        }

        public string marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public int fatura
        {
            get { return fatura; }
            set { fatura = value; }
        }

        //Construtor
        public AluguelCarro(DateTime iNicio, string marca, DateTime fIm)
        {
            this.iNicio = iNicio;
            this.marca = marca;
            this.fIm = fIm;
        }

        public AluguelCarro()
        {

        }
    }
}
    
