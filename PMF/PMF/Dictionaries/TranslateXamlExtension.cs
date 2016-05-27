using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PMF.Dictionaries
{
    [ContentProperty("Value")]
    public class Translate : IMarkupExtension
    {
        public string Value { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return Value.Localize();
        }        
    }
}
