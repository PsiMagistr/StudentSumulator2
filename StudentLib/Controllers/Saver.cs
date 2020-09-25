using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

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
    }
}
