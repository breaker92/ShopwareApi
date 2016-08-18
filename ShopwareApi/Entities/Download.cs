using System.Runtime.Serialization;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class Download
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public int articleId { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string file { get; set; }
        [DataMember]
        public int size { get; set; }
    }
}