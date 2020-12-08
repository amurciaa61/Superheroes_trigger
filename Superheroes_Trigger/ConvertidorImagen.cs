﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Superheroes_Trigger
{
    class ConvertidorImagen : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool)
            {
                if ((bool)value)
                    return Visibility.Visible;
                else
                    return Visibility.Collapsed;
            }
            else return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
