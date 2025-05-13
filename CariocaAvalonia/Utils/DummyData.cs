using CariocaAvalonia.Enums;
using CariocaAvalonia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CariocaAvalonia.Utils;

public static class DummyData
{
    public static List<Product> DummyProducts => new List<Product>
    {
        new Product(
            Guid.NewGuid(),
            "Pollo a la Parrilla",
            "Tierno pollo a la parrilla con guarniciones opcionales",
            12.99,
            new List<Fittings> { Fittings.Rice, Fittings.FrenchFries, Fittings.Ketchup }
        ),
        new Product(
            Guid.NewGuid(),
            "Hamburguesa Deluxe",
            "Jugosa hamburguesa de res con tus salsas favoritas",
            9.50,
            new List<Fittings> { Fittings.Mayonnaise, Fittings.Mustard, Fittings.BarbecueSauce }
        ),
        new Product(
            Guid.NewGuid(),
            "Choripán",
            "Sándwich de chorizo al estilo boliviano",
            7.00,
            new List<Fittings> { Fittings.Llajua, Fittings.Mustard }
        ),
        new Product(
            Guid.NewGuid(),
            "Bowl de Mote Frito",
            "Mote crujiente con sazonado especial de la casa",
            5.75,
            new List<Fittings> { Fittings.Mote, Fittings.Ketchup }
        ),
        new Product(
            Guid.NewGuid(),
            "Combo Familiar",
            "Incluye carne a la parrilla, arroz y papas fritas con salsas",
            14.25,
            new List<Fittings> { Fittings.Rice, Fittings.FrenchFries, Fittings.BarbecueSauce, Fittings.Llajua }
        ),
        new Product(
            Guid.NewGuid(),
            "Papas Fritas con Queso",
            "Papas crocantes bañadas en queso derretido",
            4.99,
            new List<Fittings> { Fittings.FrenchFries, Fittings.Mayonnaise }
        ),
        new Product(
            Guid.NewGuid(),
            "Bowl de Carne con Arroz",
            "Carne cocida a fuego lento servida sobre arroz sazonado",
            11.25,
            new List<Fittings> { Fittings.Rice, Fittings.BarbecueSauce }
        ),
        new Product(
            Guid.NewGuid(),
            "Hot Dog Especial",
            "Hot dog con todos los aderezos",
            6.75,
            new List<Fittings> { Fittings.Mustard, Fittings.Ketchup, Fittings.Mayonnaise }
        ),
        new Product(
            Guid.NewGuid(),
            "Arroz Picante",
            "Arroz blanco con chili picante al estilo local",
            8.40,
            new List<Fittings> { Fittings.Rice, Fittings.Llajua }
        ),
        new Product(
            Guid.NewGuid(),
            "Hamburguesa con Mote",
            "Hamburguesa de res con mote crocante",
            10.50,
            new List<Fittings> { Fittings.Mote, Fittings.Ketchup, Fittings.Mustard }
        ),
        new Product(
            Guid.NewGuid(),
            "Plato Andino con Chorizo",
            "Chorizo tradicional acompañado de mote y llajua",
            9.90,
            new List<Fittings> { Fittings.Mote, Fittings.Llajua }
        ),
        new Product(
            Guid.NewGuid(),
            "Papas Fritas Cargadas",
            "Papas fritas con mostaza, kétchup y salsa barbacoa",
            5.80,
            new List<Fittings> { Fittings.FrenchFries, Fittings.Ketchup, Fittings.Mustard, Fittings.BarbecueSauce }
        ),
        new Product(
            Guid.NewGuid(),
            "Bowl Vegetariano",
            "Arroz al vapor con vegetales y aderezos a elección",
            7.50,
            new List<Fittings> { Fittings.Rice, Fittings.Mayonnaise }
        ),
        new Product(
            Guid.NewGuid(),
            "Combo de Doble Chorizo",
            "Dos chorizos con papas fritas y salsas",
            12.25,
            new List<Fittings> { Fittings.FrenchFries, Fittings.BarbecueSauce, Fittings.Mustard }
        ),
        new Product(
            Guid.NewGuid(),
            "Caja Mini Snack",
            "Muestra de papas fritas, mote y kétchup",
            3.99,
            new List<Fittings> { Fittings.FrenchFries, Fittings.Mote, Fittings.Ketchup }
        )
    };
}
