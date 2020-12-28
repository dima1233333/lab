using System;

namespace lab_4
{
    class Program
    {
        public void MinMax(int[] array, int min, int max, int numbermax, int numbermin)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    numbermax = i;
                }
                if (min > array[i])
                {
                    min = array[i];
                    numbermin = i;
                }
            }
            Console.WriteLine("Максимальный элемент:" + max + ".Позиция:" + (numbermax + 1));
            Console.WriteLine("Минимальный элемент:" + min + ".Позиция:" + (numbermin + 1));
            Changed(array, numbermax, numbermin);
        }
        public void Changed(int[] array, int numbermax, int numbermin)
        {

            int a, b;
            a = array[numbermax];
            b = array[numbermin];
            array[numbermax] = b;
            array[numbermin] = a;
            Console.WriteLine("Полученный массив:");
            foreach (int x in array)
            {
                Console.Write(x + " ");
            }
        }
    }

    class Simple
    {
        static void Main()
        {
            Program ob1 = new Program();
            Console.WriteLine("Исходный массив:");

            int[] array = { 2, 4, 6, -567, 0, 4556, -46, -3424, 23, 54, 7, 889 };
            foreach (int x in array)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            int min, max;
            int numbermin = 0;
            int numbermax = 0;
            min = array[0];
            max = array[0];
            ob1.MinMax(array, min, max, numbermax, numbermin);
            Console.ReadKey();
        }
    }
}
