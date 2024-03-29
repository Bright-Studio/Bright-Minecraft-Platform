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
    internal partial class PlaygroundViewModel : ObservableObject
    {
        public MainWindowViewModel MainWindowVM;

        [ObservableProperty]//#2A2929
        private String _text = "AAAAAAAADWAS";

        [RelayCommand]
        private void ToHackListView()
        {
            MainWindowVM.Page = new HackListView();
        }

        private void ToModView()
        {
            MainWindowVM.Page = new ModView();
        }
    }
}
