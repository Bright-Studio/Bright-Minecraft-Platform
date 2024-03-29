using Avalonia.Controls;
using Bright_Minecraft_Platform.ViewModels;

namespace Bright_Minecraft_Platform.Views
{
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
            DataContext = new HomeViewModel();
        }
    }
}
