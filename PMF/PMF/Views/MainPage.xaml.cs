using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PMF.Views
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //Can't bind from XAML
        protected override bool OnBackButtonPressed()
        {
            IsPresented = IsPresented ? false : true; 
            return true;
        }

        // https://forums.xamarin.com/discussion/22720/masterdetailpage-with-viewfactory-custom-binding
        #region Fix for Xamarin's Master and Detail properties not being bindable

        public static readonly BindableProperty DetailPageProperty =
        BindableProperty.Create(propertyName: "DetailPage", declaringType: typeof(Page), returnType: typeof(Page), propertyChanged: (bindable, oldValue, newValue) =>
        {
            ((MainPage)bindable).Detail = new NavigationPage(((Page)newValue)); 
        });

        public Page DetailPage
        {
            get { return (Page)GetValue(DetailPageProperty); }
            set { SetValue(DetailPageProperty, value); }
        }

        public static readonly BindableProperty MasterPageProperty =
        BindableProperty.Create(propertyName: "MasterPage", declaringType: typeof(Page), returnType: typeof(Page), propertyChanged: (bindable, oldValue, newValue) =>
        {
            ((MainPage)bindable).Master = ((Page)newValue);
        });

        public Page MasterPage
        {
            get { return (Page)GetValue(MasterPageProperty); }
            set { SetValue(MasterPageProperty, value); }
        }

        #endregion
    }
}
