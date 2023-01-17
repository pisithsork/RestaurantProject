using System;
using System.Collections.Generic;

namespace Restaurant.Models;

public class Grade
{
    public int grade_id { get; set; }

    public int rest_gradeid { get; set; }

    public string grade { get; set; } = null!;

    public DateTime grade_date { get; set; }

    public virtual Restaurants Restaurant_Grade { get; set; } = null!;
}
