using Shopware.Api.Entities.Attributes;
using Shopware.Api.Utili;
using System.Runtime.Serialization;


namespace Shopware.Api.Entities
{
    [DataContract]
    [ShopwareEntity(EntityName = "articles", AllowedOperation = OperationTypes.Get | OperationTypes.GetList | OperationTypes.Put | OperationTypes.Post | OperationTypes.Delete)]
    public class Article
    {
        [DataMember(EmitDefaultValue = false)]
        public int id { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int? mainDetailId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int? supplierId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int? taxId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int? priceGroupId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int? filterGroupId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int? configuratorSetId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string description { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string descriptionLong { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string changed { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string added { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public bool active { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int? pseudoSales { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public bool? highlight { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string keywords { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string metaTitle { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public bool? priceGroupActive { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public bool? lastStock { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int? crossBundleLook { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public bool? notification { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string template { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int? mode { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string availableFrom { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string availableTo { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public ArticleDetail mainDetail { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public Tax tax { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public PropertyValue[] propertyValues { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public Supplier supplier { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public PropertyGroup propertyGroup { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public CustomerGroup[] customerGroups { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public Image[] images { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public ConfiguratorSet configuratorSet { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public Link[] links { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public Download[] downloads { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public Category[] categories { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public Similar similar { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public Related[] related { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public Category[] seoCategories { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public ArticleDetail[] details { get; set; }

        [IgnoreDataMember]
        public string productnumber
        {
            get
            {
                return mainDetail?.number;
            }
        }
    }
}
