using CommunityToolkit.Mvvm.ComponentModel;

namespace WinUI2_NavigationView_highlight
{
  public partial class MenuItem : ObservableObject
  {
    [ObservableProperty]
    public string name = "default string";

    public MenuItem(string pName)
    {
      Name = pName;
    }
  }
}
