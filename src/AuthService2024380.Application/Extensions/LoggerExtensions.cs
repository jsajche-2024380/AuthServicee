using System;
using Microsoft.Extensions.Logging;

namespace AuthService2024328.Application.Extensions;

public static partial class LoggerExtensions
{
    [LoggerMessage(
        EventId = 1001,
        Level = LogLevel.Information,
        Message = "User {username} registered successfully")]
    public static partial void LogUserRegistered(this ILogger logger, string username);


    [LoggerMessage(
        EventId = 1002,
        Level = LogLevel.Information,
        Message = "User login  successfully")]
    public static partial void LogUserLoggedIn(this ILogger logger);


    [LoggerMessage(
        EventId = 1003,
        Level = LogLevel.Information,
        Message = "Failde login attempt")]
    public static partial void LogFaildedLoginAttempt(this ILogger logger);


    [LoggerMessage(
        EventId = 1004,
        Level = LogLevel.Information,
        Message = "Registration rejected: Email already exist")]
    public static partial void LogRegistrattionWithExistingEmail(this ILogger logger);


        [LoggerMessage(
        EventId = 1005,
        Level = LogLevel.Information,
        Message = "Erro uploading profile image.")]
    public static partial void LogImageUploadError(this ILogger logger);
}