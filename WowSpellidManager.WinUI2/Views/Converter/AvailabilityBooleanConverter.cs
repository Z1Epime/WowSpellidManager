using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;
using WowSpellidManager.WinUI2.ViewModels.Helper;

namespace WowSpellidManager.WinUI2.Views.Converter
{
    public class AvailabilityBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var ParameterString = parameter as string;
            if (ParameterString == null)
                return DependencyProperty.UnsetValue;

            int index = ParameterString.IndexOf("Availability.");
            ParameterString = (index < 0)
                ? ParameterString
                : ParameterString.Remove(index, "Availability.".Length);

            if (Enum.IsDefined(value.GetType(), value) == false)
                return DependencyProperty.UnsetValue;

            object paramvalue = Enum.Parse(value.GetType(), ParameterString);
            return paramvalue.Equals(value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            var ParameterString = parameter as string;
            var valueAsBool = (bool)value;

            if (ParameterString == null || !valueAsBool)
            {
                try
                {
                    return Enum.Parse(targetType, "0");
                }
                catch (Exception)
                {
                    return DependencyProperty.UnsetValue;
                }
            }

            targetType = TypeHelper.GetAvailabilityType();
            int index = ParameterString.IndexOf("Availability.");
            ParameterString = (index < 0)
                ? ParameterString
                : ParameterString.Remove(index, "Availability.".Length);

            return Enum.Parse(targetType, ParameterString);
        }
    }
}
