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
    [ShopwareEntity(EntityName = "caches", AllowedOperation = OperationTypes.Get | OperationTypes.GetList | OperationTypes.Delete | OperationTypes.DeleteBatch)]
    public class Cache
    {
        [DataMember]
        public string dir { get; set; }

        [DataMember]
        public string size { get; set; }

        [DataMember]
        public int files { get; set; }

        [DataMember]
        public string freeSpace { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public string backend { get; set; }

        [DataMember]
        public string id { get; set; }
    }
}
