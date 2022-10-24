using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

#nullable enable

namespace WinUI2_NavigationView_highlight
{
  public partial class MainViewModel : ObservableObject
  {
    public ObservableCollection<MenuItem> MenuItems { get; set; }

    [ObservableProperty]
    private MenuItem? selectedItem;

    public MainViewModel()
    {
      MenuItems = new ObservableCollection<MenuItem>();
    }
  }
}
