namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca BibliotecaDiBologna = new Biblioteca();
            BibliotecaDiBologna.AggiungiUtente(new Utente("Max", "Gilli", "max.gilli98@gmail.com", "pwtest", 3333333));
            BibliotecaDiBologna.AggiungiUtente(new Utente("Luca", "Rossi", "luca.rossi@gmail.com", "pwtest", 3338543));
            BibliotecaDiBologna.AggiungiUtente(new Utente("Mario", "Neri", "mario.neri@gmail.com", "pwtest", 3342353));
            BibliotecaDiBologna.AggiungiUtente(new Utente("Giorgio", "Bianchi", "giorgio.bianchi@gmail.com", "pwtest", 3334653));
            BibliotecaDiBologna.AggiungiUtente(new Utente("Matteo", "Rosi", "matteo.rosi@gmail.com", "pwtest", 3332563));
            Console.WriteLine("Utenti:");
            BibliotecaDiBologna.StampaLista(BibliotecaDiBologna.Utenti);

            BibliotecaDiBologna.AggiungiDocumento(new Dvd(0, "Jurassic Park", 1993, new List<string> { "avventura", "azione" }, "2F", new Autore("Spielberg", "Steven"), 120));
            BibliotecaDiBologna.AggiungiDocumento(new Dvd(1, "Il Padrino", 1972, new List<string> { "Crime", "Drama" }, "5B", new Autore("Francis", "Ford Coppola"), 120));
            BibliotecaDiBologna.AggiungiDocumento(new Dvd(2, "Forrest Gump", 1994, new List<string> { "Drama", "Romance" }, "9K", new Autore("Robert", "Zemeckis"), 120));
            BibliotecaDiBologna.AggiungiDocumento(new Dvd(3, "Matrix", 1999, new List<string> { "Action", "Sci-Fi" }, "2L", new Autore("Lana", "Wachowski"), 120));
            BibliotecaDiBologna.AggiungiDocumento(new Dvd(4, "Inception", 2010, new List<string> { "Action", "Adventure", "Sci-Fi" }, "1A", new Autore("Christopher", "Nolan"), 120));

            BibliotecaDiBologna.AggiungiDocumento(new Libro(5, "Il Signore degli Anelli", 1954, new List<string> { "Fantasy" }, "5M", new Autore("J.R.R.", "Tolkien"), 1178));
            BibliotecaDiBologna.AggiungiDocumento(new Libro(6, "Harry Potter e la Pietra Filosofale", 1997, new List<string> { "Fantasy" }, "2V", new Autore("J.K.", "Rowling"), 332));
            BibliotecaDiBologna.AggiungiDocumento(new Libro(7, "Cronache del Ghiaccio e del Fuoco", 1996, new List<string> { "Fantasy" }, "4J", new Autore("George R.R.", "Martin"), 694));
            BibliotecaDiBologna.AggiungiDocumento(new Libro(8, "1984", 1949, new List<string> { "Dystopian", "Political Fiction" }, "8D", new Autore("George", "Orwell"), 328));
            BibliotecaDiBologna.AggiungiDocumento(new Libro(9, "Il nome della rosa", 1980, new List<string> { "Historical", "Mystery" }, "7C", new Autore("Umberto", "Eco"), 502));
            Console.WriteLine("Documenti:");
            BibliotecaDiBologna.StampaLista(BibliotecaDiBologna.Documenti);

            BibliotecaDiBologna.NuovoPrestito(BibliotecaDiBologna.Utenti[0], BibliotecaDiBologna.Documenti[4], DateTime.Now, BibliotecaDiBologna.DataDiSCadenza(DateTime.Now));
            BibliotecaDiBologna.NuovoPrestito(BibliotecaDiBologna.Utenti[1], BibliotecaDiBologna.Documenti[3], DateTime.Now, BibliotecaDiBologna.DataDiSCadenza(DateTime.Now));
            BibliotecaDiBologna.NuovoPrestito(BibliotecaDiBologna.Utenti[2], BibliotecaDiBologna.Documenti[7], DateTime.Now, BibliotecaDiBologna.DataDiSCadenza(DateTime.Now));
            Console.WriteLine("Prestiti:");
            BibliotecaDiBologna.StampaLista(BibliotecaDiBologna.Prestiti);

            Console.WriteLine("------------------------------------------------------------------------------------------------");
            BibliotecaDiBologna.StampaLista(BibliotecaDiBologna.CercaDocumentiPerCodice(0));
            BibliotecaDiBologna.StampaLista(BibliotecaDiBologna.CercaDocumentiPerTitolo("Il Padrino"));
            BibliotecaDiBologna.StampaLista(BibliotecaDiBologna.CercaPrestitiPerUtente("Gilli", "Max"));
        }
    }
}

