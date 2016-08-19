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
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public int? paymentId { get; set; }

        [DataMember]
        public string groupKey { get; set; }

        [DataMember]
        public string shopId { get; set; }

        [DataMember]
        public int? priceGroupId { get; set; }

        [DataMember]
        public string encoderName  { get; set; }
        [DataMember]
        public string hashPassword  { get; set; }
        [DataMember]
        public bool active  { get; set; }
        [DataMember]
        public string email  { get; set; }
        [DataMember]
        public SwDateTime firstLogin  { get; set; }
        [DataMember]
        public SwDateTime lastLogin  { get; set; }
        [DataMember]
        public int? accountMode  { get; set; }
        [DataMember]
        public string confirmationKey  { get; set; }
        [DataMember]
        public string sessionId  { get; set; }
        [DataMember]
        public bool newsletter  { get; set; }
        [DataMember]
        public string validation  { get; set; }
        [DataMember]
        public bool affiliate  { get; set; }
        [DataMember]
        public int? paymentPreset  { get; set; }
        [DataMember]
        public int languageId  { get; set; }
        [DataMember]
        public string referer  { get; set; }
        [DataMember]
        public string internalComment  { get; set; }
        [DataMember]
        public int failedLogins  { get; set; }
        [DataMember]
        public SwDateTime lockedUntil  { get; set; }
        [DataMember]
        public CustomerAttribute attribute  { get; set; }
        [DataMember]
        public Address defaultBillingAddress { get; set; }
        [DataMember]
        public PaymentData[] paymentData  { get; set; }
        [DataMember]
        public Address defaultShippingAddress { get; set; }
        [DataMember]
        public Debit debit  { get; set; }

    }
}
