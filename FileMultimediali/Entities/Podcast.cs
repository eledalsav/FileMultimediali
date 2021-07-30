using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMultimediali
{
    class Podcast:File
    {
        public string Descrizione { get; set; }
        public List<StructEpisodio> episodi { get; set; }

        public Podcast(string titolo, Autore autore, string descrizione, List<StructEpisodio> episodi1)
            :base(titolo, autore)
        {
            Descrizione = descrizione;
            episodi = episodi1;
        }

        public Podcast()
        {

        }
        public override string Print()
        {
            return $"{base.Print()} - {Descrizione}";
        }
    }

    public struct StructEpisodio
    {
        public string Titolo;
        public StructDurata Durata;
        public bool Ascoltato;

        public StructEpisodio(string titolo, StructDurata durata, bool ascoltato)
        {
            Titolo = titolo;
            Durata = durata;
            Ascoltato = false;

        }
    }
    public struct StructDurata
    {
        public int Ore { get; set; }
        public int Minuti { get; set; }
        public int Secondi { get; set; }

        public StructDurata(int ore, int min, int sec)
        {
            Ore = ore;
            Minuti = min;
            Secondi = sec;
        }
    }
}
