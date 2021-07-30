using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMultimediali
{
    class Canzone:File
    {
        public EnumGenere Genere { get; set; }

        
        public Canzone(string titolo, Autore autore, EnumGenere genere)
        :base(titolo, autore)
        {
            Genere = genere;
        }

        public override string Print()
        {
            return $"{base.Print()} - {Genere}";
        }


    }
    enum EnumGenere
    {
        Rock,
        Pop,
        Jazz,
        Punk
    }
}
