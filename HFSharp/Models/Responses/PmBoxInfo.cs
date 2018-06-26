using System.Runtime.Serialization;

namespace HFSharp.Models.Responses
{
    [DataContract]
    public class PmBoxInfo
    {
        [DataMember(Name = "total")]
        public int Total { get; set; }
    }
}
