using System.Runtime.Serialization;

namespace HFSharp.Models.Responses
{
    [DataContract]
    public class ThreadResponse
    {
        [DataMember(Name = "success")]
        public bool Success { get; set; }

        [DataMember(Name = "message")]
        public string Message { get; set; }

        [DataMember(Name = "result")]
        public Thread Result { get; set; }
    }
}
