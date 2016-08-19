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
        [DataMember]
		public int id  { get; set; }
        [DataMember]
		public string company  { get; set; }
        [DataMember]
		public string department  { get; set; }
        [DataMember]
		public string salutation  { get; set; }
        [DataMember]
		public string firstname  { get; set; }
        [DataMember]
		public string lastname  { get; set; }
        [DataMember]
		public string street  { get; set; }
        [DataMember]
		public string zipcode  { get; set; }
        [DataMember]
		public string city  { get; set; }
        [DataMember]
		public string phone  { get; set; }
        [DataMember]
		public string vatId  { get; set; }
        [DataMember]
		public string additionalAddressLine1  { get; set; }
        [DataMember]
        public Country country { get; set; }
        [DataMember]
		public int state  { get; set; }
        [DataMember]
		public array attribute  { get; set; }
        [DataMember]
        public Customer customer { get; set; }
    }
}
