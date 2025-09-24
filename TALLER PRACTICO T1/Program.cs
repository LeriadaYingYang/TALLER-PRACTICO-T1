using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TALLER_PRACTICO_T1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Elaborar un algoritmo que sume los pares comprendidos entre 100 y 200 sin considerar el rango de números comprendidos entre 150 y 176*/
            int suma = 0;
            int i = 0;

            for (i = 100; i <= 200; i = i + 2)
            {
                if (i < 150 || i > 176) 
                {
                    suma = suma + i;
                }
            }

            Console.WriteLine($"Del algortimo la suma de los numeros pares comprendidos entre 100 y 200 sin considerar el rango entre 150 y 176 es: {suma} "  );
        }
    }
}
