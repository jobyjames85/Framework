using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Helpers
{
    public class DeepCopy
    {

        /// <summary>
        /// Makes a deep copy of the specified object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objectToCopy">Object to make a deep copy of.</param>
        /// <returns>Deep copy of the object</returns>
        public static T Make<T>(T objectToCopy) where T : class
        {

            using (MemoryStream ms = new MemoryStream())
            {

                var bf = new BinaryFormatter();
                bf.Serialize(ms, objectToCopy);
                ms.Position = 0;
                return (T)bf.Deserialize(ms);
            }
        }
    }
}
