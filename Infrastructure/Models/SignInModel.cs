using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models;

public class SignInModel
{
    [Display(Name = "Email address", Prompt = "Enter your Email address", Order = 0)]
    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "Email is required")]

    public string Email { get; set; } = null!;



    [Display(Name = "Password", Prompt = "Enter your Password", Order = 1)]
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "Password required")]

    public string Password { get; set; } = null!;


    [Display(Name = "Remember me", Order = 2)]

    public bool RememberMe { get; set; }
}
