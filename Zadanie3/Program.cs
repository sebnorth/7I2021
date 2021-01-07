using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Program
    {
        struct Pracownik {

            public string imie;
            public string nazwisko;
            public long pesel;
            public double zarobki;
        }
        static void Main(string[] args)
        {
            Pracownik pracownik;

            Console.WriteLine("Podaj imie: ");
            pracownik.imie = Console.ReadLine();

            Console.WriteLine("Podaj nazwisko: ");
            pracownik.nazwisko = Console.ReadLine();

            Console.WriteLine("Podaj PESEL: ");
            pracownik.pesel = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Podaj zarobki: ");
            pracownik.zarobki = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Pracownik {pracownik.imie} {pracownik.nazwisko} ({pracownik.pesel}) zarabia {pracownik.zarobki} zł.");
            Console.ReadKey();
        }
    }
}
