using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using CariocaAvalonia.ViewModels;
using System;

namespace CariocaAvalonia.Views;

public partial class CreateOrderView : UserControl
{
    public CreateOrderView()
    {
        InitializeComponent();
    }

    private void StackPanel_PointerPressed(object? sender, Avalonia.Input.PointerPressedEventArgs e)
    {

        if (sender is Border border && border.DataContext is ProductViewModel product)
        {
            var viewModel = DataContext as CreateOrderViewModel;
            viewModel?.AddProduct(product);
        }
    }
}