using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание №5
            double  a, b, c, x;
            Console.WriteLine("Ведите значение a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ведите значение b:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ведите значение c:");
            c = Convert.ToDouble(Console.ReadLine());
            x = (a + b) * (a + c) / (b - c);
            Console.WriteLine("Значение x = {0}:", x);
       
            Console.ReadKey();
        }
    }
}
