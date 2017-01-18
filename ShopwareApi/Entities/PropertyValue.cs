using System.Runtime.Serialization;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class PropertyValue
    {
        [DataMember(EmitDefaultValue = false)]
        public int id { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int position { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int optionId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public double? valueNumeric { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string value { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int? mediaId { get; set; }
    }
}