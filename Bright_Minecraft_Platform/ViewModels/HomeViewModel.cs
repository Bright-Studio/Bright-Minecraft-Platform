using Avalonia.Controls.Primitives;
using Bright_Minecraft_Platform.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bright_Minecraft_Platform.ViewModels
{
    internal partial class HomeViewModel : ObservableObject
    {
        ////选择账户按钮显示内容
        [ObservableProperty]
        private string _selectedaccount = "账户 ";

        //启动游戏按钮显示内容
        [ObservableProperty]
        private string _launchgame = "启动游戏 ";
    }
}
