using System.Runtime.Serialization;

namespace HFSharp.Models.Responses
{
    [DataContract]
    public class UserId
    {
        [DataMember(Name = "uid")]
        public int Uid { get; set; }

        [DataMember(Name = "success")]
        public bool Success { get; set; }

        [DataMember(Name = "message")]
        public string Message { get; set; }

        [DataMember(Name = "result")]
        public User Result { get; set; }
    }
}
