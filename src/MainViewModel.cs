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

    private MenuItem fixedItem1 = new MenuItem("FIXED_ITEM_1");
    private MenuItem fixedItem2 = new MenuItem("FIXED_ITEM_2");
    private MenuItem treeRootItem = new MenuItem("TREE_ROOT");

    public MainViewModel()
    {
      RefreshAllItems();
    }

    [RelayCommand]
    private void RefreshFixedItems()
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
      MenuItems.Add(treeRootItem);
    }

    [RelayCommand]
    private void RefreshSubItems()
    {
      treeRootItem.SubMenuItems.Clear();
      List<MenuItem> newMenuItems = new List<MenuItem>();
      newMenuItems.Add(treeRootItem);
      int newMenuItemCount = 3 + (random.Next() % 3);
      while (newMenuItems.Count < newMenuItemCount)
      {
        MenuItem nextMenuItem = new MenuItem("random_item_" + newMenuItems.Count);
        newMenuItems[random.Next() % newMenuItems.Count].SubMenuItems.Add(nextMenuItem);
        newMenuItems.Add(nextMenuItem);
      }
    }

    [RelayCommand]
    private void RefreshAllItems()
    {
      RefreshFixedItems();
      RefreshSubItems();
    }
  }
}
