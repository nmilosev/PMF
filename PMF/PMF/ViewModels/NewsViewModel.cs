using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using PMF.Core.Interfaces;
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
    public class NewsViewModel : ViewModelBase
    {
        private INewsSource _news;

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


        public NewsViewModel()
        {
            _news = SimpleIoc.Default.GetInstance<INewsSource>();
        }

        private ObservableCollection<NewsItem> _newsItems;
        public ObservableCollection<NewsItem> News
        {
            get
            {
                if (_newsItems == null)
                    Refresh();
                return _newsItems;
            }
            set
            {
                _newsItems = value;
                RaisePropertyChanged();
            }
        }

        public Command OpenNewsArticle
        {
            get
            {
                return new Command<NewsItem>((p) =>
                {
                    (Application.Current.Resources["ViewLocator"] as Views.ViewLocator).MainPage.DisplayAlert("News", p.Id.ToString(), "OK");
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
            var news = await _news.News();
            News = new ObservableCollection<NewsItem>(news.Items);
            IsRefreshing = false;
            Activity = false;
        }

        public NewsItem SelectedItem
        {
            get
            {
                return null;
            }
            set
            {
                OpenNewsArticle.Execute(value);
                RaisePropertyChanged();
            }
        }
    }
}
