using Shopware.Api.Entities.Attributes;
using System.Runtime.Serialization;

namespace Shopware.Api.Entities
{
    [DataContract]
    [ShopwareEntity(EntityName = "customerGroups", AllowedOperation = OperationTypes.Get | OperationTypes.GetList | OperationTypes.Put | OperationTypes.Post | OperationTypes.Delete)]
    public class CustomerGroup
    {
        [DataMember(EmitDefaultValue = false)]
        public int id { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string key { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public bool tax { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public bool taxInput { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public bool mode { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public double discount { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public double minimumOrder { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public double minimumOrderSurcharge { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public double? basePrice { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public double? percent { get; set; }
    }
}