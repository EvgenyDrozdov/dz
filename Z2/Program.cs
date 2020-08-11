using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z2
{
    class Program
    {
        static void Main(string[] args)
        {
            // хадание №3
            double a, b, c, p, ha, hb, hc;
            Console.WriteLine("Введите значение стороны a:");
            a = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("Введите значение стороны b:");
            b = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("Введите значение стороны c:");
            c = Convert.ToDouble(Console.ReadLine());
            p = (a + b + c) / 2;
            ha = (2 / a) * (Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
            hb = (2 / b) * (Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
            hc = (2 / c) * (Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
            Console.WriteLine("Высота стороны a = {0}, Высота стороны b = {1}, Высота стороны с = {2}", ha, hb, hc);
            Console.ReadKey();

        }
    }
}
