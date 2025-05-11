using CariocaAvalonia.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CariocaAvalonia.Models
{
    class Order
    {
        public Guid Id { get; }

        public string ClientName { get; }

        public double TotalPrice { get; }

        public List<Product> Products { get; }

        public OrderState State { get; }

        public Order(Guid id, string clientName, double totalPrice, List<Product> products, OrderState state)
        {
            Id = id;
            ClientName = clientName;
            TotalPrice = totalPrice;
            Products = products;
            State = state;
        }
    }
}
