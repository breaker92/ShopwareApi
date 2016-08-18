using System.Runtime.Serialization;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class Link
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public int articleId { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string link { get; set; }
        [DataMember]
        public string target { get; set; }
    }
}