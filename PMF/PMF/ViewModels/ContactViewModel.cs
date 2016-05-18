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
                    Device.OpenUri(new Uri($"mailto:{Dictionaries.AppDictionary.ContactEmail}", UriKind.Absolute));
                });
            }
        }

        public Command PhoneCommand
        {
            get
            {
                return new Command(() =>
                {
                    Device.OpenUri(new Uri($"tel:{Dictionaries.AppDictionary.ContactPhone}", UriKind.Absolute));
                });
            }
        }
    }
}
