using System.Runtime.Serialization;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class PaymentInstance
    {
        [DataMember(EmitDefaultValue = false)]
        int id { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string firstName { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string lastName { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string address { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string zipCode { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string city { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string bankName { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string bankCode { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string accountNumber { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string accountHolder { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string bic { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string iban { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string amount { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string createdAt { get; set; }

    }
}