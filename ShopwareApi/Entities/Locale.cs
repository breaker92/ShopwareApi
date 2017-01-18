using System.Runtime.Serialization;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class Locale
    {
        [DataMember(EmitDefaultValue = false)]
        int id { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string locale { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string language { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string territory { get; set; }

    }
}