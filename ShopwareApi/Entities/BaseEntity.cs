using System.Runtime.Serialization;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class BaseEntity
    {
        [DataMember(EmitDefaultValue = false)]
        public int id { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }
    }
}
