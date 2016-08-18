using System.Runtime.Serialization;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class PropertyGroup
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public int position { get; set; }
        [DataMember]
        public bool comparable { get; set; }
        [DataMember]
        public int sortMode { get; set; }
    }
}