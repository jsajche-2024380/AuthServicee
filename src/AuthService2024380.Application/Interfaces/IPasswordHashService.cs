namespace AuthService2024328.Application.Interfaces;

public interface IPasswordHashSerivice
{
    string hashPassword (string password);
    string verifyPassword (string password,string hashPassword);
}