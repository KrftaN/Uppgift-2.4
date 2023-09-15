using System;

namespace Uppgift_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur mycket tjänar anställd nummer 1?");
            int lön1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hur mycket tjänar anställd nummer 2?");
            int lön2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hur mycket tjänar anställd nummer 3?");
            int lön3 = Convert.ToInt32(Console.ReadLine());

            int summa = (lön1 + lön2 + lön3) / 3;

            Console.WriteLine("Medellönen är: " + summa);
            Console.ReadKey();
        }
    }
}
