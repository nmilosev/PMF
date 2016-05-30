using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMF.Core.Interfaces;
using PMF.Core.Models;
using GalaSoft.MvvmLight.Ioc;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Acr.UserDialogs;
using PMF.Dictionaries;
using PMF.Navigation;

namespace PMF.ViewModels
{
    public class ProgramsViewModel : ViewModelBase
    {
        public ObservableCollection<Department> Departments { get; set; }

        public class ProgramLevel
        {
            public string Title { get; set; }
            public ObservableCollection<Program> Programs { get; set; }
        }

        public ObservableCollection<Program> BScPrograms { get; set; }
        public ObservableCollection<Program> MScPrograms { get; set; }
        public ObservableCollection<Program> PhDPrograms { get; set; }

        public Department CurrentDepartment { get; set; }

        public ObservableCollection<ProgramLevel> Programs => new ObservableCollection<ProgramLevel>()
        {
            new ProgramLevel() { Programs = BScPrograms, Title = nameof(BScPrograms).Localize() },
            new ProgramLevel() { Programs = MScPrograms, Title = nameof(MScPrograms).Localize() },
            new ProgramLevel() { Programs = PhDPrograms, Title = nameof(PhDPrograms).Localize() }
        };

        public Command OpenDepartmentsPrograms
        {
            get
            {
                return new Command<Department>(async (d) =>
                {
                    CurrentDepartment = d;

                    bool loadingOk = false;

                    using (UserDialogs.Instance.Loading("PleaseWait".Localize()))
                    {
                        var svc = SimpleIoc.Default.GetInstance<IProgramsSource>();

                        var programs = await svc.ForDepartment(d.Id, Translator.CurrentCultureCode);
                        if (svc.IsDataValid)
                        {
                            loadingOk = true;

                            BScPrograms = new ObservableCollection<Program>(programs.Where(p => p.Type == ProgramType.BSc).ToList());
                            MScPrograms = new ObservableCollection<Program>(programs.Where(p => p.Type == ProgramType.MSc).ToList());
                            PhDPrograms = new ObservableCollection<Program>(programs.Where(p => p.Type == ProgramType.PhD).ToList());

                            SimpleIoc.Default.GetInstance<Navigator>().NavigateModal(typeof(Views.ProgramsPage));
                        }
                    }

                    if (!loadingOk)
                    {
                        UserDialogs.Instance.ErrorToast("Error".Localize(), "ProgramsError".Localize(), 1500);
                    }
                });
            }
        }

        public Command OpenProgramDetails
        {
            get
            {
                return new Command<Program>(async (p) =>
                {

                    bool loadingOk = false;

                    using (UserDialogs.Instance.Loading("PleaseWait".Localize()))
                    {
                        var svc = SimpleIoc.Default.GetInstance<IProgramsSource>();

                        var program = await svc.ForId(p.Id, Translator.CurrentCultureCode);
                        if (svc.IsDataValid)
                        {
                            loadingOk = true;
                            CurrentProgram = program;
                            SimpleIoc.Default.GetInstance<Navigator>().NavigateModal(typeof(Views.ProgramDetailsPage));
                        }
                    }

                    if (!loadingOk)
                    {
                        UserDialogs.Instance.ErrorToast("Error".Localize(), "ProgramsError".Localize(), 1500);
                    }
                });
            }
        }

        public Program CurrentProgram { get; set; }


        public Command NextCarouselPage => new Command(() => SimpleIoc.Default.GetInstance<Navigator>().GoForwardCarousel(typeof(Views.ProgramDetailsPage)));
      
        
    }
}
