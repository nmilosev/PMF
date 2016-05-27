using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using PMF.Dictionaries;

namespace PMF.Converters
{
    class IntToDayNameConverter : IValueConverter
    {
        Dictionary<int, string> Dictionary = new Dictionary<int, string>()
        {
            { (int)DayOfWeek.Monday, "Monday".Localize() },
            { (int)DayOfWeek.Tuesday, "Tuesday".Localize() },
            { (int)DayOfWeek.Wednesday, "Wednesday".Localize() },
            { (int)DayOfWeek.Thursday, "Thursday".Localize() },
            { (int)DayOfWeek.Friday, "Friday".Localize() },
            { (int)DayOfWeek.Saturday, "Saturday".Localize() },
            { (int)DayOfWeek.Sunday, "Sunday".Localize() },
        };


        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Dictionary[(int) value];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
