using Acr.UserDialogs;
using GalaSoft.MvvmLight;
using PMF.Core.Models;
using PMF.Dictionaries;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PMF.ViewModels
{
    public class WizardViewModel : ViewModelBase
    {
        private ObservableCollection<SubjectWizardViewModel> _currentSubjects;
        public ObservableCollection<SubjectWizardViewModel> CurrentSubjects
        {
            get
            {
                return _currentSubjects;
            }
            set
            {
                _currentSubjects = value;
                RaisePropertyChanged();
            }
        }

        public Program CurrentProgram { get; set; }
        public string CurrentModuleName { get; set; }
        public int Semester { get; set; }

        public class SubjectCheck : ViewModelBase
        {
            public Subject Subject { get; set; }

            private bool _isChecked;
            public bool IsChecked
            {
                get
                {
                    return _isChecked;
                }
                set
                {
                    _isChecked = value;
                    RaisePropertyChanged("Icon");
                }
            }

            public string Icon
            {
                get
                {
                    if (IsChecked)
                        return "checked.png";
                    else
                        return "unchecked.png";
                }
            }
        }

        public Command Check => new Command<SubjectCheck>((s) =>
        {
            if (s.IsChecked)
            {
                s.IsChecked = false;
                RaisePropertyChanged("CurrentESPB");
            }
            else
            {
                s.IsChecked = true;
                RaisePropertyChanged("CurrentESPB");
            }

        });

        public double CurrentESPB
        {
            get
            {
                var _currentESPB = 0.0;
                foreach (var group in CurrentSubjects)
                    foreach (var checkedSubject in group)
                        if (checkedSubject.IsChecked)
                            _currentESPB += checkedSubject.Subject.ESPB;

                return _currentESPB;
            }
        }

        public class SubjectWizardViewModel : ObservableCollection<SubjectCheck>
        {
            public string Title { get; set; }

            public SubjectWizardViewModel(IEnumerable<SubjectCheck> s) : base(s)
            {
            }

            public SubjectWizardViewModel(IEnumerable<Subject> s, bool autoCheck = false)
            {
                foreach (var subject in s)
                {
                    Add(new SubjectCheck() { Subject = subject, IsChecked = autoCheck });
                }
            }
        }

        public Command SaveList => new Command(() =>
        {

            if (Device.OS == TargetPlatform.iOS || Device.OS == TargetPlatform.WinPhone)
            {
                _saveList();
                return;
            }

            var cfg = new ActionSheetConfig()
                    .SetTitle("SendListTitle".Localize())
                    .Add("SendListMessage".Localize())
                    .SetDestructive("OK".Localize(), () =>
                    {
                        _saveList();
                    })
                    .SetCancel("Clipboard".Localize(), () =>
                    {
                        _saveList(toClipboard: true);
                    });

            UserDialogs.Instance.ActionSheet(cfg);
        });

        private void _saveList(bool toClipboard=false)
        {
            var messenger = Plugin.Share.CrossShare.Current;
            var sb = new StringBuilder();
            sb.AppendLine(CurrentProgram.Name);
            sb.AppendLine(CurrentModuleName);
            sb.AppendLine($"{"SemesterCap".Localize()}: {Semester}");
            sb.AppendLine(string.Empty);
            foreach (var group in CurrentSubjects)
                foreach (var checkedSubject in group)
                    if (checkedSubject.IsChecked)
                    {
                        var s = checkedSubject.Subject;
                        sb.AppendLine($"{s.Id} - {s.Title} - {"ESPB".Localize()}{s.ESPB}");
                    }
            sb.AppendLine(string.Empty);
            sb.AppendLine($"{"ESPB".Localize()}{CurrentESPB}");

            if (!toClipboard)
                messenger.Share(sb.ToString(), "AppName".Localize());
            else
            {
                if (messenger.SupportsClipboard)
                {
                    messenger.SetClipboardText(sb.ToString());
                    UserDialogs.Instance.ErrorToast("CopiedToClipboard".Localize());
                }
                else
                {
                    UserDialogs.Instance.ErrorToast("Error".Localize(), "NotSupported".Localize());
                }
            }

        }
    }
}
