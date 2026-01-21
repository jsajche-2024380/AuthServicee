namespace AuthService2024328.Application.Interfaces;

public interface IEmailService
{
    Task SendEmailVerificationAsync(string email, string username,string token);
    Task SendPasswordResetAsync(string email,string username,string toke);
    Task SendWelcomeEmailAsync(string email,string username);
}