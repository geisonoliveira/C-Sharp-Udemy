using System;
using System.Globalization;

namespace SegundoExercicio
{
    class Funcionario
    {
        public string Nome;

        public double SalarioBruto;

        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        //public override string ToString()
        //{
        //    return Nome
        //        + ", $ "
        //        + SalarioLiquido();
        //}


    }
}
