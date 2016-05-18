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
            SimpleIoc.Default.Register<AboutPage>();

        }

        public ContactPage ContactPage => ServiceLocator.Current.GetInstance<ContactPage>();        
        public AboutPage AboutPage => ServiceLocator.Current.GetInstance<AboutPage>();

    }
}
