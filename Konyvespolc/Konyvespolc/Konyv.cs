using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvespolc
{
    class Konyv
    {
        private string iro;
        public string Iro
        {
            get { return iro; }
            private set
            {
                if (value.Length < 3)
                    throw new Exception("A könyv írója rövidebb mint 3 karakter");
                else if(value.Length > 50)
                    throw new Exception("A könyv írója hosazbb mint 50 karakter");
                iro = value;
            }
        }

        private string cim;
        public string Cim
        {
            get { return cim; }
            private set
            {
                if (value.Length < 3)
                    throw new Exception("A könyv írója rövidebb mint 3 karakter");
                else if (value.Length > 50)
                    throw new Exception("A könyv írója hosazbb mint 50 karakter");
                cim = value;
            }
        }

        private ushort kiadasEve;
        public ushort KiadasEve
        {
            get { return kiadasEve; }
            private set
            {
                if (value < 1910)
                    throw new Exception("A könyv kiadás éve kisebb mint 1910");
                else if (value > DateTime.Today.Year)
                    throw new Exception("A könyv kiadás éve nagyobb mint a mai dátum");
                kiadasEve = value;
            }
        }

        private ushort ar;
        public ushort Ar
        {
            get { return ar; }
            set
            {
                if (value > 30000)
                    throw new Exception("A könyv ára nagyobb mint 30000");
                else if (value % 5 != 0)
                    throw new Exception("A könyv ára nem osztaható 5-el");
                ar = value;
            }
        }
        public enum Mufajok { mese, regény, történelem, szakkönyv, külföldi };
        private Mufajok Mufaj;
        /// <summary>
        /// konstruktor álltalános
        /// </summary>
        /// <param name="iro">aki írta a könyvet(string)</param>
        /// <param name="cim">a könyv címe(string)</param>
        /// <param name="kiadaseve">a könyv kiadás éve(ushort)</param>
        /// <param name="ar">a könyv ára (ushort)</param>
        /// <param name="mufaj">a műfaja (enum)</param>
        public Konyv(string iro, string cim, ushort kiadaseve, ushort ar, Mufajok mufaj)
        {
            Iro = iro;
            Cim = cim;
            KiadasEve = kiadaseve;
            Ar = ar;
            Mufaj = mufaj;

        }
        /// <summary>
        /// konstruktor egyedi
        /// </summary>
        /// <param name="iro">aki írta a könyvet(string)</param>
        /// <param name="cim">a könyv címe(string)</param>
        /// <param name="ar">a könyv ára (ushort)</param>
        public Konyv(string iro, string cim, ushort ar) : this(iro, cim,(ushort)DateTime.Today.Year,ar,Mufajok.szakkönyv)
        {
            Iro = iro;
            Cim = cim;
            Ar = ar;
        }
        public override string ToString()
        {
            return Cim;
        }
    }
}
