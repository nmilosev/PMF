
using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PMF.Dictionaries
{
    [ContentProperty("Value")]
    public class TranslateExtension : IMarkupExtension
    {
        private const string ERROR = "{ Translate }";

        private const string DictionaryName = "PMF.Dictionaries.AppDictionary";
        private const string AssemblyName = "PMF";

        private const string CultureInfoNameRS = "sr-Latn-RS";
        private const string CultureInfoNameEN = "en";

        private const string CurrentCulture = CultureInfoNameEN;


        private static ResourceManager _rm;
        private static ResourceManager ResourceManager
        {
            get
            {
                if (_rm == null)
                    _rm = new ResourceManager(DictionaryName, Assembly.Load(new AssemblyName(AssemblyName)));
                return _rm;
            }
        }

        private static CultureInfo _ci;
        private static CultureInfo CultureInfo
        {
            get
            {
                if (_ci == null)
                    _ci = new CultureInfo(CurrentCulture);
                return _ci;
            }
        }

        public string Value { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (string.IsNullOrEmpty(Value))
                return string.Empty;

            var translation = ResourceManager.GetString(Value, CultureInfo);
            
            if (translation != null)
                return translation;
            else
                return ERROR;
        }
    }
}
