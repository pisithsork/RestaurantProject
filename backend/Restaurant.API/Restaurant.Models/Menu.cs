using System;
using System.Collections.Generic;

namespace Restaurant.Models;

public class Menu
{
    public int DishId { get; set; }

    public int CuisineRes { get; set; }

    public string Dish { get; set; } = null!;

    public decimal Price { get; set; }

    public virtual Restaurants CuisineResNavigation { get; set; } = null!;
}
