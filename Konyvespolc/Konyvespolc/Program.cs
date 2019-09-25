using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvespolc
{
    class Program
    {
        static void Main(string[] args)
        {
            KonyvesPolc konyvesPolc = new KonyvesPolc();
            Konyv konyv1 = new Konyv("Ádám", "Ádám könyve1", 2000, 5000, Konyv.Mufajok.szakkönyv);
            konyvesPolc.AddBook(konyv1);
            Konyv konyv2 = new Konyv("Éva", "Éva könyve1", 2005, 10000, Konyv.Mufajok.mese);
            konyvesPolc.AddBook(konyv2);
            Konyv konyv3 = new Konyv("Jani", "Jani könyve1", 1970, 3000, Konyv.Mufajok.regény);
            konyvesPolc.AddBook(konyv3);
            Konyv konyv4 = new Konyv("Ádám", "Ádám könyve2", 2007, 1000, Konyv.Mufajok.történelem);
            konyvesPolc.AddBook(konyv4);
            Konyv konyv5 = new Konyv("Béla", "Béla könyve1", 25000);
            konyvesPolc.AddBook(konyv5);
            Konyv konyv6 = new Konyv("Béla", "Béla könyve2", 1950, 2500, Konyv.Mufajok.külföldi);
            konyvesPolc.AddBook(konyv6);
            Konyv konyv7 = new Konyv("Peti", "Peti könyve1", 2002, 1500, Konyv.Mufajok.külföldi);
            konyvesPolc.AddBook(konyv7);
            Konyv konyv8 = new Konyv("Sanyi", "Sanyi könyve1", 1920, 10500, Konyv.Mufajok.történelem);
            konyvesPolc.AddBook(konyv8);
            Konyv konyv9 = new Konyv("Ádám", "Ádám könyve3", 30000);
            konyvesPolc.AddBook(konyv9);

            Console.WriteLine("A könyves polc össz értéke: {0} ", konyvesPolc.TotalPrice);

            Console.WriteLine("Kérek egy írót akit szeretne kilistázni");
            string iro = Console.ReadLine();
            List<Konyv> KeresettKonyvek = konyvesPolc.Search(iro);

            Console.WriteLine("A keresett íro \"{0}\" könyv címei:", iro);
            if (KeresettKonyvek.Count > 0)
            {
                foreach (Konyv k in KeresettKonyvek)
                    Console.WriteLine(k);
            }
            else
                Console.WriteLine("Nincs ilyen író!");
            Console.ReadKey();
        }
    }
}
