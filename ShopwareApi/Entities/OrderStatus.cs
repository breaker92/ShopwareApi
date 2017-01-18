using System.Runtime.Serialization;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class OrderStatus
    {
        [DataMember(EmitDefaultValue = false)]
        int id { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string description { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int position { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string group { get; set; }

        [DataMember(EmitDefaultValue = false)]
        bool sendMail { get; set; }

    }
}