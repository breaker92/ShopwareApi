using Shopware.Api.Utili;
using System;
using System.Runtime.Serialization;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class ArticleDetail
    {
        [DataMember(EmitDefaultValue = false)]
        public int id { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int articleId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int unitId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string number { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string supplierNumber { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int kind { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string additionalText { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public bool active { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int inStock { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int stockMin { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string weight { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int? width { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int? len { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int? height { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ean { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string purchasePrice { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int position { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int minPurchase { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int? purchaseSteps { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int? maxPurchase { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int? purchaseUnit { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int? referenceUnit { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string packUnit { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public bool shippingFree { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string releaseDate { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string shippingTime { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public Price[] prices { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public ConfiguratorOption[] configuratorOptions { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public ArticleAttribute attribute { get; set; }
    }
}