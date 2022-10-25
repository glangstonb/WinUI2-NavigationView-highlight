using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace WinUI2_NavigationView_highlight
{
  public partial class MenuItem : ObservableObject
  {
    [ObservableProperty]
    public string name = "default string";

    public ObservableCollection<MenuItem> SubMenuItems { get; set; }

    public MenuItem(string pName)
    {
      Name = pName;
      SubMenuItems = new ObservableCollection<MenuItem>();
    }
  }
}
