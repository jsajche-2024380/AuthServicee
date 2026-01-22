using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace AuthService2024328.Domain.Entities;

public class UserEmil
{
    [Key]
    [MaxLength(16)]
    public string  Id {get;set;} = string.Empty;

    [Required]
    [MaxLength(16)]
    public string UserId {get;set;} = string.Empty;

    [Required]
    public bool EmailVerified {get;set;} = false;

    public string EmailVerificationToken{get;set;}

    public DateTime? EmailVerificationTokenExpiry {get;set;}

    [Required]
    public User User {get;set;} = null;
}