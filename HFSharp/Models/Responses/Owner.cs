using System.Runtime.Serialization;

namespace HFSharp.Models.Responses
{
    [DataContract]
    public class Owner
    {
        [DataMember(Name = "uid")]
        public int Uid { get; set; }

        [DataMember(Name = "username")]
        public string Username { get; set; }
    }
}
