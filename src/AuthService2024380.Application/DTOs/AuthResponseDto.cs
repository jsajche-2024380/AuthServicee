namespace AuthService2024328.Application.DTOs;

public class AuthResponseDto
{
    public bool Succes {get;set;}= true;
    public string Message {get;set;}= string.Empty;
    public string Token {get;set;}= string.Empty;
    public UserDetailsDto userDetails{get;set;}
    public DateTime ExpiredAt {get;set;}
}