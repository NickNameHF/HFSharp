using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace HFSharp.Models.Responses
{
    [DataContract]
    public class GroupResponse
    {
        [DataMember(Name = "success")]
        public bool Success { get; set; }

        [DataMember(Name = "message")]
        public string Message { get; set; }

        [DataMember(Name = "result")]
        public Group Result { get; set; }
    }
}
