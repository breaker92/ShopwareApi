using System.Runtime.Serialization;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class DocumentType
    {
        [DataMember(EmitDefaultValue = false)]
        int id { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string name { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string template { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string numbers { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int left { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int right { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int top { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int bottom { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int pageBreak { get; set; }

    }
}