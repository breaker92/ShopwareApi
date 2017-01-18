using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class OrderDetail
    {
        [DataMember(EmitDefaultValue = false)]
        int id { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string orderId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int articleId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        Article article { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int taxId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        Tax tax { get; set; }

        [DataMember(EmitDefaultValue = false)]
        double taxRate { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int statusId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        OrderStatus status { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string number { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string articleNumber { get; set; }

        [DataMember(EmitDefaultValue = false)]
        double price { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int quantity { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string articleName { get; set; }

        [DataMember(EmitDefaultValue = false)]
        bool shipped { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int shippedGroup { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string releaseDate { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int mode { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int esdArticle { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string config { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string ean { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string unit { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string packUnit { get; set; }

        //[DataMember(EmitDefaultValue = false)]
        //attribute   object OrderDetailAttribute
    }
}
