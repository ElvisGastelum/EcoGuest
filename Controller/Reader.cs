using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Controller
{
    public class Reader
    {
        public static TResult Load<TResult>(string path)
            where TResult : new()
        {
            TResult result = new TResult();
            try
            {
                XmlSerializer xmlDoc = new XmlSerializer(typeof(TResult));
                StreamReader sw = new StreamReader(path);
                result = (TResult)xmlDoc.Deserialize(sw);
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return result;
        }
    }
}