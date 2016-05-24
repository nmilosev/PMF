using GalaSoft.MvvmLight;
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
                return Dictionaries.AppDictionary.ContactPhoneLabel + Dictionaries.AppDictionary.ContactPhone;
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
                        emailMessenger.SendEmail(Dictionaries.AppDictionary.ContactEmail, Dictionaries.AppDictionary.AppName, string.Empty);                        
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
                        phoneDialer.MakePhoneCall(Dictionaries.AppDictionary.ContactPhone, Dictionaries.AppDictionary.PMFName);
                });
            }
        }
    }
}
