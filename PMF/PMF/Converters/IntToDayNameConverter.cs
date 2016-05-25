using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PMF.Converters
{
    class IntToDayNameConverter : IValueConverter
    {
        Dictionary<int, string> Dictionary = new Dictionary<int, string>()
        {
            { (int)DayOfWeek.Monday, Dictionaries.AppDictionary.Monday },
            { (int)DayOfWeek.Tuesday, Dictionaries.AppDictionary.Tuesday },
            { (int)DayOfWeek.Wednesday, Dictionaries.AppDictionary.Wednesday },
            { (int)DayOfWeek.Thursday, Dictionaries.AppDictionary.Thursday },
            { (int)DayOfWeek.Friday, Dictionaries.AppDictionary.Friday },
            { (int)DayOfWeek.Saturday, Dictionaries.AppDictionary.Saturday },
            { (int)DayOfWeek.Sunday, Dictionaries.AppDictionary.Sunday},
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
