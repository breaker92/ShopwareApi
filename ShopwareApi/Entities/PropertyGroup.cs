using System.Runtime.Serialization;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class PropertyGroup
    {
        [DataMember(EmitDefaultValue = false)]
        public int id { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int position { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public bool comparable { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int sortMode { get; set; }
    }
}