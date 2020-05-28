using System;

namespace Pract_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("f(x) = ||x|-1|");
            int i = 0;
            do
            {
                Console.Write("Введите число а: ");
                double xValue = EnterDoubleNumber();
                double yValue = ValueOfFunction(xValue);
                Console.WriteLine($"f(a) = {yValue}");
                i++;
            } while (i < 10);
        }

        static double EnterDoubleNumber()
        {
            bool ok = false;
            double n;
            do
            {
                ok = double.TryParse(Console.ReadLine(), out n);
                if (!ok) { Console.Write("Ошибка! Не удалось преобразовать введенное значение в вещественное число. Введите другое значение: "); }
            } while (!ok);
            return n;
        }

        static double ValueOfFunction(double x)
        {
            return Math.Abs(Math.Abs(x) - 1);
        }

    }
}
