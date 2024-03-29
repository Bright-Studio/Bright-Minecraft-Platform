using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Bright_Minecraft_Platform.ViewModels;

namespace Bright_Minecraft_Platform;

public partial class ServerListView : UserControl
{
    public ServerListView()
    {
        InitializeComponent();
        DataContext = new ServerListViewModel();
    }
}