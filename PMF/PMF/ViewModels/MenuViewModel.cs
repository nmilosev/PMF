using GalaSoft.MvvmLight;
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
                    App.MasterDetailPage.IsPresented = false;
                    Device.OpenUri(new Uri(Dictionaries.AppDictionary.DMILink, UriKind.Absolute));
                });
            }
        }

        public Command InfoCommand
        {
            get
            {
                return new Command(() =>
                {
                    App.MasterDetailPage.DisplayAlert("Informacije!", "idem", "OK");
                    App.MasterDetailPage.IsPresented = false;
                });
            }
        }

        public List<MenuItem> MenuList
        {
            get
            {
                return new List<MenuItem>()
                {
                    new MenuItem() { Id = "News", Text = Dictionaries.AppDictionary.ButtonNews, Command = new Command<string>(CommandAction), Icon = "newspaper.png" },
                    new MenuItem() { Id = "Schedule", Text = Dictionaries.AppDictionary.ButtonSchedule, Command = new Command<string>(CommandAction),Icon = "calendar.png" },
                    new MenuItem() { Id = "Programs", Text = Dictionaries.AppDictionary.ButtonPrograms, Command = new Command<string>(CommandAction), Icon = "arrows.png" },
                    new MenuItem() { Id = "Contact", Text = Dictionaries.AppDictionary.ButtonContact, Command = new Command<string>(CommandAction), Icon = "phonebook.png" },
                    new MenuItem() { Id = "StudService", Text = Dictionaries.AppDictionary.ButtonStudServices, Command = new Command<string>(CommandAction), Icon = "sitemap.png" }
                };
            }
        }
        
        public void CommandAction(string actionName)
        {
            App.MasterDetailPage.IsPresented = false;

            switch (actionName)
            {
                case "StudService":
                    Device.OpenUri(new Uri(Dictionaries.AppDictionary.SSluzbaLink, UriKind.Absolute));
                    break;
                case "Contact":
                    App.MasterDetailPage.Detail = new NavigationPage(App.ViewLocator.ContactPage);
                    break;
                default:
                    App.MasterDetailPage.DisplayAlert("Komanda", actionName, "OK");
                    break;
            }
        }
      
    }

    public class MenuItem
    {
        public string Id { get; set; }
        
        public string Text { get; set; }

        public string Icon { get; set; }

        public Command Command { get; set; }

    }
}
