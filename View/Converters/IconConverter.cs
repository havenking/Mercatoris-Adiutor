using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MercatorisAdiutor.View.Converters
{
    public class IconConverter : IValueConverter
    {
        private const string path = " pack://application:,,,/MercatorisAdiutor;component/Resources/Images/";

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string)
            {
                return path + value;
            }

            throw new Exception("value is not a string.");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
