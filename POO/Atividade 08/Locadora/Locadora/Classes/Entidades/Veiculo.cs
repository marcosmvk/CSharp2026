using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Classes.Entidades
{
    internal class Veiculo
    {
        //Campo
        private string modelo;

        //Propriedade
        public string Modelo { get; set; }

        //Constrtutor
        public Veiculo(string modelo)
        {
            Modelo = modelo;
        }

        //Método
        public void Veiculo();
    }
}


