using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PMF.Views
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        public Command Command
        {
            get
            {
                return new Command((p) =>
                {
                    App.MasterDetailPage.Detail = new NavigationPage(new LinkPage());
                    App.MasterDetailPage.IsPresented = false;
                });
            }
        }
    }
}
