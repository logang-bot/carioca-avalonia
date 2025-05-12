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
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(SidebarWidth))]
    private bool _sideMenuExpanded = true;

    public int SidebarWidth => SideMenuExpanded ? 250 : 80;

    //public SvgImage SideMenuImage => new SvgImage
    //{
    //    Source = SvgSource.Load($"avares:://CariocaAvalonia/Assets/Images/{(SideMenuExpanded ? "img_dummy_logo.png" : "avalonia-logo.ico")}")
    //};

    //public Bitmap
    //    SideMenuImage => new(AssetLoader.Open(new Uri($"avares://{nameof(CariocaAvalonia)}/Assets/Images/{(SideMenuExpanded ? "img_dummy_logo.png" : "avalonia-logo.ico")}")));

    [RelayCommand]
    private void SideMenuResize()
    {
        SideMenuExpanded = !SideMenuExpanded;
    }
}
