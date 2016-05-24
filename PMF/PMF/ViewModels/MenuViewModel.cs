using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
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
                    Plugin.Share.CrossShare.Current.OpenBrowser(Dictionaries.AppDictionary.DMILink);
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
                    new MenuItem() { Id = "News", Text = Dictionaries.AppDictionary.ButtonNews, Icon = "newspaper.png" },
                    new MenuItem() { Id = "Schedule", Text = Dictionaries.AppDictionary.ButtonSchedule, Icon = "calendar.png" },
                    new MenuItem() { Id = "Programs", Text = Dictionaries.AppDictionary.ButtonPrograms, Icon = "arrows.png" },
                    new MenuItem() { Id = "Contact", Text = Dictionaries.AppDictionary.ButtonContact, Icon = "phonebook.png" },
                    new MenuItem() { Id = "StudService", Text = Dictionaries.AppDictionary.ButtonStudServices, Icon = "sitemap.png" }
                };
            }
        }

        private MenuItem _selectedItem;
        public MenuItem SelectedItem
        {
            get
            {
                /// 24 hours lost on this bug: if you return null iOS hangs
                if (Device.OS == TargetPlatform.iOS)
                    return _selectedItem;
                else
                    return null;
            }
            set
            {
                _selectedItem = value;
                CommandAction(value.Id);
                RaisePropertyChanged();
            }
        }

        public void CommandAction(string actionName)
        {
            SimpleIoc.Default.GetInstance<Navigator>().HideMenu();

            switch (actionName)
            {
                case "StudService":
                    Plugin.Share.CrossShare.Current.OpenBrowser(Dictionaries.AppDictionary.SSluzbaLink);
                    break;
                case "Contact":
                    SimpleIoc.Default.GetInstance<Navigator>().Navigate(typeof(Views.ContactPage));
                    break;
                case "News":
                    SimpleIoc.Default.GetInstance<Navigator>().Navigate(typeof(Views.NewsPage));
                    break;
                default:
                    (Application.Current.Resources["ViewLocator"] as Views.ViewLocator).MainPage.DisplayAlert("Command", actionName, "OK");
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
