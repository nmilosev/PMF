using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using PMF.Core.Interfaces;
using PMF.Core.Models;
using PMF.LocalService;
using Xamarin.Forms;

namespace PMF
{
    public partial class App : Application
    {
        /// <summary>
        /// Initialize the app
        /// </summary>
        public App()
        {
            InitializeComponent();

            SetupIoc();
        
            // not bindable from xaml: main entry point                
            MainPage = SimpleIoc.Default.GetInstance<Views.MainPage>();
        }

        private void SetupIoc()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<Navigation.Navigator>(true);

            SimpleIoc.Default.Register<INewsSource, LocalNewsSource>();
            SimpleIoc.Default.Register<IScheduleSource, LocalScheduleSource>();
            SimpleIoc.Default.Register<ISubjectsSource, LocalSubjectsSource>();

            SimpleIoc.Default.Register<IFAQSource, LocalFAQSource>();
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
