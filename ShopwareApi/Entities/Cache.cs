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
        [DataMember(EmitDefaultValue = false)]
        public string dir { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string size { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int files { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string freeSpace { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string backend { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string id { get; set; }
    }
}
