using AuthService2024328.Application.DTOs;
namespace AuthService2024328.Application.Interfaces;

public interface IUserManagementService
{
    Task<UserResponseDtos> UpdateUserRoleAsync(string userId,string rolName);
    Task<IReadOnlyList<String>> GetUserRolesAsync(string userId);
    Task<IReadOnlyList<UserResponseDtos>> GetUserByRoleAsync(string rolName);
}