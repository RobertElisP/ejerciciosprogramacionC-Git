using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            do
            {
                numero++;
                Console.WriteLine(numero);
            } while (numero <= 9);

            Console.ReadKey();
        }
    }
}
