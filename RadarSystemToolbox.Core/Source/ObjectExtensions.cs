using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace RadarSystemToolbox.Core
{
    public static class ObjectExtensions
    {
        public static T Copy<T>(this T value)
        {
            IFormatter formatter = new BinaryFormatter();

            using (MemoryStream stream = new MemoryStream())
            {
                formatter.Serialize(stream, value);

                stream.Seek(0, SeekOrigin.Begin);

                var o = formatter.Deserialize(stream);

                return (T)o;
            }
        }
    }
}
