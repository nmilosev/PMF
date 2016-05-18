using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMF.Views
{
    public class ViewLocator
    {
        public ViewLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<ContactPage>();
        }

        public ContactPage ContactPage
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ContactPage>();
            }
        }
    }
}
