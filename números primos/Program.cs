using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace números_primos
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 numresto = 0;

            Console.WriteLine("informe um número inteiro");

           Int32 numerointeiro = Convert.ToInt32(Console.ReadLine());
            if (numerointeiro == 2)
            {
                Console.WriteLine("esse numero é primo");
            }
            if (numerointeiro != 2)
            {
                numresto = numerointeiro % 2;

                if (numresto == 0)
                {
                    Console.WriteLine("esse número não é primo");
                }
                if (numresto == 1)
                {
                    Console.WriteLine("esse número é primo");
                }
            }
            Console.ReadKey();

        }
    }
}
