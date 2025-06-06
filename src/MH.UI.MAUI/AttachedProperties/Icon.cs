﻿using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Shapes;

namespace MH.UI.MAUI.AttachedProperties;

public static class Icon {
  public static readonly BindableProperty DataProperty =
    BindableProperty.CreateAttached("Data", typeof(PathGeometry), typeof(Icon), null);
  public static readonly BindableProperty FillProperty =
    BindableProperty.CreateAttached("Fill", typeof(Brush), typeof(Icon), null);
  public static readonly BindableProperty ResProperty =
    BindableProperty.CreateAttached("Res", typeof(string), typeof(Icon), null);
  public static readonly BindableProperty SizeProperty =
    BindableProperty.CreateAttached("Size", typeof(double), typeof(Icon), 0.0);

  public static PathGeometry GetData(BindableObject view) => (PathGeometry)view.GetValue(DataProperty);
  public static void SetData(BindableObject view, PathGeometry value) => view.SetValue(DataProperty, value);
  public static Brush GetFill(BindableObject view) => (Brush)view.GetValue(FillProperty);
  public static void SetFill(BindableObject view, Brush value) => view.SetValue(FillProperty, value);
  public static string GetRes(BindableObject view) => (string)view.GetValue(ResProperty);
  public static void SetRes(BindableObject view, string value) => view.SetValue(ResProperty, value);
  public static double GetSize(BindableObject view) => (double)view.GetValue(SizeProperty);
  public static void SetSize(BindableObject view, double value) => view.SetValue(SizeProperty, value);
}