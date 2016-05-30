using PMF.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMF.Core.Models;

namespace PMF.LocalService
{
    public class LocalProgramsSource : IProgramsSource
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
                return true;
            }
        }

        //simulate network errors
        public bool IsDataValid => new Random().NextDouble() > 0.2 ? true : false;

        public async Task<List<Program>> ForDepartment(int departmentId, string langCode)
        {
            await Task.Delay((int)(3000 * new Random().NextDouble()));

            return new List<Program>()
            {
                new Program()
                {
                    Id = 1,
                    Name = "Informatika - osnovne studije",
                    Type = ProgramType.BSc,
                    Title = "Informatičar",
                    Years = 3
                },
                new Program()
                {
                    Id = 2,
                    Name = "Informatika - osnovne studije",
                    Type = ProgramType.BSc,
                    Title = "Diplomirani informatičar",
                    Years = 4
                },
                new Program()
                {
                    Id = 3,
                    Name = "Informatika - master studije",
                    Type = ProgramType.MSc,
                    Title = "Master informatičar",
                    Years = 2
                },
                new Program()
                {
                    Id = 4,
                    Name = "Matematika - osnovne studije",
                    Type = ProgramType.BSc,
                    Title = "Diplomirani matematičar",
                    Years = 4
                },
                new Program()
                {
                    Id = 5,
                    Name = "Matematika - osnovne studije",
                    Type = ProgramType.BSc,
                    Title = "Matematičar",
                    Years = 3
                },
                new Program()
                {
                    Id = 6,
                    Name = "Matematika - master studije",
                    Type = ProgramType.MSc,
                    Title = "Master matematičar",
                    Years = 2
                }
            };
        }

        public async Task<Program> ForId(int programId, string langCode)
        {
            await Task.Delay((int)(3000 * new Random().NextDouble()));
            return new Program()
            {
                Id = 1,
                Name = "Informatika - osnovne studije",
                Type = ProgramType.BSc,
                Title = "Informatičar",
                Years = 3,
                Goals = "Svrha ovog studijskog programa je osnovno obrazovanje informatičara sposobnih za rad u privredi, u praktičnim fazama i ulogama tokom razvoja softvera.",
                Purpose= @"Osnovni ciljevi studijskog programa:
    • upoznavanje sa osnovnim informatičkim principima, metodama i tehnikama potrebnim za rešavanje problema pomoću računara, kao i za primenu računara u različitim oblastima ljudskog delovanja,
    • usvajanje osnovnih znanja, metoda i tehnika o programiranju i programskim jezicima, programskim paradigmama (strukturiranom, objektno-orijentisanom, funkcionalnom i logičkom programiranju), algoritmima, operativnim sistemima, bazama podataka i informacionim sistemima,
    • upoznavanje sa osnovnim matematičkim disciplinama neophodnim za analizu, razumevanje, rešavanje problema, kao i za uspešnu primenu informatičkih principa i tehnika,
    • nadgradnja osnovnih informatičkih znanja naprednijim principima i tehnikama iz oblasti računarskih nauka, odnosno informacionih tehnologija,
    • priprema za uspešnu primenu informatičkih tehnika u praksi,
    • priprema za dalju nadgradnju znanja, kao teorijska i praktična podloga za usvajanje složenijih sadržaja iz oblasti informatike – tj. za dalje studiranje na master studijama,
    • razvoj visokog stepena apstraktnog, analitičkog i sintetičkog, logičkog mišljenja i razumevanje različitih stupnjeva apstrakcije u informatičkom domenu,
    • razvijanje inicijative i sposobnosti za samostalno rešavanje problema pomoću računara pravilnom upotrebom usvojenih informatičkih principa i tehnika.",
                MandatorySubjects = new List<Subject>()
                    {
                       new Subject()
                       {
                           Id = "IA221",
                           ESPB = 7,
                           Title = "Baze Podataka 1",
                           Semester = 1
                       },
                       new Subject()
                       {
                           Id = "IA222",
                           ESPB = 7,
                           Title = "Operativni sistemi 1",
                           Semester = 1
                       },
                       new Subject()
                       {
                           Id = "IA223",
                           ESPB = 7,
                           Title = "Uvod u elektronsko poslovanje",
                           Semester = 1
                       },
                       new Subject()
                       {
                           Id = "IA224",
                           ESPB = 7.5,
                           Title = "Uvod u programiranje",
                           Semester = 1
                       },
                       new Subject()
                       {
                           Id = "IA225",
                           ESPB = 8,
                           Title = "Strukture podataka i algoritmi 1",
                           Semester = 2
                       },
                       new Subject()
                       {
                           Id = "IA226",
                           ESPB = 8,
                           Title = "Objektno orijentisano programiranje 1",
                           Semester = 3
                       },
                    },
                OptionalSubjects = new List<Subject>()
                {
                    new Subject()
                    {
                        Id = "IB200",
                        ESPB = 7,
                        Title = "Statistika",
                        Semester = 1
                    },
                    new Subject()
                    {
                        Id = "IA245",
                        ESPB = 7,
                        Title = "Seminarski rad A",
                        Semester = 1
                    },
                    new Subject()
                    {
                        Id = "IA246",
                        ESPB = 7,
                        Title = "Seminarski rad B",
                        Semester = 3
                    },
                    new Subject()
                    {
                        Id = "IA247",
                        ESPB = 7,
                        Title = "Seminarski rad C",
                        Semester = 5
                    }
                },
                Modules = new List<Module>()
                {
                    new Module()
                    {
                        Id = 1,
                        Name = "Računarske nauke",
                        ModuleSubjects = new List<Subject>()
                        {
                            new Subject()
                            {
                                Id = "IA247",
                                ESPB = 7,
                                Title = "Analiza 1",
                                Semester = 1
                            },
                            new Subject()
                            {
                                Id = "IA287",
                                ESPB = 7,
                                Title = "Algebra 1",
                                Semester = 2
                            },
                            new Subject()
                            {
                                Id = "IA297",
                                ESPB = 7,
                                Title = "Analiza 2",
                                Semester = 3
                            }
                        }
                    },
                    new Module()
                    {
                        Id = 2,
                        Name = "Informacione tehnologije",
                        ModuleSubjects = new List<Subject>()
                        {
                            new Subject()
                            {
                                Id = "IA247",
                                ESPB = 7,
                                Title = "Analiza za informatičare",
                                Semester = 1
                            },
                            new Subject()
                            {
                                Id = "IA287",
                                ESPB = 7,
                                Title = "Algebra za informatičare",
                                Semester = 2
                            },
                            new Subject()
                            {
                                Id = "IA297",
                                ESPB = 7,
                                Title = "Web programiranje",
                                Semester = 6
                            }
                        }, 

                    }
                }
            };
        }
    }
}

