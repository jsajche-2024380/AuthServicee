using AuthService2024328.Application.Interfaces;

namespace AuthService2024328.Application.Interfaces;

public interface ICloudinaryService
{
    Task<String> UploadImageAsync(IFileData imagenFile, string filename);
    Task<bool> DeleteImageAsync(string publicId);
    string GetDefaulAvatarUrl();
    string GetFullImageUrl(string imagePath);
}