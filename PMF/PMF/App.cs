
using PMF.Core.Models;
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

            var n = new NewsItem() { Title = "Title!", Text = "L" };

            using (var odb = NDatabase.OdbFactory.Open("/sdcard/test.ndb"))
            {
                odb.Store(n);
                odb.Store(n);
                odb.Store(n);

                foreach (var i in odb.AsQueryable<NewsItem>())
                    System.Diagnostics.Debug.WriteLine(i.Title);
            }
                
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
