using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_practicum
{
    /// <summary>
    /// вычислить квадртаное уравнение
    /// </summary>
    internal class Program
    {
        static void Main()
        {
            //1 задание
            //try
            //{
            //    Console.Write("a=");
            //    int a = int.Parse(Console.ReadLine());
            //    Console.Write("b=");
            //    int b = int.Parse(Console.ReadLine());
            //    Console.Write("c=");
            //    int c = int.Parse(Console.ReadLine());
            //    double discriminant = Math.Pow(b, 2) - 4 * a * c;
            //    if (discriminant > 0)
            //    {
            //        Console.WriteLine("2 корня");
            //        double x1 = (-b + Math.Sqrt(discriminant)) / 2 * a;
            //        double x2 = (-b - Math.Sqrt(discriminant)) / 2 * a;
            //        Console.WriteLine($"x1={x1} \t x2={x2}");
            //    }
            //    else if (discriminant == 0)
            //    {
            //        Console.WriteLine("1 корень");
            //        double x = -b / 2 * a;
            //        Console.WriteLine($"x1={x}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("нет решений");
            //    }
            //    Console.ReadKey();
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Возникло исключение DivideByZeroException");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Исключение: {ex.Message}");
            //    Console.WriteLine($"Метод: {ex.TargetSite}");
            //    Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
            //}

            //2 задание
            try
            {
                Console.Write("1 сторона=");
                int a = int.Parse(Console.ReadLine());
                if (a == 0)
                {
                    throw new ArgumentException("треугольника нет");
                }
                Console.Write("2 сторона=");
                int b = int.Parse(Console.ReadLine());
                if (b == 0)
                {
                    throw new ArgumentException("треугольника нет");
                }
                Console.Write("3 сторона=");
                int c = int.Parse(Console.ReadLine());
                if (c == 0)
                {
                    throw new ArgumentException("треугольника нет");
                }
                if (a<c+b&&b<a+c&&c<a+b)
                {
                    double p = (a + b + c) / 2;
                    double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    Console.WriteLine(s);
                }
                else
                {
                    Console.WriteLine("треугольника не существует");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
                Console.WriteLine($"Метод: {ex.TargetSite}");
                Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
            }


            //try
            //{
            //    int x = 5;
            //    int y = x / 0;
            //    Console.WriteLine($"Результат: {y}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Исключение: {ex.Message}");
            //    Console.WriteLine($"Метод: {ex.TargetSite}");
            //    Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
            //}
        }
    }
}
