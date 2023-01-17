using System;
using System.Collections.Generic;

namespace Restaurant.Models;

public class Score
{
    public int score_id { get; set; }

    public int? rest_scoreid { get; set; }

    public int score { get; set; }

    public DateTime score_date { get; set; }

    public virtual Restaurants? Restaurant_Score { get; set; }
}
