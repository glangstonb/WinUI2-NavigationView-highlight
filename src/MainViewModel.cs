using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

#nullable enable

namespace WinUI2_NavigationView_highlight
{
  public partial class MainViewModel : ObservableObject
  {
    Random random = new Random();

    public ObservableCollection<MenuItem>? MenuItems { get; set; }

    [ObservableProperty]
    private MenuItem? selectedItem;

    private MenuItem fixedItem1 = new MenuItem("FIXEDITEM1");
    private MenuItem fixedItem2 = new MenuItem("FIXEDITEM2");

    public MainViewModel()
    {
      RefreshItems();
    }

    public void RefreshItems()
    {
      if (MenuItems == null)
      {
        MenuItems = new ObservableCollection<MenuItem>();
      }
      else
      {
        MenuItems.Clear();
      }
      MenuItems.Add(fixedItem1);
      MenuItems.Add(fixedItem2);
      List<MenuItem> newMenuItems = new List<MenuItem>();
      int newMenuItemCount = 4 + (random.Next() % 4);
      while (newMenuItems.Count < newMenuItemCount)
      {
        MenuItem nextMenuItem = new MenuItem("randomItem" + newMenuItems.Count);
        if (newMenuItems.Count == 0 || random.Next() % 3 <= 0)
        {
          MenuItems.Add(nextMenuItem);
        }
        else
        {
          newMenuItems[random.Next() % newMenuItems.Count].SubMenuItems.Add(nextMenuItem);
        }
        newMenuItems.Add(nextMenuItem);
      }
    }

    [RelayCommand]
    private void RefreshMenu()
    {
      RefreshItems();
    }
  }
}
