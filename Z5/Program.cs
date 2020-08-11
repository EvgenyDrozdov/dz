using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("укажите скорость первого автомобиля:");
            double v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("укажите скорость второго автомобиля:");
            double v2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("укажите текущие расстояние между автомобилями в километрах:");
            double s = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("укажите время в часах:");
            double t = Convert.ToDouble(Console.ReadLine());
            double s1 = v1 * t;
            double s2 = v2 * t;
            double s3 = s1 + s2;
            Console.WriteLine("Растояние между автомобилями через {0} часов равно {1} километров", t, s3);
            Console.ReadKey();
        }
    }
}
