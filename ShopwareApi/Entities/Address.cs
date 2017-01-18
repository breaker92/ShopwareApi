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
    [ShopwareEntity(EntityName = "addresses", AllowedOperation = OperationTypes.Get | OperationTypes.GetList | OperationTypes.Put | OperationTypes.Post | OperationTypes.Delete)]
    public class Address
    {
        [DataMember(EmitDefaultValue = false)]
		public int id  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public string company  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public string department  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public string salutation  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public string firstname  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public string lastname  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public string street  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public string zipcode  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public string city  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public string phone  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public string vatId  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public string additionalAddressLine1  { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public Country country { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public int state  { get; set; }
        [DataMember(EmitDefaultValue = false)]
		public Array attribute  { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public Customer customer { get; set; }
    }
}
