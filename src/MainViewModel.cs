using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

#nullable enable

namespace WinUI2_NavigationView_highlight
{
  public partial class MainViewModel : ObservableObject
  {
    public ObservableCollection<MenuItem>? MenuItems { get; set; }

    [ObservableProperty]
    private MenuItem? selectedItem;

    public MainViewModel()
    {
      ObservableCollection<MenuItem> newMenuItems = new ObservableCollection<MenuItem>();
      newMenuItems.Add(new MenuItem("asdf"));
      newMenuItems.Add(new MenuItem("qwer"));
      newMenuItems.Add(new MenuItem("zxcv"));
      newMenuItems.Add(new MenuItem("blah"));
      MenuItems = newMenuItems;
    }
  }
}
