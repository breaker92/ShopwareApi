using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Shopware.Api.Entities.Responses
{
    [DataContract]
    public class PostResponseData
    {
        [DataMember(EmitDefaultValue = false)]
        public int? id { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string location{ get; set; }
    }
}
