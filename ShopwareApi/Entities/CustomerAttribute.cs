using System.Runtime.Serialization;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class CustomerAttribute
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public int customerId { get; set; }
    }
}