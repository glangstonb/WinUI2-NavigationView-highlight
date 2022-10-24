using Windows.UI.Xaml.Controls;

namespace WinUI2_NavigationView_highlight
{
  public sealed partial class MainPage : Page
  {
    public MainViewModel ViewModel;

    public MainPage()
    {
      InitializeComponent();
      DataContext = ViewModel = new MainViewModel();
    }
  }
}
