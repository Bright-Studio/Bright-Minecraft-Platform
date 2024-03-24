using Avalonia.Controls;
using Avalonia.Interactivity;
using Bright_Minecraft_Platform.ViewModels;
using ReactiveUI;

namespace Bright_Minecraft_Platform.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }

    //private void Button_Click(object sender, RoutedEventArgs e)
    //{
    //    MessageBox.Show(listX.SelectedItem.ToString());
    //    Window.Title = listX.SelectedItem.ToString();
    //}
}
