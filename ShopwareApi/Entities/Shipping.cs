using System.Runtime.Serialization;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class Shipping
    {
        [DataMember(EmitDefaultValue = false)]
        int id { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int customerId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int countryId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        Country country { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int stateId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        State state { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string company { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string department { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string salutation { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string number { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string firstName { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string lastName { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string street { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string streetNumber { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string zipCode { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string city { get; set; }

    }
}