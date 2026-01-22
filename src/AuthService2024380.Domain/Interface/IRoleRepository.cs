using AuthService2024328.Domain.Entities;

namespace AuthService2024328.Domain.Interface;


public interface IRoleRepositoty
{
    Task<Role> GetByNameAsync(string name);

    Task<int> CountUserInRoleAsync(string roleName);

    Task<IReadOnlyList<User>> GetUserByRoleAsync(string roleName);

    Task<IReadOnlyList<string>> GetUserRoleNamesAsync(string userId);
}