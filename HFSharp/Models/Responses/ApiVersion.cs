using System.Runtime.Serialization;

namespace HFSharp.Models.Responses
{
    [DataContract]
    public class ApiVersion
    {
        [DataMember(Name = "success")]
        public bool Success { get; set; }

        [DataMember(Name = "apiVersion")]
        public double Version { get; set; }
    }
}
