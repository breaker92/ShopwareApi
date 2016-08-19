using System.Runtime.Serialization;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class Debit
    {
        [DataMember]
		public int id  { get; set; }
        [DataMember]
		public int customerId  { get; set; }
        [DataMember]
		public string account  { get; set; }
        [DataMember]
		public string bankCode  { get; set; }
        [DataMember]
		public string bankName  { get; set; }
        [DataMember]
		public string accountHolder  { get; set; }
    }
}