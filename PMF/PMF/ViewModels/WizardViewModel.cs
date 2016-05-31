using GalaSoft.MvvmLight;
using PMF.Core.Models;
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
        public ObservableCollection<SubjectWizardViewModel> CurrentSubjects { get; set; }

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
    }
}
