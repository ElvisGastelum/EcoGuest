using System;
using System.IO;
using System.Xml.Serialization;

namespace Controller
{
    public class Writer
    {
        public static void Save<T>(T obj, string path)
        {
            try
            {
                XmlSerializer xmlDoc = new XmlSerializer(typeof(T));
                StreamWriter sw = new StreamWriter(path, false);
                xmlDoc.Serialize(sw, obj);
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
