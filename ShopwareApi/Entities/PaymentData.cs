using Shopware.Api.Utili;
using System;
using System.Runtime.Serialization;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class PaymentData
    {
        [DataMember]
		public int id  { get; set; }
        [DataMember]
		public int paymentMeanId  { get; set; }
        [DataMember]
		public string useBillingData  { get; set; }
        [DataMember]
		public string bankName  { get; set; }
        [DataMember]
		public string bic  { get; set; }
        [DataMember]
		public string iban  { get; set; }
        [DataMember]
		public string accountNumber  { get; set; }
        [DataMember]
		public string bankCode  { get; set; }
        [DataMember]
		public string accountHolder  { get; set; }
        [DataMember]
		public SwDateTime createdAt  { get; set; }
    }
}