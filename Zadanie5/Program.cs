using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            string nazwa = @"C:\Users\sagata\Downloads\inne\kursy\C#\zaj5\pliki10\zaj7012021\kwadrat.txt";
            FileStream plik = new FileStream(nazwa, FileMode.Append, FileAccess.Write, FileShare.None);
            System.IO.StreamWriter zapis = new StreamWriter(plik);
            zapis.WriteLine("*");
            zapis.Close();
            plik.Close();

        }
    }
}
