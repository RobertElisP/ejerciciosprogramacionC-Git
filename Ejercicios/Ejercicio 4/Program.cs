using System;


namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Abcdario = new string[27] { "a","b","c","d","e","f","g","g","i","j","k","l","m","n","ñ","o","p","q","r","s","t","u","v","w","x","y","z"};

            Array.Reverse(Abcdario);
            foreach (var item in Abcdario)
            {
                Console.WriteLine(item.ToUpper());
            }
            
        }
    }
}
