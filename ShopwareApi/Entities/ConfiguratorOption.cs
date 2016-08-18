using System.Runtime.Serialization;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class ConfiguratorOption
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public int groupId { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public int position { get; set; }
    }
}