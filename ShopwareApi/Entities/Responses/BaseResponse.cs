using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Shopware.Api.Entities.Responses
{
    [DataContract]
    public class BaseResponse
    {
        [DataMember(EmitDefaultValue = false)]
        public bool success { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string message { get; set; }
    }
}
