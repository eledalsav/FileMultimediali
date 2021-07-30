using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMultimediali
{
    public class Autore
        {
            public string Nome;
            public string Cognome;
            public int AnnoDiNascita;

            public Autore(string nome, string cognome, int annoDiNascita)
            {
                Nome = nome;
                Cognome = cognome;
                AnnoDiNascita = annoDiNascita;
            }
            public Autore()
            {

            }

        }
    }
