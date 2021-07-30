using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMultimediali
{
    class CanzoniRepository : IRepository<Canzone>
    {
        static List<Canzone> canzoni = new List<Canzone>()
        {
           new Canzone ("Love my life", new Autore ("Robbie","Williams",1974), EnumGenere.Pop ),
           new Canzone ("Non me lo so spiegare", new Autore ("Tiziano","Ferro",1980), EnumGenere.Pop ),
           new Canzone ("With or without you", new Autore ("U2","//", 1976), EnumGenere.Rock ),

        };
        public List<Canzone> Fetch()
        {
            return canzoni;
        }

        public List<Canzone> GetByGenere(EnumGenere genere)
        {
            return canzoni.Where(c => c.Genere==genere).ToList();
        }
    }
}
