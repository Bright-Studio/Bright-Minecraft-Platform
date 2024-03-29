using Avalonia.Controls;
using Bright_Minecraft_Platform.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bright_Minecraft_Platform.ViewModels
{
    internal partial class MainWindowViewModel : ObservableObject
    {

        [ObservableProperty]
        public object _page = new HomeView();

        [ObservableProperty]
        private object _current;
        

        //[RelayCommand]
        //private void ToDownloadPage()
        //{
        //    Page = new DownloadFramePage();
        //}
        //[RelayCommand]
        //private void ToHome()
        //{
        //     Page = new DownloadView();
        //}

        partial void OnCurrentChanged(object value)
        {
            Page = (value as ListBoxItem).Tag switch
            {
                "Home" => new HomeView(),
                "Download" => new DownloadView(),
                "Setting" => new SettingView(),//Playground
                "Playground" => new ServerListView(),//Playground
                _ => new HomeView(),
            };
        }
    }
}
