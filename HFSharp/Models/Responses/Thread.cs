using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HFSharp.Models.Responses
{
    [DataContract]
    public class Thread
    {
        [DataMember(Name = "subject")]
        public string Subject { get; set; }

        [DataMember(Name = "threadprefix")]
        public string ThreadPrefix { get; set; }

        [DataMember(Name = "user")]
        public int Uid { get; set; }

        [DataMember(Name = "username")]
        public string Username { get; set; }

        [DataMember(Name = "fid")]
        public int Fid { get; set; }

        [DataMember(Name = "closed")]
        public bool Closed { get; set; }

        [DataMember(Name = "numreplies")]
        public int NumReplies { get; set; }

        [DataMember(Name = "dateline")]
        public DateTime Dateline { get; set; }

        [DataMember(Name = "firstpost")]
        public int FirstPost { get; set; }

        [DataMember(Name = "postdata")]
        public List<Post> Posts { get; set; }
    }
}
