using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace beadando
{
    class Car
    {
        private string rendszam;
        Regex regex = new Regex(@"[a-zA-Z]{3}-[\d]{3}$");
        private string tulajdonos;
        private string marka;
        private string tipus;
        private int evjarat;

        public string Rendszam
        {

            get
            {
                return rendszam;
            }
            set
            {
                Match match = regex.Match(value);
                if (!match.Success)
                    throw new Exception("A rendszám formátuma nem megfelelő!");
                rendszam = value;
            }
        }

        public string Tulajdonos
        {
            get
            {
                return tulajdonos;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("A tulajdonos neve nem lehet üres!");
                if (250 < value.Length) 
                    throw new ArgumentOutOfRangeException("A mező max 250 karakter lehet!");
                tulajdonos = value;
            }
        }

        public string Marka
        {
            get
            {
                return marka;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("A márka neve nem lehet üres!");
                if (250 < value.Length)
                    throw new ArgumentOutOfRangeException("A mező max 250 karakter lehet!");
                marka = value;
            }
        }

        public string Tipus
        {
            get
            {
                return tipus;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("A típus neve nem lehet üres!");
                if (250 < value.Length)
                    throw new ArgumentOutOfRangeException("A mező max 250 karakter lehet!");
                tipus = value;
            }
        }

        public int Evjarat
        {
            get
            {
                return evjarat;
            }
            set
            {
                if (value == 0)
                    throw new ArgumentNullException("Az évjárat nem lehet üres!");
                if (value < 1900)
                    throw new Exception("Az évjárat nem lehet olyan régi!");
                evjarat = value;
            }
        }

        public override string ToString()
        {
            return tulajdonos;
        }

    }
}
