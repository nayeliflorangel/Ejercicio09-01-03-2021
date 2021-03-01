using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Ingresa un número entero: ");
            number = int.Parse(Console.ReadLine());
            while(number != -1)
            {
                Console.Clear();
                for(int i = 0; i < 13; i++)
                {
                    Console.WriteLine($"{number} X {i} = {number*i}");
                }
                Console.ReadKey();
                Console.WriteLine("\n\nIngresa un número entero: ");
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("¡Finalizado!");
        }
    }
}
