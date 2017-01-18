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
    [ShopwareEntity(EntityName = "customers", AllowedOperation = OperationTypes.Get | OperationTypes.GetList | OperationTypes.Put | OperationTypes.Post | OperationTypes.Delete)]
    public class Customer
    {
        [DataMember(EmitDefaultValue = false)]
        public int id { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int? paymentId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string groupKey { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string shopId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int? priceGroupId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string encoderName  { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string hashPassword  { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public bool active  { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string email  { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string firstLogin  { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string lastLogin  { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int? accountMode  { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string confirmationKey  { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string sessionId  { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public bool newsletter  { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string validation  { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public bool affiliate  { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int? paymentPreset  { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int languageId  { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string referer  { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string publicComment  { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int failedLogins  { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string lockedUntil  { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public CustomerAttribute attribute  { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public Address defaultBillingAddress { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public PaymentData[] paymentData  { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public Address defaultShippingAddress { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public Debit debit  { get; set; }

    }
}
