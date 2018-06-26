using System.Runtime.Serialization;

namespace HFSharp.Models.Responses
{
    [DataContract]
    public class PostResponse
    {
        [DataMember(Name = "success")]
        public bool Success { get; set; }

        [DataMember(Name = "message")]
        public string Message { get; set; }

        [DataMember(Name = "result")]
        public Post Result { get; set; }
    }
}
