using System.Runtime.Serialization;

namespace HFSharp.Models.Responses
{
    [DataContract]
    public class Leader
    {
        [DataMember(Name = "uid")]
        public string Uid { get; set; }

        [DataMember(Name = "username")]
        public string Username { get; set; }
    }
}
