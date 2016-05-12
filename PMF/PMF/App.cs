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

        public App()
        {
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
