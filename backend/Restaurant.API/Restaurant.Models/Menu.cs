using System;
using System.Collections.Generic;

namespace Restaurant.Models;

public class Menu
{
    public int dish_id { get; set; }

    public int cuisine_res { get; set; }

    public string dish { get; set; } = null!;

    public decimal price { get; set; }

    public virtual Restaurants Restaurant_Menu { get; set; } = null!;
}
