using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using ExtendedString;

namespace WPFBindingDemo
{
    public sealed class Converter
    {
        public static DateConverter DTConverter
        {
            get { return SingleTon<DateConverter>.GetInstance(); }
        }

    }

    //register the datetime type to string

    [ValueConversion(typeof(DateTime), typeof(String))]
    public sealed class DateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime date = (DateTime)value;
            return string.Format("Today is {0:yyyy/MM/dd}", date);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string strValue = value.ToString();
            DateTime resultDateTime;
            if (DateTime.TryParse(strValue, out resultDateTime))
            {
                return resultDateTime;
            }
            return value;
        }
    }
}
