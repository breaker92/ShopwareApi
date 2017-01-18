using System.Runtime.Serialization;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class ConfiguratorGroup
    {
        [DataMember(EmitDefaultValue = false)]
        public int id { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string description { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int position { get; set; }
    }
}