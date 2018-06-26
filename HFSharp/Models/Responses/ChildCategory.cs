using System.Runtime.Serialization;

namespace HFSharp.Models.Responses
{
    [DataContract]
    public class ChildCategory
    {
        [DataMember(Name = "fid")]
        public int Fid { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "ficon")]
        public object Ficon { get; set; }
    }
}
