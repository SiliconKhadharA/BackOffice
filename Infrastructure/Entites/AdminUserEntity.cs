using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
namespace Infrastructure.Entites;

public class AdminUserEntity : IdentityUser
{


    [ProtectedPersonalData]
    public string FullName { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public DateTime LastModifiedDate { get; set; }

    public bool IsAdmin { get; set; }
}
