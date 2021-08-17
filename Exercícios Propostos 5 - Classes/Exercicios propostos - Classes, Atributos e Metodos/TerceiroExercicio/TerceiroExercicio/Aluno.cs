using System;
using System.Globalization;

namespace TerceiroExercicio
{
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;
        public string Situacao;
        public double NotaRestante;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

       public void Aprovacao()
        {
            if (NotaFinal() >= 100)
            {
                Situacao = "APROVADO";
            }

            else
            {
                Situacao = "REPROVADO";
            }
        }

        public void Restante()
        {
            if (Situacao == "REPROVADO")
            {
                NotaRestante = NotaFinal() - 100;
            }

        }

    }
}
