using System.Runtime.Serialization;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class Debit
    {
        [DataMember(EmitDefaultValue = false)]
		public int id  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public int customerId  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public string account  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public string bankCode  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public string bankName  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public string accountHolder  { get; set; }
    }
}