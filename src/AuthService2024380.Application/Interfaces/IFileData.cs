namespace AuthService2024328.Application.Interfaces;


public interface IFileData
{
    Byte [] Data {get;}

    String contentType {get;}

    string FileName {get;}

    long Size {get;}
}