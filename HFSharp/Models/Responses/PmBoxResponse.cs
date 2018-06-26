using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HFSharp.Models.Responses
{
    [DataContract]
    public class PmBoxResponse
    {
        [DataMember(Name = "pmbox")]
        public string pmbox { get; set; }

        [DataMember(Name = "pageInfo")]
        public PmBoxInfo pageInfo { get; set; }

        [DataMember(Name = "pms")]
        public List<PrivateMessagePreview> PrivateMessages { get; set; }
    }
}
