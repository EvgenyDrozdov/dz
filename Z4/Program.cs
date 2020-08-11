using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z4
{
    class Program
    {
        static void Main(string[] args)
        {
            //задание №14
            Console.WriteLine("Укажите растояние в километрах:");
            double S = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Укажите скорость школьника в км/ч:");
            double V = Convert.ToDouble(Console.ReadLine());
            //находим время 
            double T = (S / V) * 60;
            Console.WriteLine("{0} минут потратил школьник что бы дойти до стадиона", T);
            Console.ReadKey();
        }
    }
}
