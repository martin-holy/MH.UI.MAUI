﻿using Microsoft.Maui.Controls;
using System;
using System.Globalization;

namespace MH.UI.MAUI.Converters;

public class BaseConverter : IValueConverter {
  public virtual object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture) =>
    Convert(value, parameter);

  public virtual object? Convert(object? value, object? parameter) =>
    throw new NotImplementedException();

  public virtual object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture) =>
    ConvertBack(value, parameter);

  public virtual object? ConvertBack(object? value, object? parameter) =>
    throw new NotSupportedException();
}