using Avalonia.Controls;
using CariocaAvalonia.ViewModels;
using System.Linq;

namespace CariocaAvalonia.Views;

public partial class MainView : Window
{
    public MainView()
    {
        InitializeComponent();
        //Orders.ItemsSource = new string[]
        //{
        //    "order 1", "order 2", "order 3"
        //}.OrderBy(x => x);
    }

    private void Image_PointerPressed(object? sender, Avalonia.Input.PointerPressedEventArgs e)
    {
        if (e.ClickCount != 2)
            return;

        (DataContext as MainViewModel)?.SideMenuResizeCommand.Execute(null);
    }

}