using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMultimediali.Repositories
{
    class EpisodiRepository
    {
        public static List<StructEpisodio> ListaEpisodi(string titolo)
        {
            if(titolo== "Le grandi battaglie della storia")
            {
                List<StructEpisodio> episodi = new List<StructEpisodio>();
                episodi.Add(new StructEpisodio("Maratona 490 a.C.", new StructDurata(4, 3, 21), false));
                episodi.Add(new StructEpisodio("Salamina 480 a.C.", new StructDurata(2, 2, 33), false));
                episodi.Add(new StructEpisodio("Adrianopoli 378", new StructDurata(1, 23, 44), false));
                return episodi;
            }else if(titolo== "Il coronavirus")
            {
                List<StructEpisodio> episodi = new List<StructEpisodio>();
                episodi.Add(new StructEpisodio("Il caso cina", new StructDurata(1,12,3),false));
                episodi.Add(new StructEpisodio("L'evoluzione", new StructDurata(2, 34, 2), false));
                episodi.Add(new StructEpisodio("il futuro", new StructDurata(3, 23, 4), false));
                return episodi;
            }
            return null;

        }

        
        

    }
}
