using Shopware.Api.Entities.Attributes;
using Shopware.Api.Utili;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Shopware.Api.Entities
{
    [DataContract]
    [ShopwareEntity(EntityName = "media", AllowedOperation = OperationTypes.Get | OperationTypes.GetList | OperationTypes.Post | OperationTypes.Delete)]
    public class Media
    {
        [DataMember]
		public int id  { get; set; }
        [DataMember]
		public int albumId  { get; set; }
        [DataMember]
		public string name  { get; set; }
        [DataMember]
        public string file { get; set; }
        [DataMember]
		public string description  { get; set; }
        [DataMember]
		public string path  { get; set; }
        [DataMember]
		public string type  { get; set; }
        [DataMember]
		public string extension  { get; set; }
        [DataMember]
		public int userId  { get; set; }
        [DataMember]
		public SwDateTime created  { get; set; }
        [DataMember]
		public int fileSize  { get; set; }
        [DataMember]
        public int width { get; set; }
        [DataMember]
        public int height { get; set; }
    }
}
