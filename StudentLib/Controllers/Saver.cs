using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace StudentLib.classes
{
    
    public abstract class Saver
    {
        protected void Save(String filename, object item)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (var fs = new FileStream(filename, FileMode.Create))
            {
                formatter.Serialize(fs, item); 
            }
        }

        protected T Load<T>(String filename)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (var fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                if (fs.Length > 0 && formatter.Deserialize(fs) is T item)
                {
                    return item;
                }
                return default(T);
            }
        }

        public void JsonSave(string filename, City item)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            //serializer.MaxJsonLength = 100000000000;
            var serializedResult = serializer.Serialize(item);
            /* using (FileStream fstream = new FileStream(filename, FileMode.OpenOrCreate))
             {
                 // преобразуем строку в байты
                 byte[] array = System.Text.Encoding.Default.GetBytes(text);
                 // запись массива байтов в файл
                 fstream.Write(serializedResult);
                 Console.WriteLine("Текст записан в файл");
             }*/
            File.WriteAllText(filename, serializedResult);
        }
    }
}
