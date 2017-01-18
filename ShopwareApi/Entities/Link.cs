using System.Runtime.Serialization;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class Link
    {
        [DataMember(EmitDefaultValue = false)]
        public int id { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int articleId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string link { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string target { get; set; }
    }
}