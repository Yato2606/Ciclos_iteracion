using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, divisor, numDivisores = 0;

            numero=2;

            if (numero<=100)
            {
                divisor=1;

                if (divisor<=numero)
                {
                    if (numero%divisor==0)
                    {
                        numDivisores =numDivisores+1;
                    }
                }
            }
            else
            {
                if (numDivisores<=2)
                {
                    Console.WriteLine("{0}", numero);
                    Console.ReadKey();
                }
                else
                {
                    numDivisores=0;
                }
            }
            Console.ReadKey();
        }
    }
}
