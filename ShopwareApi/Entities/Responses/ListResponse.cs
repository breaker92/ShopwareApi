using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Shopware.Api.Entities.Responses
{
    [DataContract]
    internal class ListResponse<T> : BaseResponse
    {
        [DataMember]
        public T[] data { get; set; }
        [DataMember]
        public int? total { get; set; }
    }
}
