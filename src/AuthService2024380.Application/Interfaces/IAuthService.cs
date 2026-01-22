using AuthService2024328.Application.DTOs;
using AuthService2024328.Application.DTOs.Email;

namespace AuthService2024328.Application.Interfaces;

public interface IAuthservice
{
    Task<RegisterResponseDto> RegisterAsync (RegisterDto registerDto);
    Task<AuthResponseDto> LoginAsync (LoginDto loginDto);
    Task<EmailResponseDto> VerifyEmailAsync (VerifyEmailDto verifyEmailDto);
    Task<EmailResponseDto> ResendVerificationEmailAsync(ResendVerificationDto resendVerificationDto);
    Task<EmailResponseDto> ForgotPasswordAsync(ForgotPasswordDto forgotPasswordDto);
    Task<EmailResponseDto> ResetPasswordAsync(ResetPasswordDto resetPasswordDto);
    Task<UserResponseDtos> GetUserByIdAsync (string userId);
}
