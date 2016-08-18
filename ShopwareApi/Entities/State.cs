using System.Runtime.Serialization;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class State
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public int countryId { get; set; }

        [DataMember]
        public int position { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public string shortCode { get; set; }

        [DataMember]
        public bool active { get; set; }
    }
}