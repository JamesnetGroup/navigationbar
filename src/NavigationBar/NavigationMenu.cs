using System.Windows;
using System.Windows.Controls;

namespace NavigationBar
{
    public class NavigationMenu : ContentControl
    {
        static NavigationMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(NavigationMenu), new FrameworkPropertyMetadata(typeof(NavigationMenu)));
        }
    }
}
