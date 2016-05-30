/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:PMF"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace PMF.ViewModels
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ////if (ViewModelBase.IsInDesignModeStatic)
            ////{
            ////    // Create design time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DesignDataService>();
            ////}
            ////else
            ////{
            ////    // Create run time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DataService>();
            ////}

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<MenuViewModel>();
            SimpleIoc.Default.Register<ContactViewModel>();
            SimpleIoc.Default.Register<NewsViewModel>();
            SimpleIoc.Default.Register<ScheduleViewModel>();
            SimpleIoc.Default.Register<ScheduleDetailsViewModel>();
            SimpleIoc.Default.Register<SubjectViewModel>();
            SimpleIoc.Default.Register<FAQViewModel>();
            SimpleIoc.Default.Register<ProgramsViewModel>();
        }

        public MainViewModel Main => ServiceLocator.Current.GetInstance<MainViewModel>();
        
        public ContactViewModel Contact => ServiceLocator.Current.GetInstance<ContactViewModel>();
        
        public MenuViewModel Menu => ServiceLocator.Current.GetInstance<MenuViewModel>();

        public NewsViewModel News => ServiceLocator.Current.GetInstance<NewsViewModel>();

        public ScheduleViewModel Schedule => ServiceLocator.Current.GetInstance<ScheduleViewModel>();

        public ScheduleDetailsViewModel ScheduleDetails => ServiceLocator.Current.GetInstance<ScheduleDetailsViewModel>();
        
        public SubjectViewModel Subject => ServiceLocator.Current.GetInstance<SubjectViewModel>();

        public FAQViewModel FAQ => ServiceLocator.Current.GetInstance<FAQViewModel>();

        public ProgramsViewModel Programs => ServiceLocator.Current.GetInstance<ProgramsViewModel>();

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}