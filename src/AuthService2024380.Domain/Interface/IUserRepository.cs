using AuthService2024328.Domain.Entities;

namespace AuthService2024328.Domain.Interface; 

public interface IUserRepository
{
    Task<User> CreateAsync (User user);

    Task<User> GetByIdAsync (string id);

    Task<User?> GetByEmailasync (string email);

    Task<User?> GetByUsernameAsync (string Username);

    Task<User?> GetByEmailVerificationTokenAsync(string token);

    Task<User?> GetByPasswordResetTokenAsync(string token);

    Task<bool> ExistsByEmailAsync(string email);

    Task<bool> ExistByUsernameAsync(string username);

    Task<User> UpdateAsync(User user);

    Task<bool> DeleteAsync (String id);

    Task UpdateUserRoleAsync (string userId, string roleId);

    
}
