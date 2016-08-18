using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Shopware.Api.Entities.Responses
{
    [DataContract]
    internal class SingelResponse<T> : BaseResponse
    {
        [DataMember]
        public T data { get; set; }
    }
}
