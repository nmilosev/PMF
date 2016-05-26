using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Maps;

namespace PMF.CustomControls
{
    public class PinMap : Map
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public double PinDistance { get; set; }
        public string PinTitle { get; set; }

        public bool NavigateImmediately
        {
            get
            {
                return false;
            }
            set
            {
                if (value)
                    NavigateNow();
            }
        }


        private void NavigateNow()
        {
            var location = new Position(Latitude, Longitude);
              
            Pins.Add(new Pin() {
                Position = location,
                Label = PinTitle
            });

            MoveToRegion(MapSpan.FromCenterAndRadius(location, Distance.FromMeters(PinDistance)));
        }
    
    }
}
