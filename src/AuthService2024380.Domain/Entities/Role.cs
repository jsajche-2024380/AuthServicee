using System.ComponentModel.DataAnnotations;

namespace AuthService2024328.Domain.Entities;

public class Role
{
    [Key]
    [MaxLength]
    public string Id {get;set;} = string.Empty;

    [Required(ErrorMessage ="El nombre del rol es obligatorio")]
    [MaxLength(100,ErrorMessage ="El nombre del rol no puede superar los 100 caracteres")]
    public string Name {get;set;}= string.Empty;

    public DateTime CreateAt {get;set;}= DateTime.UtcNow;

    public DateTime UpdatAt {get;set;}= DateTime.UtcNow;

    public ICollection<UserRole> UserRole {get;set;} = [];
}