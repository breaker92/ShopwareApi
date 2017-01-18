using System.Runtime.Serialization;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class Download
    {
        [DataMember(EmitDefaultValue = false)]
        public int id { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int articleId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string file { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int size { get; set; }
    }
}