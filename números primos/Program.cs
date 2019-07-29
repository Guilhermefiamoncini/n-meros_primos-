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
            if (numerointeiro == 2 ^ numerointeiro == 3 ^ numerointeiro == 5 ^ numerointeiro == 7 ^ numerointeiro == 11)
            {
                Console.WriteLine("esse numero é primo");
            }
            else
            {
                numresto = numerointeiro % 2;

                if (numresto == 0)
                {
                    Console.WriteLine("esse número não é primo");
                }
                if (numresto == 1)
                {
                    numresto = numerointeiro % 3;
                    if (numresto == 0)
                    {
                        Console.WriteLine("esse número não é primo");
                    }
                    if (numresto != 0)
                    {
                        numresto = numerointeiro % 5;
                        if (numresto == 0)
                        {
                            Console.WriteLine("esse número não é primo");
                        }
                        if (numresto != 0)
                        {
                            numresto = numerointeiro % 7;
                            if (numresto != 0)
                            {
                                Console.WriteLine("esse número não é primo");
                            }
                            if (numresto != 0)
                            {
                                numresto = numerointeiro % 11;
                                if (numresto == 0)
                                {
                                    Console.WriteLine("esse número não é primo");
                                }
                                if (numresto != 0)
                                {
                                    Console.WriteLine("esse numero é primo");
                                }
                            }

                        }
                    }






                }

            }
            Console.ReadKey();

        }
    }
}
