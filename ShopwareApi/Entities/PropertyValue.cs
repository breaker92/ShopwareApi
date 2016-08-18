using System.Runtime.Serialization;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class PropertyValue
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public int position { get; set; }
        [DataMember]
        public int optionId { get; set; }
        [DataMember]
        public double? valueNumeric { get; set; }
        [DataMember]
        public string value { get; set; }
        [DataMember]
        public int? mediaId { get; set; }
    }
}