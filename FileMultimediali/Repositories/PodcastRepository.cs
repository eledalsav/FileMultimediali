using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMultimediali
{
    class PodcastRepository : IRepository<Podcast>
    {
        static List<Podcast> pocasts = new List<Podcast>()
        {
            new Podcast("Le grandi battaglie della storia", new Autore("Alessandro","Barbero",1959 ), "storia", Repositories.EpisodiRepository.ListaEpisodi("Le grandi battaglie della Storia")),
            new Podcast("Il coronavirus", new Autore("FIlippo","Santelli",1980), "attualità", Repositories.EpisodiRepository.ListaEpisodi("Il coronavirus")),

        };
        public List<Podcast> Fetch()
        {
            return pocasts;
        }

        public List<StructEpisodio> GetByTitle(string titolo)
        {
            return Repositories.EpisodiRepository.ListaEpisodi( titolo);
        }

        public List<StructEpisodio> GetByDurata(StructDurata durata)
        {
            List<StructEpisodio> episodidurata1 = new List<StructEpisodio>();
            List<StructEpisodio> episodidurata2 = new List<StructEpisodio>();
            foreach (var item in pocasts)
            {
                episodidurata2=( item.episodi.Where(Er => Er.Durata.Ore <= durata.Ore && Er.Durata.Minuti <= durata.Minuti && Er.Durata.Secondi <= durata.Secondi).ToList());
                episodidurata1.AddRange(episodidurata1);
            }
            return episodidurata1;
        }
    }
    }

