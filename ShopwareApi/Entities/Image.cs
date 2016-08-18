using System.Runtime.Serialization;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class Image
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public int articleId { get; set; }
        [DataMember]
        public int? articleDetailId { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public string path { get; set; }
        [DataMember]
        public int main { get; set; }
        [DataMember]
        public int position { get; set; }
        [DataMember]
        public int width { get; set; }
        [DataMember]
        public int heights { get; set; }
        [DataMember]
        public string relations { get; set; }
        [DataMember]
        public string extension { get; set; }
        [DataMember]
        public int? parentId { get; set; }
        [DataMember]
        public int mediaId { get; set; }
    }
}