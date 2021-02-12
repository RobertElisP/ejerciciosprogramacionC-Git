using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool seguir = true;
            int contador = 0;
            List<int> numbers = new List<int>();
            List<int> pares = new List<int>();

            while (seguir)
            {
                Console.WriteLine("Puede usted por favor digtar el  numero");
                numbers.Add(Convert.ToInt32(Console.ReadLine()));
                /*
                Este codigo genera los 100 numeros automatico para que pueda corregir mas rapido 
                :)
                */
                //for (int i = 1; i <= 100; i++)
                //{
                //    numbers.Add(i);
                //}
                /*Fin del codigo automatico para generar los 100 numeros  10 X 10 */

                if (numbers.Count() == 100)
                {
                    foreach (var number in numbers)
                    {
                        if (number % 2 == 0)
                        {
                            pares.Add(number);
                            contador++;
                            if (contador == 10)
                            {
                                Console.WriteLine("sus numeros pares son los siguientes");
                                foreach (var par in pares)
                                {
                                    Console.WriteLine(par);
                                }
                                seguir = false;
                                Console.WriteLine("Usted no puede digitar mas numeros el total es (10 X 10)");
                            }
                        }
                    }


                }

                Console.ReadKey();
            }


        }
    }
}
