namespace AuthService2024328.Application.DTOs;

public class UserResponseDtos
{
    public string Id {get;set;} = string.Empty;

    public string name {get;set;} = string.Empty;

    public string Surname {get;set;} = string.Empty;

    public string Username {get;set;} = string.Empty;

    public string Email {get;set;}  = string.Empty;

    public string ProfilePicture {get;set;} = string.Empty;

    public string Phone {get;set;}= string.Empty;

    public string Role {get;set;} = string.Empty;

    public bool Status {get;set;}
    public bool IsEmailVerified{get;set;}
    public DateTime CreatedAt{get;set;}
    public DateTime UpdateAt{get;set;}

    
}