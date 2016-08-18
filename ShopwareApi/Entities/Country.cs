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
    [ShopwareEntity(EntityName = "categories", AllowedOperation = OperationTypes.Get | OperationTypes.GetList | OperationTypes.Put | OperationTypes.Post | OperationTypes.Delete)]
    public class Country
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public string iso { get; set; }

        [DataMember]
        public string isoName { get; set; }

        [DataMember]
        public int? position { get; set; }

        [DataMember]
        public string description { get; set; }

        [DataMember]
        public bool shippingFree { get; set; }

        [DataMember]
        public bool taxFree { get; set; }

        [DataMember]
        public bool taxFreeUstId { get; set; }

        [DataMember]
        public bool taxFreeUstIdChecked { get; set; }

        [DataMember]
        public bool active { get; set; }

        [DataMember]
        public string iso3 { get; set; }

        [DataMember]
        public bool displayStateInRegistration { get; set; }

        [DataMember]
        public bool forceStateInRegistration { get; set; }

        [DataMember]
        public int areaId { get; set; }

        [DataMember]
        public State[] states { get; set; }
    }
}
