using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fsn_intro_csharp.Models;

internal class Training(int id,
                        string title,
                        decimal price,
                        string description,
                        DateTime startTime,
                        TimeSpan duration,
                        bool? isOutside = false)
{
    public int Id { get; set; } = id;
    public string Title { get; set; } = title;
    public decimal Price { get; set; } = price;
    public string Description { get; set; } = description;

    public DateTime StartTime { get; set; } = startTime;
    public TimeSpan Duration { get; set; } = duration;

    // nullable value type:
    public bool? IsOutside { get; set; } = isOutside;

    // get-only calculated property:
    public DateTime EndTime => StartTime + Duration;


}
