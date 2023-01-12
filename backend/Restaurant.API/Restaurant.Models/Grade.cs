using System;
using System.Collections.Generic;

namespace Restaurant.Models;

public class Grade
{
    public int GradeId { get; set; }

    public int RestGradeid { get; set; }

    public string Grade1 { get; set; } = null!;

    public DateTime GradeDate { get; set; }

    public virtual Restaurants RestGrade { get; set; } = null!;
}
