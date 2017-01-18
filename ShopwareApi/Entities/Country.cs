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
    [ShopwareEntity(EntityName = "countries", AllowedOperation = OperationTypes.Get | OperationTypes.GetList | OperationTypes.Put | OperationTypes.Post | OperationTypes.Delete)]
    public class Country
    {
        [DataMember(EmitDefaultValue = false)]
        public int id { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string iso { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string isoName { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int? position { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string description { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool shippingFree { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool taxFree { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool taxFreeUstId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool taxFreeUstIdChecked { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool active { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string iso3 { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool displayStateInRegistration { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool forceStateInRegistration { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int areaId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public State[] states { get; set; }
    }
}
