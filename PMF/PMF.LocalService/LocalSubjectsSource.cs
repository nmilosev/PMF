using PMF.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMF.Core.Models;

namespace PMF.LocalService
{
    public class LocalSubjectsSource : ISubjectsSource
    {
        public bool IsAvailable
        {
            get
            {
                return true;
            }
        }

        public bool IsModelValid
        {
            get
            {
                return new Random().NextDouble() > 0.2 ? true : false;
            }
        }

        public bool RequireConnection
        {
            get
            {
                return false;
            }
        }

        //simulate network errors
        public bool IsDataValid => new Random().NextDouble() > 0.2 ? true : false;

        public async Task<Subject> ForId(string id, string langCode)
        {
            //simulate network delay
            await Task.Delay((int)(3000 * new Random().NextDouble()));
            return new Subject()
            {
                Id = "IA221",
                ESPB = 7,
                Title = "Baze Podataka 1",
                Goal = @"Osposobljavanje studenata za projektovanje, kreiranje i korišćenje (SQL upiti) relacionog modela
baze podataka, kao i za savladavanje principa funkcionisanja SUBP-a.",
                Outcome = @"Minimalni: Na kraju kursa, očekuje se da uspešan student bude sposoban da projektuje relacioni
model podataka za ilustrativni primer realnog sistema u odgovarajućem CASE alatu, na osnovu
njega konstruiše bazu podataka i postavi ilustrativni SQL upit.
Poželjni: Na kraju kursa, očekuje se da uspešan student demonstrira razumevanje osnovnih
principa projektovanja i kreiranja relacionog modela baze na ilustrativnom primeru realnog
sistema u odgovarajućem CASE alatu, postavljanja SQL upita i funkcionisanja SUBP-a.",
                Contents = @"Teorijska nastava
Osnovni pojmovi i termini. Koncepcija baze podataka. Osnovni modeli podataka. Model entiteta
i poveznika i njegovo povezivanje sa objektnim modelom podataka. Relacioni model podataka. SQL
kao jezik za manipulisanje podacima. Prevođenje ER u relacioni model podataka. Razdvajanje
logičke i fizičke strukture podataka. Funkcionisanje sistema za upravljanje bazama podataka.

Praktična nastava
Uvežbavanje projektovanja ER modela podataka na ilustrativnim primerima, korišćenjem
odgovarajućeg CASE alata. Uvežbavanje projektovanja relacionog modela podataka putem prevođenja
ER modela podataka u odgovarajućem CASE alatu. Manipulisanje podacima putem ilustrativnih
SQL upita.",
                Literature = @"Preporučena: Miloš Racković, Srđan Škrbić, Jovana Vidaković, Uvod u Baze podataka,
Univerzitet u Novom Sadu, Prirodno-matematički fakultet, Departman za matematiku i
informatiku, Novi Sad, 2007.
Alternativna: Pavle Mogin, Ivan Luković, Principi baza podataka, Univerzitet u Novom Sadu,
Fakultet tehničkih nauka, 1996.",
                Classes = @"Teorijska nastava: 2 
Praktična nastava: 3",
                Method = @"Na predavanjima se koriste klasične metode nastave uz korišćenje projektora. Objašnjavaju se
principi baza podataka koji se ilustruju odgovarajućim primerima. Na vežbama se koristi
odgovarajući CASE alat za uvežbavanje projektovanja ER modela i njegovog prevođenja u relacioni
model. Takođe se vežba postavljanje SQL upita, sve uz korišćenje računara. U toku vežbi se znanje
studenata testira kroz dva testa koji pokrivaju redom: prevođenje ER u relacioni model i SQL
upite. Studenti na kraju vežbi dobijaju praktičan zadatak koji se sastoji od samostalnog
projektovanja ER modela podataka i njegovog prevođenja u relacioni model. Na usmenom delu ispita
se praktični rad brani kroz proveru razumevanja kreiranog modela. Student takođe pokazuje
razumevanje principa funkcionisanja SUBP-a.",
                Professors = new List<Staff>()
                {
                    new Staff()
                    {
                        Id = "1",
                        FirstName = "Miloš",
                        LastName = "Racković",
                        URL = "www.is.pmf.uns.ac.rs/rackovicm",
                        Email = "milos.rackovic@dmi.uns.ac.rs",
                        Title = "dr",
                        ImageURL = "http://www.is.pmf.uns.ac.rs/rackovicm/images/m_rackovic.png",
                        Vocation = "redovni profesor"
                    }
                },
                Assistaints = new List<Staff>()
                {
                    new Staff()
                    {
                        Id = "10",
                        FirstName = "Jovana",
                        LastName = "Vidaković",
                        URL = "www.is.pmf.uns.ac.rs/vidakovicj",
                        Email = "jovana@dmi.uns.ac.rs",
                        Title = "dr",
                        ImageURL = "http://www.is.pmf.uns.ac.rs/vidakovicj/img/Jovana.jpg",
                        Vocation = "redovni profesor"                        
                    }
                },
                URLs = new List<string>() { "http://www.is.pmf.uns.ac.rs/vidakovicj/nastava.html", "http://moodle.pmf.uns.ac.rs/course/view.php?id=158" }
            };
        }
    }
}
