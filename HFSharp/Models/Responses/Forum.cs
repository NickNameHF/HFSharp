using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HFSharp.Models.Responses
{
    [DataContract]
    public class Forum
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "parent")]
        public int Parent { get; set; }

        [DataMember(Name = "numthreads")]
        public string NumThreads { get; set; }

        [DataMember(Name = "threaddata")]
        public List<Thread> Threads { get; set; }
    }
}
