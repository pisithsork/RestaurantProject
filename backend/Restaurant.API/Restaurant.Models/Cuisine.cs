using System;
using System.Collections.Generic;

namespace Restaurant.Models;

public partial class Cuisine
{
    public int cuisine_id { get; set; }

    public string cuisine_type { get; set; } = null!;

    public virtual ICollection<Restaurants> Rests { get; } = new List<Restaurants>();
}
