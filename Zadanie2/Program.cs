using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class Program
    {

        static int f(int n) {

            if (n == 0) return 2;
            else
                return 2 * f(n - 1) - 3;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(f(4));
            Console.ReadKey();
        }
    }
}
