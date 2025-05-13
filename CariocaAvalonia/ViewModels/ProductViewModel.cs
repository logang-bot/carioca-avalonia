using CariocaAvalonia.Enums;
using CariocaAvalonia.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CariocaAvalonia.ViewModels;

public partial class ProductViewModel : ObservableObject
{
    public Product Product { get; set; }
    public ProductViewModel(Product product)
    {
        Product = product;
    }

    public Guid Id => Product.Id; // assuming ID doesn't change

    public string Name
    {
        get => Product.Name;
        set
        {
            if (Product.Name != value)
            {
                Product.Name = value;
                OnPropertyChanged();
            }
        }
    }

    public string Description
    {
        get => Product.Description;
        set
        {
            if (Product.Description != value)
            {
                Product.Description = value;
                OnPropertyChanged();
            }
        }
    }

    public double Cost
    {
        get => Product.Cost;
        set
        {
            if (Product.Cost != value)
            {
                Product.Cost = value;
                OnPropertyChanged();
            }
        }
    }

    public string FormattedCost => $"{Cost} Bs.";

    public List<Fittings> Fittings
    {
        get => Product.Fittings;
        set
        {
            if (Product.Fittings != value)
            {
                Product.Fittings = value;
                OnPropertyChanged();
            }
        }
    }
}
