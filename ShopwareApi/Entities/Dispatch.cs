using System.Runtime.Serialization;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class Dispatch
    {

        [DataMember(EmitDefaultValue = false)]
        int id { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string name { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int type { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string description { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string comment { get; set; }

        [DataMember(EmitDefaultValue = false)]
        bool active { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int position { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int calculation { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int surchargeCalculation { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int taxCalculation { get; set; }

        [DataMember(EmitDefaultValue = false)]
        decimal shippingFree { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int multiShopId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        Shop multiShop { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int customerGroupId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        CustomerGroup customerGroup { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int bindShippingFree { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int bindTimeFrom { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int bindTimeTo { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int bindInStock { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int bindWeekdayFrom { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int bindPriceTo { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string bindSql { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string statusLink { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string calculationSql { get; set; }

    }
}