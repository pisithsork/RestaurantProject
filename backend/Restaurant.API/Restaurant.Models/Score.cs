using System;
using System.Collections.Generic;

namespace Restaurant.Models;

public class Score
{
    public int ScoreId { get; set; }

    public int? RestScoreid { get; set; }

    public int Score1 { get; set; }

    public DateTime ScoreDate { get; set; }

    public virtual Restaurants? RestScore { get; set; }
}
