using System.Runtime.Serialization;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class BaseEntity
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string name { get; set; }
    }
}
