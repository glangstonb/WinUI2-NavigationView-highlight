using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace WinUI2_NavigationView_highlight
{
  public sealed partial class MainPage : Page
  {
    public MainViewModel ViewModel;

    public MainPage()
    {
      InitializeComponent();
      NavigationCacheMode = NavigationCacheMode.Required;
      DataContext = ViewModel = new MainViewModel();
    }
  }
}
