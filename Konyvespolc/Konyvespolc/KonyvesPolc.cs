using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvespolc
{
    class KonyvesPolc
    {
        List<Konyv> Konyvek = new List<Konyv>();
        public void AddBook(Konyv konyv)
        {
            Konyvek.Add(konyv);
        }
        public int TotalPrice
        {
            get
            {
                int osszAr = 0;
                for (int i = 0; i < Konyvek.Count; i++)
                {
                    osszAr += Konyvek[i].Ar;
                }
                return osszAr;
            }               
        }
        public List<Konyv> Search(string iro)
        {
            List<Konyv> keresKonyv = new List<Konyv>();
            for (int i = 0; i < Konyvek.Count; i++)
            {
                if (iro.Equals(Konyvek[i].Iro))
                {
                    keresKonyv.Add(Konyvek[i]);
                }
            }
            return keresKonyv;
        }
    }
}
