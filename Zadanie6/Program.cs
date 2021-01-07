using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            string s, nazwa = @"C:\Users\sagata\Downloads\inne\kursy\C#\zaj5\pliki10\zaj7012021\plik.txt";
            FileStream plik = new FileStream(nazwa, FileMode.Open, FileAccess.Read, FileShare.None);
            System.IO.StreamReader odczyt = new StreamReader(plik);
            int iloscCyfr = 0;
            int iloscCyfrWLinii = 0;

            while ((s = odczyt.ReadLine()) != null)
            {
                Console.WriteLine(s);
                iloscCyfrWLinii = 0;
                foreach (char znak in s)
                {

                    if (Char.IsDigit(znak))
                    {
                        iloscCyfr++;
                        iloscCyfrWLinii++;
                    }
                }
                Console.WriteLine("Ilość cyfr w linii wynosi: {0}", iloscCyfrWLinii);

            }

            Console.WriteLine("Ilość cyfr w pliku wynosi: {0}", iloscCyfr);
            Console.ReadKey();
        }
    }
}
