using CariocaAvalonia.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CariocaAvalonia.Models
{
    class Product
    {
        protected Guid Id { get; }

        protected string Name { get; }

        protected string Description { get; }

        protected double Cost { get; }

        public List<Fittings> Fittings { get; set; }

        public Product(Guid id, string name, string description, double cost, List<Fittings> fittings)
        {
            Id = id;
            Name = name;
            Description = description;
            Cost = cost;
            Fittings = fittings;
        }
    }
}
