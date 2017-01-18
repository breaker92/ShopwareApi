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
        [DataMember(EmitDefaultValue = false)]
		public int id  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public int albumId  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public string name  { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string file { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public string description  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public string path  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public string type  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public string extension  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public int userId  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public string created  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public int fileSize  { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int width { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int height { get; set; }
    }
}
