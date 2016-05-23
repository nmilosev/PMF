using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using PMF.Navigation;
using Xamarin.Forms;

namespace PMF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {

        public Command ShowMainMenuCommand => new Command(() => { SimpleIoc.Default.GetInstance<Navigator>().ShowMenu(); });
     
    }
}