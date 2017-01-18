using Shopware.Api.Utili;
using System;
using System.Runtime.Serialization;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class Supplier
    {
        [DataMember(EmitDefaultValue = false)]
        public int id { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string image { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string link { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string description { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string metaTitle { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string metaDescription { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string metaKeywords { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string changed { get; set; }
    }
}