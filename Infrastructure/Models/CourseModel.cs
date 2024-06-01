using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models;

public class CourseModel
{
    public string? Id { get; set; }

    public string? Title { get; set; }

    public string? ImageUri { get; set; }

    public string? Author { get; set; }

    public bool IsBestseller { get; set; }

    public int Hours { get; set; }

    public decimal Price { get; set; }

    public decimal Discount { get; set; }

    public string? LikesInProcent { get; set; }

    public string? LikesInNumbers { get; set; }

    public string? Categories { get; set; }

    public string? Currency { get; set; }
}
