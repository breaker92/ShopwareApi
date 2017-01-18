using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class Document
    {
        [DataMember(EmitDefaultValue = false)]
        int id { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string date { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int typeId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        DocumentType type { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int customerId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        Customer customer { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int orderId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        Order order { get; set; }

        [DataMember(EmitDefaultValue = false)]
        double amount { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int documentId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string hash { get; set; }

        //attribute object DocumentAttribute
    }
}
