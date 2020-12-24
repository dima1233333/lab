using System;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус R: ");
            double R = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите высоту h: ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Обьем цилиндра = {0}", Math.PI * R * R * h);
            Console.ReadLine();
        }
    }
}
