using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using PMF.Core.Interfaces;
using PMF.Core.Models;
using PMF.Navigation;
using PMF.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PMF.ViewModels
{
    public class ScheduleViewModel : ViewModelBase
    {
        private IScheduleSource _schedules;

        private bool _isRefreshing;

        public bool IsRefreshing
        {
            get
            {
                return _isRefreshing;
            }
            set
            {
                _isRefreshing = value;
                RaisePropertyChanged();
            }
        }

        private bool _activity = true;
        public bool Activity
        {
            get
            {
                return _activity;
            }
            set
            {
                _activity = value;
                RaisePropertyChanged();
            }
        }


        public ScheduleViewModel()
        {
            _schedules = SimpleIoc.Default.GetInstance<IScheduleSource>();
        }

        private ObservableCollection<Schedule> _scheduleItems;
        public ObservableCollection<Schedule> Schedules
        {
            get
            {
                if (_scheduleItems == null)
                    Refresh();
                return _scheduleItems;
            }
            set
            {
                _scheduleItems = value;
                RaisePropertyChanged();
            }
        }

        public Command OpenSchedule
        {
            get
            {
                return new Command<Schedule>((p) =>
                {
                    (Application.Current.Resources["ViewModelLocator"] as ViewModelLocator).ScheduleDetails.Current = p;
                    SimpleIoc.Default.GetInstance<Navigator>().NavigateModal(typeof(ScheduleDetailsPage));
                });
            }
        }

        public Command RefreshCommand
        {
            get
            {
                return new Command(Refresh);
            }
        }

        public async void Refresh()
        {
            var schedules = await _schedules.Schedules();
            var notificator = DependencyService.Get<Plugin.Toasts.IToastNotificator>();

            IsRefreshing = false;
            Activity = false;

            if (schedules.IsDataValid)
            {
                Schedules = new ObservableCollection<Schedule>(schedules.Schedules);               
            }
            else
            {
                await notificator.Notify(Plugin.Toasts.ToastNotificationType.Error,
                Dictionaries.AppDictionary.Error, Dictionaries.AppDictionary.ScheduleError, TimeSpan.FromSeconds(1.5));
            }


        }         
    }
}
