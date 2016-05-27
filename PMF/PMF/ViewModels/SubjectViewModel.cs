using GalaSoft.MvvmLight;
using PMF.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PMF.ViewModels
{
    public class SubjectViewModel : ViewModelBase
    {
        public Subject Current { get; set; }

        public SubjectViewModel()
        {
            Email = new Command<string>((email) => SendEmail(email));
            URL = new Command<string>((url) => Visit(url));
        }

        private void Visit(string url)
        {
            if (url.StartsWith("http://"))
                Plugin.Share.CrossShare.Current.OpenBrowser(url);
            else
                Plugin.Share.CrossShare.Current.OpenBrowser("http://" + url);
        }

        private void SendEmail(string email)
        {
            var emailMessenger = Plugin.Messaging.CrossMessaging.Current.EmailMessenger;
            if (emailMessenger.CanSendEmail)
            {
                emailMessenger.SendEmail(email, Current.Title, string.Empty);
            }
        }

        public Command Email { get; set; }

        public Command URL { get; set; }

    }
}
