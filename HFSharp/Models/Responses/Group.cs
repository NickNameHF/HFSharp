using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HFSharp.Models.Responses
{
    [DataContract]
    public class Group
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "type")]
        public int Type { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "userbar")]
        public string Userbar { get; set; }

        [DataMember(Name = "owner")]
        public Owner Owner { get; set; }

        [DataMember(Name = "leaders")]
        public List<Leader> Leaders { get; set; }
    }
}
