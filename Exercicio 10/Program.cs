using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio com params
            try
            {
                Console.Write("Digite a quantidade de números a serem somados? ");
                int totalDeNumeros = int.Parse(Console.ReadLine());
                double[] numeros = new double[totalDeNumeros];

                for (int i = 0; i < totalDeNumeros; i++)
                {
                    numeros[i] = double.Parse(Console.ReadLine());
                }

                Console.WriteLine($"Total da soma: {Calculadora.Somar(numeros)}");
                Console.WriteLine($"Soma valores 2 5 3 usando params: {Calculadora.Somar(2, 5, 3)}");

                Console.WriteLine("Pressione qualquer tecla para finalizar");
                Console.ReadKey();
            }
            catch (Exception falha)
            {
                Console.WriteLine($">{falha.Message}");
            } 
        }
    }
}
