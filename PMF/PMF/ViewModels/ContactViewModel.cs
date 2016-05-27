using GalaSoft.MvvmLight;
using PMF.Dictionaries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PMF.ViewModels
{
    public class ContactViewModel : ViewModelBase
    {
        public string PhoneLabel
        {
            get
            {
                return "ContactPhoneLabel".Localize() + "ContactPhone".Localize();
            }
        }
        
        public Command EmailCommand
        {
            get
            {
                return new Command(() =>
                {
                    var emailMessenger = Plugin.Messaging.CrossMessaging.Current.EmailMessenger;
                    if (emailMessenger.CanSendEmail)
                    {
                        emailMessenger.SendEmail("ContactEmail".Localize(), "AppName".Localize(), string.Empty);                        
                    }
                });
            }
        }

        public Command PhoneCommand
        {
            get
            {
                return new Command(() =>
                {
                    var phoneDialer = Plugin.Messaging.CrossMessaging.Current.PhoneDialer;
                    if (phoneDialer.CanMakePhoneCall)
                        phoneDialer.MakePhoneCall("ContactPhone".Localize(), "PMFName".Localize());
                });
            }
        }
    }
}
