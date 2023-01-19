using System;
using System.Collections.Generic;

namespace Restaurant.Models;

public partial class Menu
{
    public int dish_id { get; set; }

    public int cuisine_rest { get; set; }

    public string dish { get; set; } = null!;

    public decimal price { get; set; }

    public virtual Restaurants CuisineRestNavigation { get; set; } = null!;
}
