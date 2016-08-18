using System.Runtime.Serialization;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class Price
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public int articleId { get; set; }
        [DataMember]
        public int articleDetailsId { get; set; }
        [DataMember]
        public string customerGroupKey { get; set; }
        [DataMember]
        public string from { get; set; }
        [DataMember]
        public string to { get; set; }
        [DataMember]
        public double price { get; set; }
        [DataMember]
        public double pseudoPrice { get; set; }
        [DataMember]
        public double? basePrice { get; set; }
        [DataMember]
        public double percent { get; set; }
        [DataMember]
        public CustomerGroup customerGroup { get; set; }
    }
}