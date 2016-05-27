using Acr.UserDialogs;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using PMF.Core.Interfaces;
using PMF.Core.Models;
using PMF.Dictionaries;
using PMF.Navigation;
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

        public Command GoBack => new Command(() => SimpleIoc.Default.GetInstance<Navigator>().GoBackModal());

        public Command OpenDetails => new Command<ScheduleItem>((item) => OpenScheduleItemDetails(item));

        private void OpenScheduleItemDetails(ScheduleItem item)
        {

            var cfg = new ActionSheetConfig()
                    .SetTitle("SessionDetails".Localize())
                    .SetDestructive("OK".Localize())
                    .SetCancel("SubjectDetails".Localize(), () => ShowSubjectDetails(item.SubjectId));

            BuildMessage(cfg, item);

            UserDialogs.Instance.ActionSheet(cfg);

        }

        private void BuildMessage(ActionSheetConfig cfg, ScheduleItem item)
        {
            var converter = Application.Current.Resources["scheduleItemTypeConverter"] as Converters.ScheduleItemTypeToTypeNameConverter;

            if (Device.OS == TargetPlatform.iOS)
            {
                //iOS does not support multi line message
                cfg.Add(item.SubjectTitle)
                    .Add(converter.Convert(item.Type, typeof(string), null, CultureInfo.CurrentCulture).ToString())
                    .Add(item.TeacherNamesFormatted)
                    .Add(item.TimeFormatted)
                    .Add(item.Location);
            }
            else
            {
                var message = item.SubjectTitle + Environment.NewLine +
                          converter.Convert(item.Type, typeof(string), null, CultureInfo.CurrentCulture).ToString() + Environment.NewLine +
                          item.TeacherNamesFormatted + Environment.NewLine +
                          item.TimeFormatted + Environment.NewLine +
                          item.Location;
                cfg.Add(message);
            }

        }

        private async void ShowSubjectDetails(int subjectId)
        {
            var notificator = DependencyService.Get<Plugin.Toasts.IToastNotificator>();

            var subjectsData = SimpleIoc.Default.GetInstance<ISubjectsSource>();

            Subject s;

            using (UserDialogs.Instance.Loading("PleaseWait".Localize()))
            {
                s = await subjectsData.ForId(subjectId);
            }

            if (subjectsData.IsModelValid)
            {
                SimpleIoc.Default.GetInstance<SubjectViewModel>().Current = s;
                SimpleIoc.Default.GetInstance<Navigator>().NavigateModal(typeof(Views.SubjectPage));
            }
            else
            {
                await notificator.Notify(Plugin.Toasts.ToastNotificationType.Error,
                "Error".Localize(), "SubjectLoadError".Localize(), TimeSpan.FromSeconds(1.5));
            }

        }

    }
}
