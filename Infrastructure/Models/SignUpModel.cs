using Infrastructure.Helpers;

using System.ComponentModel.DataAnnotations;


namespace Infrastructure.Models;

public class SignUpModel
{
    [Required]
    [Display(Name = "First name")]
    public string FirstName { get; set; } = null!;

    [Required]
    [Display(Name = "Last name")]
    public string LastName { get; set; } = null!;

    [Required]
    [EmailAddress]
    [RegularExpression("^[^@\\s]+@[^@\\s]+\\.[^@\\s]{2,}$", ErrorMessage = "Your email address is invalid")]
    [Display(Name = "Email")]
    public string Email { get; set; } = "";

    [Required]
    [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{8,}$", ErrorMessage = "Invalid Password, must be a strong password")]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string Password { get; set; } = "";

    [DataType(DataType.Password)]
    [Display(Name = "Confirm password")]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    public string ConfirmPassword { get; set; } = "";

    [Display(Name = "I agree to the Terms & Conditions.")]
    [CheckBoxRequired(ErrorMessage = "You must accept the terms and condtitions to proceed.")]

    public bool TermsAndConditions { get; set; } = false;
}
