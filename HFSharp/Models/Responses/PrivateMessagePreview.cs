using System;
using System.Runtime.Serialization;

namespace HFSharp.Models.Responses
{
    [DataContract]
    public class PrivateMessagePreview
    {
        [DataMember(Name = "pmid")]
        public int PmId { get; set; }

        [DataMember(Name = "subject")]
        public string Subject { get; set; }

        [DataMember(Name = "senderusername")]
        public string SenderUsername { get; set; }

        [DataMember(Name = "sender")]
        public int Sender { get; set; }

        [DataMember(Name = "recipientusername")]
        public string RecipientUsername { get; set; }

        [DataMember(Name = "recipient")]
        public int Recipient { get; set; }

        [DataMember(Name = "status")]
        public int Status { get; set; }

        [DataMember(Name = "dateline")]
        public DateTime Dateline { get; set; }
    }
}
