using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace igraNaKarte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int karte = 0, karteZbroj = 0;

            while (karteZbroj < 31)
            {
                Console.WriteLine();
                Console.WriteLine("Unesite broj karte između 1 i 13");

                try
                {
                    karte = int.Parse(Console.ReadLine());

                    if (karte < 0 || karte > 13)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Unjeli ste pogrešne vrijednosti. Vrijednosti moraju biti između 1 i 13");
                    }

                    else if (karte >= 1 && karte <= 13)
                    {
                        karteZbroj += karte;
                    }
                }

                catch (Exception greska)
                {
                    Console.WriteLine("Pogrešan unos. Pokušajte ponopvno.");
                    Console.WriteLine(greska.Message);
                }

                Console.WriteLine();
            }

            if (karteZbroj == 31)
            {
                Console.WriteLine("BRAVO! Pobijedio si!");
            }

            else if (karteZbroj < 31)
            {
                Console.WriteLine("Izgubio si!");
            }

            Console.ReadKey();
        }
    }
}