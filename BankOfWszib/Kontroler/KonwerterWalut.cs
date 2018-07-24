using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfWszib.Kontroler
{
    static class KonwerterWalut
    {
        public static string konwertuj(string waluta, string wartoscDoPrzekonwertowania)
        {
            double wartosc = Double.Parse(wartoscDoPrzekonwertowania.Substring(0,wartoscDoPrzekonwertowania.Length -3));

            if (waluta == "d")
            {
                double wynik = wartosc / 3.6;

                return (Math.Round(wynik, 2)).ToString();
            }
            if (waluta == "e")
            {
                double wynik = wartosc / 4.3;

                return (Math.Round(wynik, 2)).ToString();
            }
            if (waluta == "f")
            {
                double wynik = wartosc / 4.9;

                return (Math.Round(wynik, 2)).ToString();
            }

            return "Błędny argument";
        }
    }
}
