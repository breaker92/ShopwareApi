using Shopware.Api.Utili;
using System;
using System.Runtime.Serialization;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class Supplier
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string image { get; set; }
        [DataMember]
        public string link { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public string metaTitle { get; set; }
        [DataMember]
        public string metaDescription { get; set; }
        [DataMember]
        public string metaKeywords { get; set; }
        [DataMember]
        public SwDateTime changed { get; set; }
    }
}