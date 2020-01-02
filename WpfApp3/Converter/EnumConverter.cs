using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Windows.Data;

namespace WpfApp3.Converter
{
    public class EnumConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        { 
            if (value == null) return "";
            if (parameter != null)
                foreach (var one in Enum.GetValues(parameter as Type))
                {
                    if (value.Equals(one))
                        return GetEnumDescription((Enum) one);
                }

            return null;
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            if (value == null) return "";

            if (parameter != null)
                foreach (var one in Enum.GetValues(parameter as Type))
                {
                    if (value.ToString() == GetEnumDescription((Enum) one))
                        return (Enum) one;
                }

            return null;
        }


        private string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            if (fi.GetCustomAttributes(typeof(DescriptionAttribute), false) is DescriptionAttribute[] attributes && attributes.Any())
                return attributes.First().Description;
            
            return value.ToString();
        }
    }
}