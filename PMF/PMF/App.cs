using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PMF
{
    public class App : Application
    {
        public static Views.MainPage MasterDetailPage;
        public static ViewModels.ViewModelLocator ViewModelLocator;
        public static Views.ViewLocator ViewLocator;
        
        /// <summary>
        /// Initialize the app
        /// </summary>
        public App()
        {
            ViewModelLocator = new ViewModels.ViewModelLocator();
            ViewLocator = new Views.ViewLocator();
            MasterDetailPage = new Views.MainPage();
            MainPage = MasterDetailPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
