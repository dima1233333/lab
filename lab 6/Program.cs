using System;
using lab_6._1;
using lab_6._2;
using System;
using System.Text.RegularExpressions;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.RecursionNumber(new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 });
            number.RecursionNumber(0123456789);
            Line line = new Line();
            line.RecursionString(new string[] { "Something" });
            line.RecursionString();
            DoubleNumber doubleNumber = new DoubleNumber();
            doubleNumber.Sort();
            MagicSing magicSing = new MagicSing();
            magicSing.MagicRecursion(new string[2] { "Something", "gnihtemoS" });
            Don_tReverse don_TReverse = new Don_tReverse();
            don_TReverse.DoReveres();
            int[] num;
            don_TReverse.DoReveres3(out num);
            num = new int[] { 1, 2, 3, 4 };
            don_TReverse.DoReveres4(ref num);
        }

    }
}
