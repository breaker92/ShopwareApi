using Shopware.Api.Entities.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Shopware.Api.Entities
{
    [DataContract]
    [ShopwareEntity(EntityName = "manufacturers", AllowedOperation = OperationTypes.Get | OperationTypes.GetList | OperationTypes.Put | OperationTypes.Post | OperationTypes.Delete)]
    public class Manufacturers
    {
        [DataMember(EmitDefaultValue = false)]
		public int id  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public string name  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public string image  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public string link  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public string description  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public string metaTitle  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public string metaKeywords  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public string metaDescription  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public Array attribute  { get; set; }
    }
}
