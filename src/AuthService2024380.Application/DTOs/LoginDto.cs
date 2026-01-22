using System.ComponentModel.DataAnnotations;

namespace AuthService2024328.Application.DTOs;

public class LoginDto
{
    public string EmailOrUsername{get;set;}= string.Empty;
    public string Password{get;set;} = string.Empty;
}