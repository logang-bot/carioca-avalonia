using Avalonia.Controls;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using Avalonia.Svg.Skia;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;

namespace CariocaAvalonia.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    private const string buttonActiveClasses = "active";

    [ObservableProperty]
    //[NotifyPropertyChangedFor(nameof(SidebarWidth))]
    private bool _sideMenuExpanded = true;

    //public int SidebarWidth => SideMenuExpanded ? 250 : 80;

    //public SvgImage SideMenuImage => new SvgImage
    //{
    //    Source = SvgSource.Load($"avares:://CariocaAvalonia/Assets/Images/{(SideMenuExpanded ? "img_dummy_logo.png" : "avalonia-logo.ico")}")
    //};

    //public Bitmap
    //    SideMenuImage => new(AssetLoader.Open(new Uri($"avares://{nameof(CariocaAvalonia)}/Assets/Images/{(SideMenuExpanded ? "img_dummy_logo.png" : "avalonia-logo.ico")}")));

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(OrdersSummaryIsActive))]
    [NotifyPropertyChangedFor(nameof(LocalOrdersIsActive))]
    [NotifyPropertyChangedFor(nameof(CreateOrderIsActive))]
    private ViewModelBase _currentPage;

    public bool OrdersSummaryIsActive => CurrentPage == _ordersSummaryPage;
    public bool LocalOrdersIsActive => CurrentPage == _localOrdersPage;
    public bool CreateOrderIsActive => CurrentPage == _createOrderPage;

    private readonly OrdersSummaryViewModel _ordersSummaryPage = new OrdersSummaryViewModel();
    private readonly LocalOrdersViewModel _localOrdersPage = new LocalOrdersViewModel();
    private readonly CreateOrderViewModel _createOrderPage = new CreateOrderViewModel();

    public MainViewModel()
    {
        CurrentPage = _ordersSummaryPage;
    }

    [RelayCommand]
    private void SideMenuResize()
    {
        SideMenuExpanded = !SideMenuExpanded;
    }

    [RelayCommand]
    private void GoToOrdersSummary()
    {
        CurrentPage = _ordersSummaryPage;
    }

    [RelayCommand]
    private void GoToLocalOrders()
    {
        CurrentPage = _localOrdersPage;
    }

    [RelayCommand]
    private void GoToCreateOrder()
    {
        CurrentPage = _createOrderPage;
    }
}
