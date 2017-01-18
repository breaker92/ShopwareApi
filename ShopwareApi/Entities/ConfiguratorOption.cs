using System.Runtime.Serialization;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class ConfiguratorOption
    {
        [DataMember(EmitDefaultValue = false)]
        public int id { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int groupId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int position { get; set; }
    }
}