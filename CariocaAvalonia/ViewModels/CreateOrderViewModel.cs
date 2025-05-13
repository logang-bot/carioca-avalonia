using CariocaAvalonia.Models;
using CariocaAvalonia.Utils;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CariocaAvalonia.ViewModels;

public partial class CreateOrderViewModel : ViewModelBase
{
    private ObservableCollection<ProductViewModel> _products;
    public ObservableCollection<ProductViewModel> Products
    {
        get { return _products; }
        set { SetProperty(ref _products, value); }
    }

    private ObservableCollection<ProductViewModel> _addedProducts;
    public ObservableCollection<ProductViewModel> AddedProducts
    {
        get { return _addedProducts; }
        set { SetProperty(ref _addedProducts, value); }
    }

    [ObservableProperty]
    private Order _currentOrder;

    public bool IsAddedProductsEmpty => AddedProducts.Count == 0;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(TotalAmountFormatted))]
    private double _totalAmount;

    public string TotalAmountFormatted => $"{TotalAmount} Bs.";

    public CreateOrderViewModel()
    {
        Products = [.. DummyData.DummyProducts.Select(p => p.ToViewModel())];
        AddedProducts = new ObservableCollection<ProductViewModel>();
        TotalAmount = 0;
    }

    public void AddProduct(ProductViewModel product)
    {
        AddedProducts.Add(product);
        TotalAmount += product.Cost;
        OnPropertyChanged(nameof(IsAddedProductsEmpty));
    }
}
