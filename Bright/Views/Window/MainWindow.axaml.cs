using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Bright.ViewModels.Windows;
using CommunityToolkit.Mvvm;

namespace Bright.Views;

public partial class MainWindow : Window
{
    public MainWindow MW { get; set; }
    public MainWindow()
    {
        InitializeComponent();
        MW = this;
        DataContext = new MainWindowViewModel();
    }
    
    private void MainWindow_PointerEnter(object sender, PointerEventArgs e)
    {
        GridX.Margin = new Thickness(0, 20, 0, 0);
        foreach (var item in Buttons.Children)
        {
            item.Height = 30;
        }
    }

    private void MainWindow_PointerLeave(object sender, PointerEventArgs e)
    {
        GridX.Margin = new Thickness(0, 0, 0, 0);
        foreach (var item in Buttons.Children)
        {
            item.Height = 0;
        }
    }

    //private void GoDownloadPage(object sender, RoutedEventArgs e)
    //{

    //}
}
