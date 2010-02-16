using System;
namespace Scantech.Infrastructure.Services
{
    interface IService
    {
        T Read<T>(string fileName);
        void Write<T>(T model, string fileName);
        void Delete(string xmlFilename);
    }
}
