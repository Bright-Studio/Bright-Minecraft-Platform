using Avalonia.Controls;
using Bright_Minecraft_Platform.ViewModels;

namespace Bright_Minecraft_Platform.Views
{
    public partial class PlaygroundView : UserControl
    {
        public PlaygroundView()
        {
            InitializeComponent();
            DataContext = new PlaygroundViewModel();
        }
    }
}
