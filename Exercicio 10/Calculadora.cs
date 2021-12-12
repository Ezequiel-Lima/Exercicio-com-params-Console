using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_10
{
    internal class Calculadora
    {
        public static double Somar(params double[] numeros)
        {
            double somar = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                somar += numeros[i];
            }
            return somar;
        }
    }
}
