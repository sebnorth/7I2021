using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    class Program
    {

        static int Przelicz(int n) {

            int suma = 0;
            int wykładnik = 0;
            int waga;

            while (n>0)
            {
                int cyfra = n % 10;
                waga = (int)Math.Pow(4, wykładnik);
                wykładnik++;
                suma += waga * cyfra;
                n /= 10;

            }

            return suma;
        }

        static int Przelicz2(int n) {

            if (n < 4) return n;
            else return (n % 10) + 4 * Przelicz2(n / 10);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Przelicz(11)); //5
            Console.WriteLine(Przelicz2(11)); //5
            Console.ReadKey();
        }
    }
}
