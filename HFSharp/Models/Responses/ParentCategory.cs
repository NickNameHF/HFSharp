using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HFSharp.Models.Responses
{
    [DataContract]
    public class ParentCategory
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "parent")]
        public int Parent { get; set; }

        [DataMember(Name = "ficon")]
        public object Ficon { get; set; }

        [DataMember(Name = "children")]
        public List<ChildCategory> Children { get; set; }
    }
}
