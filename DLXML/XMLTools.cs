using DLAPI.DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DLXML
{
    public static class XMLTools
    {
        private static string dir = @"..\DATA\";
        public static void saveListToXML<T>(List<T> list, string path)
        {
            //TODO: Handle Exception
            XmlSerializer x = new XmlSerializer(list.GetType());
            FileStream fs = new FileStream(dir+path, FileMode.Create);
            x.Serialize(fs, list);
            fs.Close();
        }
        public static List<T> LoadListFromXML<T>(string path)
        {
            List<T>? list = new List<T>();
            try {
                XmlSerializer x = new XmlSerializer(typeof(List<T>));
                FileStream fileStream = new FileStream(dir+path,FileMode.Open);
                list = x.Deserialize(fileStream) as List<T>;
                fileStream.Close();
                return (list != null)? list:throw new XMLEmptyListException(typeof(T).ToString());
            }
            catch (Exception e)
            {
                throw new XMLLoadException(dir+path,e);
            }
            
        }

    }
}
