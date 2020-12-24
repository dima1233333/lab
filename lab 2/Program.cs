using System;

namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string selection = Console.ReadLine();
            int n = new int();

            n = Convert.ToInt32(selection);
            if (n % 2 == 1 && n >= 100 && n <= 999)
                Console.WriteLine("Данное число является нечетным трехзначным");
        }
    }
}
