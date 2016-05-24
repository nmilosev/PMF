using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PMF.Navigation
{
    public class Navigator
    {
        private Views.ViewLocator _viewLocator = (Application.Current.Resources["ViewLocator"] as Views.ViewLocator);

        public void HideMenu()
        {
            _viewLocator.MainPage.IsPresented = false;
        }

        public void ShowMenu()
        {
            _viewLocator.MainPage.IsPresented = true;
        }

        public void Navigate(Type pageType)
        {
            var page = SimpleIoc.Default.GetInstance(pageType) as Page;
            _viewLocator.MainPage.Detail = new NavigationPage(page);
        }

        public void NavigateModal(Type pageType)
        {
            var page = SimpleIoc.Default.GetInstance(pageType) as Page;
            var navpage = new NavigationPage(page);
            _viewLocator.MainPage.Navigation.PushModalAsync(navpage);
        }

        public void GoBackModal()
        {
            _viewLocator.MainPage.Navigation.PopModalAsync();
        }
    }
}
