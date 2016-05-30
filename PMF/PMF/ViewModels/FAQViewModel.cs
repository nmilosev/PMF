using Acr.UserDialogs;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using PMF.Core.Interfaces;
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
    public class FAQViewModel : ViewModelBase
    {
        private IFAQSource _faq;

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

        public FAQViewModel()
        {
            _faq = SimpleIoc.Default.GetInstance<IFAQSource>();
        }

        private ObservableCollection<QA> _faqItems;
        public ObservableCollection<QA> FAQ
        {
            get
            {
                if (_faqItems == null)
                    Refresh();
                return _faqItems;
            }
            set
            {
                _faqItems = value;
                RaisePropertyChanged();
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
            var faqs = await _faq.FAQ(Dictionaries.Translator.CurrentCultureCode);

            IsRefreshing = false;
            Activity = false;

            if (_faq.IsDataValid)
            {
                FAQ = new ObservableCollection<QA>(faqs.QuestionsAndAnswers);
            }
            else
            {
                UserDialogs.Instance.ErrorToast("Error".Localize(), "FAQError".Localize(), 1500);
            }
        }       
    }
}
