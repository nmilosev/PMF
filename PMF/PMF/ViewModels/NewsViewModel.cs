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
                    CurrentNewsItem = p;
                    SimpleIoc.Default.GetInstance<Navigation.Navigator>().NavigateModal(typeof(Views.NewsArticlePage));                    
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
            var notificator = DependencyService.Get<Plugin.Toasts.IToastNotificator>();

            IsRefreshing = false;
            Activity = false;
            
            if (news.IsDataValid)
            {
                News = new ObservableCollection<NewsItem>(news.Items);                
            }
            else
            {
                await notificator.Notify(Plugin.Toasts.ToastNotificationType.Error,
                Dictionaries.AppDictionary.Error, Dictionaries.AppDictionary.NewsError, TimeSpan.FromSeconds(1.5));
            }

           
        }

        private NewsItem _selectedItem;
        public NewsItem SelectedItem
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
                OpenNewsArticle.Execute(value);
                RaisePropertyChanged();
            }
        }

        public NewsItem CurrentNewsItem { get; set; }

        public Command NewsArticleBack
        {
            get
            {
                return new Command(() => SimpleIoc.Default.GetInstance<Navigation.Navigator>().GoBackModal());
            }
        }
        public Command NewsArticleShare
        {
            get
            {
                return new Command(() => Plugin.Share.CrossShare.Current.ShareLink(CurrentNewsItem.Link, title: CurrentNewsItem.Title, message: CurrentNewsItem.Title));
            }
        }
        public Command NewsArticleLink
        {
            get
            {
                return new Command(() => Plugin.Share.CrossShare.Current.OpenBrowser(CurrentNewsItem.Link));
            }
        }
    }
}
