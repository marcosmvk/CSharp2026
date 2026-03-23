

using System.Runtime.CompilerServices;

namespace Aplicativo03
{
    internal class Notas
    {
        //CAmpos de classe
        public string nome;
        public double nota01;
        public double nota02;
        public double nota03;

        //Construtor 
        public Notas(string nome, double nota01, double nota02, double nota03)
        {
            this.nome = nome;
            this.nota01 = nota01;
            this.nota02 = nota02;
            this.nota03 = nota03;
        }
        //Métodos 
        public double NotaFinal()
        {
            return nota01  + nota02 + nota03;
        }

        public bool AprovadoReprovado()
        {
            return NotaFinal() >= 60.0;
        }

        public double Ponto()
        {
            return 60.0 - NotaFinal();
        }


    }
}


