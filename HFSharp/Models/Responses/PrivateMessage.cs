using System;
using System.Runtime.Serialization;

namespace HFSharp.Models.Responses
{
    [DataContract]
    public class PrivateMessage
    {
        [DataMember(Name = "to")]
        public int To { get; set; }

        [DataMember(Name = "tousername")]
        public string ToUsername { get; set; }

        [DataMember(Name = "from")]
        public int From { get; set; }

        [DataMember(Name = "fromusername")]
        public string FromUsername { get; set; }

        [DataMember(Name = "subject")]
        public string Subject { get; set; }

        [DataMember(Name = "message")]
        public string Message { get; set; }

        [DataMember(Name = "dateline")]
        public DateTime Dateline { get; set; }

        [DataMember(Name = "folder")]
        public int Folder { get; set; }
    }
}
