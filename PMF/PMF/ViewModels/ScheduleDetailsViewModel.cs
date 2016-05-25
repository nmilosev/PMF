using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using PMF.Core.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PMF.ViewModels
{
    public class ScheduleDetailsViewModel : ViewModelBase
    {
        public Schedule Current { get; set; }

        public Command GoBack => new Command(() => SimpleIoc.Default.GetInstance<Navigation.Navigator>().GoBackModal());

        private ScheduleItem _selectedItem;
        public ScheduleItem SelectedItem
        {
            get
            {
                // Xamarin bug, can't assign null if on iOS
                if (Device.OS == TargetPlatform.iOS)
                    return _selectedItem;
                else
                    return null;
            }
            set
            {
                _selectedItem = value;                
                RaisePropertyChanged();
            }
        }
        
    }
}
