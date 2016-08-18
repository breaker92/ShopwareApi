using System.Runtime.Serialization;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class Tax
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string tax { get; set; }
        [DataMember]
        public string name { get; set; }
    }
}