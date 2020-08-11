using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z3
{
    class Program
    {
        static void Main(string[] args)
        {
            // задание №16
            double R;
            Console.WriteLine("Укажите радиус вписанной окружности:");
            R = Convert.ToDouble(Console.ReadLine());
            //находим площадь круга
            double Sc = Math.PI * R * R;
            //находим площад квадрата
            double Sk = Math.Pow(2 * R, 2);
            //находим заштрихованную площадь
            double S = (Sk - Sc) / 2;
            Console.WriteLine("Заштрихованная площадь равна: {0}", S);
            Console.ReadKey();
        }
    }
}
