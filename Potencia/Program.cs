using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, exponente, i;
            double resultado = 1, resultadoNegativo;

            Console.WriteLine("Dame la base: ");
            numero = Console.ReadLine().Length;
            Console.WriteLine("Ingresa el exponente: ");
            exponente = Console.ReadLine().Length;

            if (exponente<0)
            {
                exponente = exponente*-1;
                i=1;
                if (i<=exponente)
                {
                    resultado*=numero;
                    i++;
                }
                else
                {
                    resultadoNegativo=(1/resultado);
                    Console.WriteLine("{0}^{1}={2}", numero, exponente, resultadoNegativo);
                    Console.ReadKey();
                }
            }
            else
            {
                i=1;
                if (i<=exponente)
                {
                    resultado *=numero;
                    i++;
                }
                else
                {
                    Console.WriteLine("{0}^{1}={2}", numero, exponente, resultado);
                    Console.ReadKey();
                }
            }
            Console.ReadKey();

        }
    }
}
