using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMultimediali
{
    public abstract class File
    {
        public string Titolo { get; set; }
        public Autore Autore { get; set; }

        public File(string titolo, Autore autore)
        {
            Titolo = titolo;
            Autore = autore;
        }

        public File()
        {

        }

        public virtual string Print()
        {
            return $"{Titolo} - {Autore.Nome} {Autore.Cognome} {Autore.AnnoDiNascita}";
        }
    }
   
}
