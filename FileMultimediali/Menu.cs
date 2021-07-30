using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMultimediali
{
    static class Menu
    {
        public static CanzoniRepository canzoniRep = new CanzoniRepository();
        public static PodcastRepository podcastRep = new PodcastRepository();
       
        public static Repositories.EpisodiRepository episodirep = new Repositories.EpisodiRepository();

        public static void Start()
        {
            Console.WriteLine("Benvenuto!\n");
            bool continuare=true;
            int scelta;
            while(continuare)
            {
                Console.WriteLine("Premi 1 per visualizzare tutte le canzoni.");
                Console.WriteLine("Premi 2 per visualizzare tutti i podcast.");
                Console.WriteLine("Premi 3 per visualizzare tutte le canzoni di un genere dato.");
                Console.WriteLine("Premi 4 per visualizzare tutti gli episodi di un podcast.");
                Console.WriteLine("Premi 5 per visualizzare tutti gli episodi con durata minore o uguale di una durata data.");
                Console.WriteLine("Premi 6 per creare una playlist di canzoni.");
                Console.WriteLine("Premi 7 per scegliere l'episodio da riprodurre.");
                Console.WriteLine("Premi 0 per uscire.");
                Console.WriteLine();

                do
                {
                    Console.WriteLine("Cosa vuoi fare?");
                } while ((!int.TryParse(Console.ReadLine(), out scelta)) || scelta < 0 || scelta > 7);

                switch (scelta)
                {
                    case 1:
                        {
                            //Recupera la lista delle canzoni
                            List<Canzone> canzoni = canzoniRep.Fetch();
                            //Stampa
                            StampaCanzoni(canzoni);
                           
                            break;
                        }
                    case 2:
                        {
                            //Recupera la lista dei podcast
                            List<Podcast> podcasts = podcastRep.Fetch();
                            //Stampa
                            StampaPodcast(podcasts);

                            break;
                        }
                    case 3:
                        {
                            EnumGenere genere = GetGenere();
                            //Recupera il genere cercato
                            List<Canzone> canzonigen = canzoniRep.GetByGenere(genere);
                            //Stampa le canzoni di quel genere
                            StampaCanzoni(canzonigen);
                        }
                        break;
                    case 4:
                        {
                            //Recupera il titolo cercato
                            string titolo=GetTitolo();
                            //Cerca gli episodi per titolo di podcast
                            List<StructEpisodio> episodi = podcastRep.GetByTitle(titolo);
                            //Stampa
                            StampaEpisodi(episodi);
                        }
                        break;
                    case 5:
                        {
                            //TODO: non funziona! Volevo creare una nuova lista dove inserire gli episodi di 
                            //durata minore o uguale alla durata inserita e poi stamparla
                            StructDurata durata= GetDurata();
                            List<StructEpisodio> episodidurata = podcastRep.GetByDurata(durata);
                            StampaEpisodi(episodidurata);       

                        }
                        break;
                    case 6:
                        {

                        }
                        break;
                    case 7:
                        {

                        }
                        break;
                    case 0:
                        {
                            continuare = false;
                        }
                        break;
                }



            }
        }

        private static StructDurata GetDurata()
        {
            int ore, minuti, secondi;
            do
            {
                Console.WriteLine("Inserisci le ore:");
            } while (!int.TryParse(Console.ReadLine(), out ore));
            do
            {
                Console.WriteLine("Inserisci i minuti:");
            } while (!int.TryParse(Console.ReadLine(), out minuti));
            do
            {
                Console.WriteLine("Inserisci i secondi:");
            } while (!int.TryParse(Console.ReadLine(), out secondi));
           return new StructDurata(ore, minuti, secondi);
        }

        private static void StampaEpisodi(List<StructEpisodio> episodi)
        {
            foreach(var item in episodi)
            {
                Console.WriteLine($"{item.Titolo}-{item.Durata.Ore}.{item.Durata.Minuti}.{item.Durata.Secondi}-{item.Ascoltato}");
            }
        }

        private static string GetTitolo()
        {
           
            string titolo;
            do
            {
                Console.WriteLine("Inserisci il titolo di un podcast");
                titolo = Console.ReadLine();
            } while (string.IsNullOrEmpty(titolo));
            return titolo;
        }

        internal static EnumGenere GetGenere()
        {
            Console.WriteLine($"Premi {(int)EnumGenere.Pop} per scegliere {EnumGenere.Pop}");
            Console.WriteLine($"Premi {(int)EnumGenere.Jazz} per scegliere {EnumGenere.Jazz}");
            Console.WriteLine($"Premi {(int)EnumGenere.Punk} per scegliere {EnumGenere.Punk}");
            Console.WriteLine($"Premi {(int)EnumGenere.Rock} per scegliere {EnumGenere.Rock}");

            int g;
            while (!int.TryParse(Console.ReadLine(), out g) || g < 0 || g > 3)
            {
                Console.WriteLine("Scelta non corretta, riprova");
            }

            return (EnumGenere)g;
        }

        private static void StampaCanzoni(List<Canzone> canzoni)
        {
            foreach(var item in canzoni)
            {
               Console.WriteLine($"{item.Print()}");
            }
        }
        private static void StampaPodcast(List<Podcast> podcasts)
        {
            foreach (var item in podcasts)
            {
                item.Print();
            }
        }
    }

}


