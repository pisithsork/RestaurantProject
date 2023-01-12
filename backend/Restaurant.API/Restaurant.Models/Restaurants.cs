using System;
using System.Collections.Generic;

namespace Restaurant.Models;

public class Restaurants
{
    public int Id { get; set; }

    public int RestId { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string CuisineType { get; set; } = null!;

    public virtual ICollection<Grade> Grades { get; } = new List<Grade>();

    public virtual ICollection<Menu> Menus { get; } = new List<Menu>();

    public virtual ICollection<Score> Scores { get; } = new List<Score>();
}
