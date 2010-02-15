using System;
namespace Scantech.Infrastructure.Services
{
    interface IService
    {
        void Delete(string xmlFilename);
        T Read<T>(string fileName);
        void Write<T>(T model, string fileName);
    }
}
