using System.Runtime.Serialization;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class CustomerGroup
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string key { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public bool tax { get; set; }
        [DataMember]
        public bool taxInput { get; set; }
        [DataMember]
        public bool mode { get; set; }
        [DataMember]
        public double discount { get; set; }
        [DataMember]
        public double minimumOrder { get; set; }
        [DataMember]
        public double minimumOrderSurcharge { get; set; }
        [DataMember]
        public double? basePrice { get; set; }
        [DataMember]
        public double? percent { get; set; }
    }
}