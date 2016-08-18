using System.Runtime.Serialization;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class ConfiguratorSet
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember(Name = "public")]
        public bool Public { get; set; }
        [DataMember]
        public int type { get; set; }
        [DataMember]
        public ConfiguratorGroup[] groups { get; set; }
    }
}