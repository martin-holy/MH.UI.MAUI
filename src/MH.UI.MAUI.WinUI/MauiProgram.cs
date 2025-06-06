﻿using MH.UI.MAUI.Controls;
using MH.UI.MAUI.WinUI.Handlers;
using Microsoft.Maui.Hosting;

namespace MH.UI.MAUI.WinUI;

public static class MauiProgram{
  public static void ConfigureHandlers(IMauiHandlersCollection handlers)  {
    //handlers.AddHandler<VirtualizedItemsView, VirtualizedItemsViewHandler>();
    //handlers.AddHandler<FlatTreeItemHost, FlatTreeItemHostHandler>();
    handlers.AddHandler<TreeViewHost, TreeViewHostHandler>();
  }
}