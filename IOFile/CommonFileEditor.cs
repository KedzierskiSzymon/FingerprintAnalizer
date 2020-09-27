using Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IOFile
{
    public class CommonFileEditor
    {
        public CommonFileEditor()
        {
        }

        public IList<string> GetFilenamesFromSelectedDictionary(IApplicationConfiguration configuration)
        {
            IList<string> filenames = Directory.GetFiles(configuration.FingerprintDirectory, $"*{configuration.FileExtension}")?.ToList();

            for (int i = 0; i < filenames.Count; i++)
                filenames[i] = Path.GetFileNameWithoutExtension(filenames[i]);

            return filenames;
        }

        public T Deserialize<T>(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            StreamReader reader = new StreamReader(filename);
            T configuration = (T)serializer.Deserialize(reader);

            reader.Close();

            return configuration;
        }

        public void Serialize<T>(T serializedObject, string filename)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

            TextWriter writer = new StreamWriter(filename);
            xmlSerializer.Serialize(writer, serializedObject);
            writer.Close();
        }
    }
}
