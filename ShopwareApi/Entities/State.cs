using System.Runtime.Serialization;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class State
    {
        [DataMember(EmitDefaultValue = false)]
        public int id { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int countryId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int position { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string shortCode { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool active { get; set; }
    }
}