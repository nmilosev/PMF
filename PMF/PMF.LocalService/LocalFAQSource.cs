using PMF.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMF.Core.Models;

namespace PMF.LocalService
{
    public class LocalFAQSource : IFAQSource
    {
        public bool IsAvailable
        {
            get
            {
                return true;
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
        //public bool IsDataValid => new Random().NextDouble() > 0.2 ? true : false;
        public bool IsDataValid => true;

        public async Task<FAQ> FAQ(string langCode)
        {
            //sim network delay
            await Task.Delay((int)(3000 * new Random().NextDouble()));
            var f = new FAQ()
            {
                QuestionsAndAnswers = new List<QA> ()
                {
                    new QA()
                    {
                        Id = 1,
                        Question = "Koliko bodova je potrebno za budžet?",
                        Answer = "Granica za budžet biće 48 bodova. Fakulteti će na budžet u narednu godinu moći da upišu samo 20 odsto više studenata od odobrene kvote. U slučaju većeg broja studenata sa 48 bodova, rangiranje će se vršiti na osnovu uspeha, odnosno proseka koji su studenti ostvarili. Broj bodova ima prednost nad uspehom. To znači da će student sa 49 bodova imati prednost nad onim sa 48, pa makar taj imao i prosek 10. Studenti koji imaju 48 i više bodova a ne upadnu na budžet plaćaće deo školarine, odnosno samo one predmete koje prenose u narednu godinu."
                    },
                    new QA()
                    {
                        Id = 2,
                        Question = "Koliko bodova je potrebno za budžet za upis na četvrtu godinu studija?",
                        Answer = "Granica za budžet biće 48 bodova. Fakulteti će na budžet u narednu godinu moći da upišu samo 20 odsto više studenata od odobrene kvote. U slučaju većeg broja studenata sa 48 bodova, rangiranje će se vršiti na osnovu uspeha, odnosno proseka koji su studenti ostvarili. Broj bodova ima prednost nad uspehom. To znači da će student sa 49 bodova imati prednost nad onim sa 48, pa makar taj imao i prosek 10. Studenti koji imaju 48 i više bodova a ne upadnu na budžet plaćaće deo školarine, odnosno samo one predmete koje prenose u narednu godinu. Fakulteti će na budžet u narednu godinu moći da upišu samo 20 odsto više studenata od odobrene kvote. U slučaju većeg broja studenata sa 48 bodova, rangiranje će se vršiti na osnovu uspeha, odnosno proseka koji su studenti ostvarili. Broj bodova ima prednost nad uspehom. To znači da će student sa 49 bodova imati prednost nad onim sa 48, pa makar taj imao i prosek 10. Studenti koji imaju 48 i više bodova a ne upadnu na budžet plaćaće deo školarine, odnosno samo one predmete koje prenose u narednu godinu. Fakulteti će na budžet u narednu godinu moći da upišu samo 20 odsto više studenata od odobrene kvote. U slučaju većeg broja studenata sa 48 bodova, rangiranje će se vršiti na osnovu uspeha, odnosno proseka koji su studenti ostvarili. Broj bodova ima prednost nad uspehom. To znači da će student sa 49 bodova imati prednost nad onim sa 48, pa makar taj imao i prosek 10. Studenti koji imaju 48 i više bodova a ne upadnu na budžet plaćaće deo školarine, odnosno samo one predmete koje prenose u narednu godinu."
                    },
                    new QA()
                    {
                        Id = 3,
                        Question = "Koliko bodova je potrebno za budžet?",
                        Answer = "Granica za budžet biće 48 bodova."
                    }
                }
            };
            return f;
        }
    }
}
