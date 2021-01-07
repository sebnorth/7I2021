using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Program
    {

        static void walec(double r, double h, ref double obj) {

            obj = Math.PI * r * r * h;
            return ;
        }

        static double walec(double r, double h) { 
        
            return Math.PI * r * r * h;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj promień walca: ");
            double promien = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wysokość walca: ");
            double wysokosc = double.Parse(Console.ReadLine());
            // double objetosc = 0.0;

            Console.WriteLine(walec(promien, wysokosc));
            // walec(promien, wysokosc, ref objetosc);
            // Console.WriteLine(objetosc);

            Console.ReadKey();
        }
    }
}
