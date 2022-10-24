using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace WinUI2_NavigationView_highlight
{
  public class MenuItemTemplateSelector : DataTemplateSelector
  {
    public DataTemplate DefaultItemTemplate { get; set; } = new DataTemplate();

    protected override DataTemplate SelectTemplateCore(object item)
    {
      return DefaultItemTemplate;
    }
  }
}