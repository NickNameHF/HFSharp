using System;
using System.Runtime.Serialization;

namespace HFSharp.Models.Responses
{
    [DataContract]
    public class Post
    {
        [DataMember(Name = "tid")]
        public int Tid { get; set; }

        [DataMember(Name = "parent")]
        public int Parent { get; set; }

        [DataMember(Name = "fid")]
        public int Fid { get; set; }

        [DataMember(Name = "subject")]
        public string Subject { get; set; }

        [DataMember(Name = "uid")]
        public int Uid { get; set; }

        [DataMember(Name = "username")]
        public string Username { get; set; }

        [DataMember(Name = "dateline")]
        public DateTime Dateline { get; set; }

        [DataMember(Name = "message")]
        public string Message { get; set; }

        [DataMember(Name = "edituid")]
        public int EditUid { get; set; }

        [DataMember(Name = "edittime")]
        public DateTime EditTime { get; set; }
    }
}
