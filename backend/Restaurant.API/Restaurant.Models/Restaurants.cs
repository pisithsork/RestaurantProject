using System;
using System.Collections.Generic;

namespace Restaurant.Models;

public partial class Restaurants
{
    public int id { get; set; }

    public string name { get; set; } = null!;

    public string address { get; set; } = null!;

    public string city { get; set; } = null!;

    public string state { get; set; } = null!;

    public virtual ICollection<Grade> Grades { get; } = new List<Grade>();

    public virtual ICollection<Menu> Menus { get; } = new List<Menu>();

    public virtual ICollection<Score> Scores { get; } = new List<Score>();

    public virtual ICollection<Cuisine> CuisineTypes { get; } = new List<Cuisine>();
}
