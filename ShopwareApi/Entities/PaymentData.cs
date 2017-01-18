using Shopware.Api.Utili;
using System;
using System.Runtime.Serialization;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class PaymentData
    {
        [DataMember(EmitDefaultValue = false)]
		public int id  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public int paymentMeanId  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public string useBillingData  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public string bankName  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public string bic  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public string iban  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public string accountNumber  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public string bankCode  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public string accountHolder  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public string createdAt  { get; set; }
    }
}