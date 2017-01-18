using System.Runtime.Serialization;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class Image
    {
        [DataMember(EmitDefaultValue = false)]
        public int id { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int articleId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int? articleDetailId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string description { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string path { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int main { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int position { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int width { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int heights { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string relations { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string extension { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int? parentId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int mediaId { get; set; }
    }
}