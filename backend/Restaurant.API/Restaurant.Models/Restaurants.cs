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

    public ICollection<Grade> Grades { get; set; } = new List<Grade>();

    public ICollection<Menu> Menus { get; set; } = new List<Menu>();

    public ICollection<Score> Scores { get; set; } = new List<Score>();

    public ICollection<Cuisine> Cuisine { get; set; } = new List<Cuisine>();
}
