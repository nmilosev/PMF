using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PMF.Views
{
    public partial class ContactPage : ContentPage
    {
        public ContactPage()
        {
            InitializeComponent();
            
            SetupMap();
        }
        /// <summary>
        /// No easy XAML bindings for Maps... Xamarin...
        /// </summary>
        public void SetupMap()
        {
            var pmfGeoLoc = new Xamarin.Forms.Maps.Position(45.245411, 19.852777);
            Map.Pins.Add(new Xamarin.Forms.Maps.Pin() { Position = pmfGeoLoc, Label = Dictionaries.AppDictionary.PMFName });
            Map.MoveToRegion(Xamarin.Forms.Maps.MapSpan.FromCenterAndRadius(pmfGeoLoc, Xamarin.Forms.Maps.Distance.FromMeters(1500)));
        }
    }
}
