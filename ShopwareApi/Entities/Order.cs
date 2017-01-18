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
    [ShopwareEntity(EntityName = "orders", AllowedOperation = OperationTypes.Get | OperationTypes.GetList | OperationTypes.Put)]
    public class Order
    {
        [DataMember(EmitDefaultValue = false)]
        public int id { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string number { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int customerId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        Customer customer { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int paymentId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        PaymentInstance payment { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int dispatchId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        Dispatch dispatch { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int partnerId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int shopId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        Shop shop { get; set; }

        [DataMember(EmitDefaultValue = false)]
        double invoiceAmount { get; set; }

        [DataMember(EmitDefaultValue = false)]
        double invoiceAmountNet { get; set; }

        [DataMember(EmitDefaultValue = false)]
        double invoiceShipping { get; set; }

        [DataMember(EmitDefaultValue = false)]
        double invoiceShippingNet { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string orderTime { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string transactionId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string comment { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string customerComment { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string internalComment { get; set; }

        [DataMember(EmitDefaultValue = false)]
        bool net { get; set; }

        [DataMember(EmitDefaultValue = false)]
        bool taxFree { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string temporaryId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string referer { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string clearedDate { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string trackingCode { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string languageIso { get; set; } //Locale

        [DataMember(EmitDefaultValue = false)]
        string currency { get; set; }

        [DataMember(EmitDefaultValue = false)]
        double currencyFactor { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string remoteAddress { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string deviceType { get; set; }

        [DataMember(EmitDefaultValue = false)]
        OrderDetail[] details { get; set; }

        [DataMember(EmitDefaultValue = false)]
        Document[] documents { get; set; }

        [DataMember(EmitDefaultValue = false)]
        PaymentStatus paymentStatus { get; set; }

        [DataMember(EmitDefaultValue = false)]
        OrderStatus orderStatus { get; set; }

        [DataMember(EmitDefaultValue = false)]
        PaymentInstance[] paymentInstances { get; set; }

        [DataMember(EmitDefaultValue = false)]
        Billing billing { get; set; }

        [DataMember(EmitDefaultValue = false)]
        Shipping shipping { get; set; }

        [DataMember(EmitDefaultValue = false)]
        Attribute attribute { get; set; }

        [DataMember(EmitDefaultValue = false)]
        Shop languageSubShop { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int paymentStatusId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int orderStatusId { get; set; }

    }
}
