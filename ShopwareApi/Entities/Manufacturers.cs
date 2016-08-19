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
        [DataMember]
		public int id  { get; set; }
        [DataMember]
		public string name  { get; set; }
        [DataMember]
		public string image  { get; set; }
        [DataMember]
		public string link  { get; set; }
        [DataMember]
		public string description  { get; set; }
        [DataMember]
		public string metaTitle  { get; set; }
        [DataMember]
		public string metaKeywords  { get; set; }
        [DataMember]
		public string metaDescription  { get; set; }
        [DataMember]
		public array attribute  { get; set; }
    }
}
