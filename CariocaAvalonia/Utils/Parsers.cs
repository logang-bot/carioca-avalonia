using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CariocaAvalonia.Utils;

public interface IProductParser
{
    public double roundAmount(double amount, int floatingPoints);
}

public class ProductParser : IProductParser {
    public double roundAmount(double amount, int floatingPoints) { 
        return Double.Round(amount, floatingPoints);
    }
}

