using System.Collections;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Windows.Data;

namespace MercatorisAdiutor.View.Converters
{
    public class IconConverter : IValueConverter
    {
        private const string path = " pack://application:,,,/MercatorisAdiutor;component/Resources/Images/";
        private const string generic = "generic.png";
        private string[] resources;

        public IconConverter()
        {
            var assembly = Assembly.GetExecutingAssembly();
            string resName = assembly.GetName().Name + ".g.resources";

            using (Stream? stream = assembly.GetManifestResourceStream(resName))
            {
                if (stream == null) 
                {
                    resources = Array.Empty<string>();
                }
                else
                {
                    using (ResourceReader reader = new ResourceReader(stream))
                    {
                        resources = reader.Cast<DictionaryEntry>().Select(entry => (string)entry.Key).ToArray();
                    }
                }
            }
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string)
            {
                return resources.Any(x => x.Contains((string)value, StringComparison.InvariantCultureIgnoreCase)) ? path + value : path + generic;
            }

            throw new Exception("value is not a string.");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
