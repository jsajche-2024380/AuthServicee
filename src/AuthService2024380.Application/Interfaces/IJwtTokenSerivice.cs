
using AuthService2024328.Domain.Entities;

namespace AuthService2024328.Application.Interfaces;

public interface IJwtTokenService
{
    string GenerateToken(User user);
}