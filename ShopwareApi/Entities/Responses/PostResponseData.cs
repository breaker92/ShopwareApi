using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Shopware.Api.Entities.Responses
{
    [DataContract]
    internal class PostResponseData
    {
        [DataMember]
        public int? id { get; set; }
        [DataMember]
        public string location{ get; set; }
    }
}
