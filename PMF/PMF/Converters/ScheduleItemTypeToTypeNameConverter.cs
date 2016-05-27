using PMF.Core.Models;
using PMF.Dictionaries;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PMF.Converters
{
    class ScheduleItemTypeToTypeNameConverter : IValueConverter
    {
        Dictionary<int, string> Dictionary = new Dictionary<int, string>()
        {
            { (int)ScheduleItemType.Lecture, "Lecture".Localize() },
            { (int)ScheduleItemType.Lab, "Lab".Localize() },
            { (int)ScheduleItemType.Pratice, "Practice".Localize() }            
        };


        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Dictionary[(int)value];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
