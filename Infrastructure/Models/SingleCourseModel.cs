

namespace Infrastructure.Models;

public class SingleCourseModel
{
    public string? Id { get; set; }
    public string? ImageUri { get; set; }
    public string? ImageHeaderUri { get; set; }
    public bool IsBestseller { get; set; }
    public bool IsDigital { get; set; }
    public List<string>? Categories { get; set; } = new List<string>();
    public string? Title { get; set; }
    public string? Ingress { get; set; }
    public decimal StarRating { get; set; }
    public string? Reviews { get; set; }
    public string? LikesInProcent { get; set; }
    public string? Likes { get; set; }
    public int Hours { get; set; }
    public List<AuthorModel> Authors { get; set; } = new List<AuthorModel>();
    public PriceModel Prices { get; set; } = new PriceModel();
    public ContentModel Content { get; set; } = new ContentModel();
}

public class AuthorModel
{
    public string? Name { get; set; }
}

public class PriceModel
{
    public decimal Price { get; set; }
    public string? Currency { get; set; }
    public decimal Discount { get; set; }
}

public class ContentModel
{
    public string? Description { get; set; }
    public string[]? Includes { get; set; }
    public List<ProgramDetailModel> ProgramDetails { get; set; } = new List<ProgramDetailModel>();
}

public class ProgramDetailModel
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
}


