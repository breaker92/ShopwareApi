using System.Runtime.Serialization;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class Price
    {
        [DataMember(EmitDefaultValue = false)]
        public int id { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int articleId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int articleDetailsId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string customerGroupKey { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string from { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string to { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public double price { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public double pseudoPrice { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public double? basePrice { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public double percent { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public CustomerGroup customerGroup { get; set; }
    }
}