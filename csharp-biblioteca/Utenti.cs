using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Biblioteca
    {
        public List<Documento> Documenti { get; set; }
        public List<Utente> Utenti { get; set; }
        public List<Prestito> Prestiti { get; set; }

        public Biblioteca()
        {
            Documenti = new List<Documento>();
            Utenti = new List<Utente>();
            Prestiti = new List<Prestito>();
        }
        public List<Documento> CercaDocumentiPerCodice(int codice)
        {
            List<Documento> list = new List<Documento>();
            foreach (Documento documento in Documenti)
            {
                if (documento.Id == codice)
                {
                    list.Add(documento);
                }
            }
            return list;
        }

        public List<Documento> CercaDocumentiPerTitolo(string titolo)
        {
            List<Documento> list = new List<Documento>();
            foreach (Documento documento in Documenti)
            {
                if (documento.Titolo.Equals(titolo))
                {
                    list.Add(documento);
                }
            }
            return list;
        }
        public List<Prestito> CercaPrestitiPerUtente(string cognome, string nome)
        {
            List<Prestito> list = new List<Prestito>();
            foreach (Prestito prestito in Prestiti)
            {
                if (prestito.Utente.Cognome.Equals(cognome) && prestito.Utente.Nome.Equals(nome))
                {
                    list.Add(prestito);
                }
            }
            return list;
        }
        public void AggiungiDocumento(Documento documento)
        {
            Documenti.Add(documento);
        }

        public void AggiungiUtente(Utente utente)
        {
            Utenti.Add(utente);
        }

        public void NuovoPrestito(Utente utente, Documento documento, DateTime dataInizio, DateTime dataFine)
        {
            Prestito prestito = new Prestito
            {
                Utente = utente,
                Documento = documento,
                DataInizio = dataInizio,
                DataFine = dataFine
            };

            Prestiti.Add(prestito);
        }
        public void StampaLista<T>(List<T> lista)
        {
            foreach (var elemento in lista)
            {
                Console.WriteLine($"- {elemento}");
            }
        }
        public DateTime DataDiSCadenza(DateTime dataInizio)
        {
            return dataInizio.AddDays(31);
        }
    }
    public class Utente
    {
        public string Cognome { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Telefono { get; set; }
        public override string ToString()
        {
            return $"{Nome} {Cognome}";
        }

        public Utente(string cognome, string nome, string email, string password, int telefono)
            {
                this.Cognome = cognome;
                this.Nome = nome;
                this.Email = email;
                this.Password = password;
                this.Telefono = telefono;
            }
    }

    public class Documento
    {
        public int Id { get; set; }
        public string Titolo { get; set; }
        public int Anno { get; set; }
        public List<string> Argomenti { get; set; }
        public string Scaffale { get; set; }
        public Autore Autore { get; set; }
        public override string ToString()
        {
            return $"{Titolo} dell'anno {Anno} di {Autore} situato nello scaffale {Scaffale}";
        }

        public Documento(int id, string titolo, int anno, List<string> argomenti, string scaffale, Autore autore)
        {
            this.Id = id;
            this.Titolo = titolo;
            this.Anno = anno;
            this.Argomenti = argomenti;
            this.Scaffale = scaffale;
            this.Autore = autore;
        }

    }
    public class Autore
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public override string ToString()
        {
            return $"{Nome} {Cognome}";
        }
        public Autore(string nome, string cognome)
        {
            this.Nome = nome;
            this.Cognome = cognome;
        }
    }
    public class Libro : Documento
    {
        public int NumeroPagine { get; set; }
        public Libro(int id, string titolo, int anno, List<string> argomento, string scaffale, Autore autore, int numeroPagine)
        : base(id, titolo, anno, argomento, scaffale, autore)
        {
            NumeroPagine = numeroPagine;
        }
    }

    public class Dvd : Documento
    {
        public int Durata { get; set; }
        public Dvd(int id, string titolo, int anno, List<string> argomento, string scaffale, Autore autore, int durata)
        : base(id, titolo, anno, argomento, scaffale, autore)
        {
            Durata = durata;
        }
    }
    public class Prestito
    {
        public Utente Utente { get; set; }
        public Documento Documento { get; set; }
        public DateTime DataInizio { get; set; }
        public DateTime DataFine { get; set; }

        public override string ToString()
        {
            return $"{Utente} ha preso in prestito il {Documento} nel {DataInizio} fino al {DataFine}";
        }
    }
    
}
