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
       

        public NewsViewModel()
        {
            _news = SimpleIoc.Default.GetInstance<INewsSource>();
        }

        public ObservableCollection<NewsItem> News
        {
            get
            {
                return new ObservableCollection<NewsItem>(_news.News.Items);                
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
