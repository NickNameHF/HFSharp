using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HFSharp.Models.Responses
{
    [DataContract]
    public class User
    {
        [DataMember(Name = "username")]
        public string Username { get; set; }

        [DataMember(Name = "postnum")]
        public int PostNumber { get; set; }

        [DataMember(Name = "avatar")]
        public string Avatar { get; set; }

        [DataMember(Name = "avatartype")]
        public string AvatarType { get; set; }

        [DataMember(Name = "usergroup")]
        public string UserGroup { get; set; }

        [DataMember(Name = "displaygroup")]
        public string DisplayGroup { get; set; }

        [DataMember(Name = "additionalgroups")]
        public List<int> AdditionalGroups { get; set; }

        [DataMember(Name = "usertitle")]
        public string UserTitle { get; set; }

        [DataMember(Name = "timeonline")]
        public int TimeOnline { get; set; }

        [DataMember(Name = "regdate")]
        public DateTime RegisterDate { get; set; }

        [DataMember(Name = "lastactive")]
        public DateTime LastActive { get; set; }

        [DataMember(Name = "reputation")]
        public int Reputation { get; set; }
    }
}
