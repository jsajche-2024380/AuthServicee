namespace AuthService2024328.Application.DTOs;

public class RegisterResponseDto
{
    public bool Succes {get;set;}= false;
    public UserResponseDtos user {get;set;}= new();
    public string Message {get;set;}= string.Empty;
    public bool EmailVerificationRequired {get;set;}= true;

}