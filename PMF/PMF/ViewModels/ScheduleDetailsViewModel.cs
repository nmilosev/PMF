using Acr.UserDialogs;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using PMF.Core.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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
                OpenScheduleItemDetails(value);
            }
        }
        
        private void OpenScheduleItemDetails(ScheduleItem item)
        {

            var converter = Application.Current.Resources["scheduleItemTypeConverter"] as Converters.ScheduleItemTypeToTypeNameConverter;
            
            var message = Environment.NewLine + 
                          item.SubjectTitle + Environment.NewLine +
                          converter.Convert(item.Type, typeof(string), null, CultureInfo.CurrentCulture) + Environment.NewLine +
                          item.TeacherNamesFormatted + Environment.NewLine +
                          item.TimeFormatted + Environment.NewLine +
                          item.Location + Environment.NewLine;

            var cfg = new ActionSheetConfig()
                    .SetTitle(Dictionaries.AppDictionary.SessionDetails)
                    .Add(message)
                    .SetDestructive(Dictionaries.AppDictionary.OK)
                    .SetCancel(Dictionaries.AppDictionary.SubjectDetails, () => 
                    {
                        // TODO Za predmet detalji
                    });
                    
            UserDialogs.Instance.ActionSheet(cfg);
            
        }

    }
}
