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

                            CurrentModules = new ObservableCollection<ModuleViewModel>();
                            CurrentModuleNames = new List<string>();
                            CurrentSemesters = new List<string>();

                            foreach (var m in program.Modules)
                            {
                                var mvm = new ModuleViewModel(m.ModuleSubjects) { Id = m.Id, Name = m.Name };
                                CurrentModules.Add(mvm);
                                CurrentModuleNames.Add(m.Name);
                            }

                            foreach (var s in Enumerable.Range(1, p.Years * 2))
                            {
                                CurrentSemesters.Add($"{s}. {"Semester".Localize()}");
                            }

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

        public Command OpenSubjectDetails => new Command<Subject>(async (p) =>
        {
            var subjectsData = SimpleIoc.Default.GetInstance<ISubjectsSource>();

            Subject s;

            using (UserDialogs.Instance.Loading("PleaseWait".Localize()))
            {
                s = await subjectsData.ForId(p.Id, Dictionaries.Translator.CurrentCultureCode);
            }

            if (subjectsData.IsDataValid)
            {
                SimpleIoc.Default.GetInstance<SubjectViewModel>().Current = s;
                SimpleIoc.Default.GetInstance<Navigator>().NavigateModal(typeof(Views.SubjectPage));
            }
            else
            {
                UserDialogs.Instance.ErrorToast("Error".Localize(), "SubjectLoadError".Localize(), 1500);
            }

        });

        public ObservableCollection<ModuleViewModel> CurrentModules { get; set; }

        public class ModuleViewModel : ObservableCollection<Subject>
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public ModuleViewModel(IEnumerable<Subject> s) : base(s)
            {
            }
        }

        public List<string> CurrentModuleNames { get; set; }
        public List<string> CurrentSemesters { get; set; }

        public int CurrentModuleId { get; set; }
        public int CurrentSemesterId { get; set; }

        public Command OpenWizardResults => new Command(() =>
        {
            using (UserDialogs.Instance.Loading("PleaseWait".Localize()))
            {
                var semester = CurrentSemesterId + 1;

                var programMandatoryClasses = CurrentProgram.MandatorySubjects.Where(s => s.Semester == semester).ToList();
                var programOptionalClasses = CurrentProgram.OptionalSubjects.Where(s => s.Semester == semester).ToList();
                var moduleClasses = CurrentModules[CurrentModuleId].Where(s => s.Semester == semester).ToList();

                var vm = new ObservableCollection<WizardViewModel.SubjectWizardViewModel>()
                {
                    new WizardViewModel.SubjectWizardViewModel(programMandatoryClasses, autoCheck: true) { Title = "MandatoryClasses".Localize() },
                    new WizardViewModel.SubjectWizardViewModel(moduleClasses, autoCheck: true) { Title = "ModulesClasses".Localize() },
                    new WizardViewModel.SubjectWizardViewModel(programOptionalClasses) { Title = "OptionalClasses".Localize() },
                };

                (Application.Current.Resources["ViewModelLocator"] as ViewModelLocator).Wizard.CurrentSubjects = vm;
                (Application.Current.Resources["ViewModelLocator"] as ViewModelLocator).Wizard.Semester = semester;
                (Application.Current.Resources["ViewModelLocator"] as ViewModelLocator).Wizard.CurrentModuleName = CurrentModuleNames[CurrentModuleId];
                (Application.Current.Resources["ViewModelLocator"] as ViewModelLocator).Wizard.CurrentProgram = CurrentProgram;

            }

            SimpleIoc.Default.GetInstance<Navigator>().NavigateModal(typeof(Views.WizardPage));

        });

    }
}
