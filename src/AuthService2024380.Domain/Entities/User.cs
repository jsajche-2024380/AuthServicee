using System.ComponentModel.DataAnnotations;

namespace AuthService2024328.Domain.Entities;

public class User
{
    [Key]
    [MaxLength]
    public string Id {get;set;}= string.Empty;

    [Required(ErrorMessage ="El nombre es obligatorio")]
    [MaxLength(25,ErrorMessage ="El nombre no puede tener mas de 25 caracteres")]
    public string Name {get;set;}= string.Empty;

    [Required(ErrorMessage ="El Apellido es obligatorio")]
    [MaxLength(25,ErrorMessage ="El Apellido no puede tener mas de 25 caracteres")]
    public string Surname {get;set;}= string.Empty;

    [Required(ErrorMessage ="El Nombre es obligatorio")]
    [MaxLength(25,ErrorMessage ="El Nombre no puede tener mas de 25 caracteres")]
    public string Username {get;set;}= string.Empty;

    [Required(ErrorMessage ="El correo electronico es obligatorio")]
    [EmailAddress(ErrorMessage ="El correo electronico no tiene formato valido.")]
    [MaxLength(150,ErrorMessage ="El correo electronico no puede tener mas de 150 caracteres.")]
    public string Email {get;set;} = string.Empty;

    [Required(ErrorMessage ="La contrañe es obligatoria")]
    [MinLength(5,ErrorMessage ="La contraseña no debe tener mens de 8 caracteres")]
    [MaxLength(255,ErrorMessage ="La contraseña no puede mas de 255 carateres")]
    public string Password {get;set;} = string.Empty;

    public bool Status {get;set;} = false;

    [Required]
    public DateTime CreateAt {get;set;}

    [Required]
    public DateTime UpdateAt{get;set;}

    public UserProfile UserProfile{get;set;} = null!;
    public ICollection<UserRole> userRoles{get;set;} = [];
    public UserEmil UserEmil {get;set;} = null!;
    public UserPasswordReset UserPasswordReset{get;set;} = null!;

}