using System;
using System.IO;
using System.Xml.Serialization;

namespace Scantech.Infrastructure.Services
{
    public class XmlService : Scantech.Infrastructure.Services.IService
    {
        public void Write<T>(T model, string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(model.GetType());
            TextWriter textWriter = new StreamWriter(fileName);
            serializer.Serialize(textWriter, model);
            textWriter.Close();
        }

        public T Read<T>(string fileName)
        {
            var modelType = typeof(T);
            T model;

            XmlSerializer serializer = new XmlSerializer(modelType);
            TextReader textReader = new StreamReader(fileName);

            try
            {
                model = (T)serializer.Deserialize(textReader);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                textReader.Close();
            }

            return model;
        }

        public void Delete(string xmlFilename)
        {
            try
            {
                File.Delete(xmlFilename);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
