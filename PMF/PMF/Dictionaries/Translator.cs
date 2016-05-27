using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace PMF.Dictionaries
{
    public static class Translator
    {

        private const string ERROR = "{ Translate }";

        private const string DictionaryName = "PMF.Dictionaries.AppDictionary";
        private const string AssemblyName = "PMF";

        private const string CultureInfoNameRS = "sr-Latn-RS";
        private const string CultureInfoNameEN = "en";

        /// <summary>
        /// Set current culture here!
        /// </summary>
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
        
        public static string _translate(string key)
        {
            if (string.IsNullOrEmpty(key))
                return string.Empty;

            var translation = ResourceManager.GetString(key, CultureInfo);

            if (translation != null)
                return translation;
            else
                return ERROR;
        }

        public static string Localize(this string key)
        {
            return _translate(key);
        }
    }
}
