using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using System.Windows;
using System.Windows.Media.Animation;

namespace NavigationBar
{
    public partial class MainWindowViewModel : ObservableBase
    {
        public List<MenuModel> Menus { get; set; }
        [ObservableProperty]
        private MenuModel _currentMenu;

        public MainWindowViewModel()
        {
            Menus = new();
            Menus.Add(new MenuModel { Id = "1", DisplayName = "Home", IconType = IconType.Home });
            Menus.Add(new MenuModel { Id = "2", DisplayName = "Scan", IconType = IconType.Apple });
            Menus.Add(new MenuModel { Id = "3", DisplayName = "Apps", IconType = IconType.Facebook });
            Menus.Add(new MenuModel { Id = "4", DisplayName = "Cart", IconType = IconType.Instagram });
            Menus.Add(new MenuModel { Id = "5", DisplayName = "Link", IconType = IconType.Link });
        }

        partial void OnCurrentMenuChanged(MenuModel value)
        {
            // MainWindow 인스턴스 찾기
            var mainWindow = Application.Current.MainWindow;

            // Storyboard 찾기
            Storyboard storyboard = null;
            switch (value.Id)
            {
                case "1":
                    storyboard = mainWindow.FindResource("Menu01Move") as Storyboard;
                    break;
                case "2":
                    storyboard = mainWindow.FindResource("Menu02Move") as Storyboard;
                    break;
                case "3":
                    storyboard = mainWindow.FindResource("Menu03Move") as Storyboard;
                    break;
                case "4":
                    storyboard = mainWindow.FindResource("Menu04Move") as Storyboard;
                    break;
                case "5":
                    storyboard = mainWindow.FindResource("Menu05Move") as Storyboard;
                    break;
            }

            // Storyboard 실행
            storyboard?.Begin(mainWindow);
        }

        [RelayCommand]
        private void Menu(MenuModel menuModel)
        {
            CurrentMenu = menuModel;
        }
    }

    public class MenuModel
    { 
        public string Id { get; set; }
        public string DisplayName { get; internal set; }
        public IconType IconType { get; internal set; }
    }
}