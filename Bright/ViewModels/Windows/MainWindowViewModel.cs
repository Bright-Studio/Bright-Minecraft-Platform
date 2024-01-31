using Bright.Views;
using Bright.Views.LaunchPages;
using Bright.Views.Page.Download;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bright.ViewModels.Windows
{
    public sealed partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        private object _page = new LaunchPage();


        [RelayCommand]
        private void ToDownloadPage()
        {
            Page = new DownloadFramePage();
        }
        [RelayCommand]
        private void ToLaunchPage()
        {
            Page = new LaunchPage();
        }
    }
}