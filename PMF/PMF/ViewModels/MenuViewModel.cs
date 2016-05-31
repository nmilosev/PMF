using Acr.UserDialogs;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using PMF.Core.Interfaces;
using PMF.Dictionaries;
using PMF.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PMF.ViewModels
{
    public class MenuViewModel : ViewModelBase
    {
        public Command DMICommand
        {
            get
            {
                return new Command(() =>
                {
                    SimpleIoc.Default.GetInstance<Navigator>().HideMenu();
                    Plugin.Share.CrossShare.Current.OpenBrowser("DMILink".Localize());
                });
            }
        }

        public Command InfoCommand
        {
            get
            {
                return new Command(() =>
                {
                    SimpleIoc.Default.GetInstance<Navigator>().HideMenu();
                    SimpleIoc.Default.GetInstance<Navigator>().Navigate(typeof(Views.AboutPage));
                });
            }
        }

        public Command StudentServicesCommand => new Command(() =>
            {
                var navigator = SimpleIoc.Default.GetInstance<Navigator>();
                navigator.HideMenu();
                navigator.Navigate(typeof(Views.StudentServicesPage));
            });

        public Command WelcomeCommand
        {
            get
            {
                return new Command(() =>
                {
                    SimpleIoc.Default.GetInstance<Navigator>().HideMenu();
                    SimpleIoc.Default.GetInstance<Navigator>().Navigate(typeof(Views.WelcomePage));
                });
            }
        }

        public List<MenuItem> MenuList
        {
            get
            {
                return new List<MenuItem>()
                {
                    new MenuItem() { Id = "News", Text = "ButtonNews".Localize(), Icon = "newspaper.png" },
                    new MenuItem() { Id = "Schedule", Text = "ButtonSchedule".Localize(), Icon = "calendar.png" },
                    new MenuItem() { Id = "Programs", Text = "ButtonPrograms".Localize(), Icon = "arrows.png" },
                    new MenuItem() { Id = "StudService", Text = "ButtonStudServices".Localize(), Icon = "sitemap.png" },
                    new MenuItem() { Id = "FAQ", Text = "ButtonFAQ".Localize(), Icon = "faq.png" },
                    new MenuItem() { Id = "Contact", Text = "ButtonContact".Localize(), Icon = "phonebook.png" }
                };
            }
        }

        public Command MenuCommand => new Command<string>(CommandAction);

        public async void CommandAction(string actionName)
        {
            SimpleIoc.Default.GetInstance<Navigator>().HideMenu();

            switch (actionName)
            {
                case "StudService":
                    await Plugin.Share.CrossShare.Current.OpenBrowser("SSluzbaLink".Localize());
                    break;
                case "Contact":
                    SimpleIoc.Default.GetInstance<Navigator>().Navigate(typeof(Views.ContactPage));
                    break;
                case "News":
                    SimpleIoc.Default.GetInstance<Navigator>().Navigate(typeof(Views.NewsPage));
                    break;
                case "Schedule":
                    SimpleIoc.Default.GetInstance<Navigator>().Navigate(typeof(Views.SchedulePage));
                    break;
                case "FAQ":
                    SimpleIoc.Default.GetInstance<Navigator>().Navigate(typeof(Views.FAQPage));
                    break;
                case "Programs":
                    var departments = SimpleIoc.Default.GetInstance<IDepartmentsSource>();

                    using (UserDialogs.Instance.Loading("PleaseWait".Localize()))
                    {
                        (Application.Current.Resources["ViewModelLocator"] as ViewModelLocator).Programs.Departments =
                        new System.Collections.ObjectModel.ObservableCollection<Core.Models.Department>(await departments.Departments(Translator.CurrentCultureCode));
                    }

                    if (departments.IsDataValid)
                        SimpleIoc.Default.GetInstance<Navigator>().Navigate(typeof(Views.DepartmentsPage));
                    else
                        UserDialogs.Instance.ErrorToast("Error".Localize(), "ProgramsError".Localize(), 1500);
                    break;
                default:
                    await (Application.Current.Resources["ViewLocator"] as Views.ViewLocator).MainPage.DisplayAlert("Command", actionName, "OK");
                    break;
            }
        }

    }

    public class MenuItem
    {
        public string Id { get; set; }

        public string Text { get; set; }

        public string Icon { get; set; }

    }
}
