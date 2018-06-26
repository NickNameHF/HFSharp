using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace HFSharp.Extensions
{
    public static class HFSharpExtensions
    {
        public static T JsonToOjbect<T>(this string json)
        {
            var bytes = Encoding.Unicode.GetBytes(json);
            using (MemoryStream stream = new MemoryStream(bytes))
            {
                var serializer = new DataContractJsonSerializer(typeof(T));
                var output = (T)serializer.ReadObject(stream);
                return output;
            }
        }

        public static string ToBase64(this string plain) {
            byte[] bytes = Encoding.UTF8.GetBytes(plain);
            return Convert.ToBase64String(bytes);
        }
    }
}
