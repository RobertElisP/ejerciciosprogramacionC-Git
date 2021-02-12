using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>();
            bool repeat = true;
            Console.WriteLine("El programa se cerrará al momento de escribir el numero 0 o un numero negativo");
            Console.WriteLine("NOTA: el numero que se utilice para cerra el sistema será ignorado y solo contara los numeros positivos");
            Console.WriteLine("");
            Console.WriteLine("Escriba numero numeros positivos: ");
            while (repeat) {
                try
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    numberList.Add(number);
                    var ultimo = numberList.LastOrDefault();
                    var positivo = Math.Abs(ultimo);      

                    if (number <= 0)
                    {
                        Console.WriteLine("--------------------------------------------------------------------");
                        Console.WriteLine("La suma de los numeros digitados es: "+ (numberList.Sum() + positivo));
                        Console.WriteLine("--------------------------------------------------------------------");
                        Console.WriteLine("El programa se ha cerrado");
                        repeat = false;
                        Console.ReadKey();
                    }

                }
                catch
                {
                    Console.WriteLine("Favor de solo escribir numeros enteros");
                    Console.WriteLine("");
                    Console.WriteLine("Escriba numero numeros positivos: ");
                }
            }
        }
    }
}
