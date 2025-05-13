using CariocaAvalonia.Enums;
using CariocaAvalonia.ViewModels;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CariocaAvalonia.Models;

public class Product
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public double Cost { get; set; }

    public List<Fittings> Fittings { get; set; }

    public Product(Guid id, string name, string description, double cost, List<Fittings> fittings)
    {
        Id = id;
        Name = name;
        Description = description;
        Cost = cost;
        Fittings = fittings;
    }

    public ProductViewModel ToViewModel()
    {
        return new ProductViewModel(this);
    }
}
