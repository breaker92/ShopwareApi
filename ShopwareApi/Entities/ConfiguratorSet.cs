using System.Runtime.Serialization;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class ConfiguratorSet
    {
        [DataMember(EmitDefaultValue = false)]
        public int id { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }
        [DataMember(Name = "public")]
        public bool Public { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int type { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public ConfiguratorGroup[] groups { get; set; }
    }
}