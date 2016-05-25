using PMF.Core.Models;
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
            { (int)ScheduleItemType.Lecture, Dictionaries.AppDictionary.Lecture },
            { (int)ScheduleItemType.Lab, Dictionaries.AppDictionary.Lab },
            { (int)ScheduleItemType.Pratice, Dictionaries.AppDictionary.Practice}            
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
