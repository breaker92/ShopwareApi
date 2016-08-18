using Shopware.Api.Entities.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Shopware.Api.Entities
{
    [DataContract]
    [ShopwareEntity(EntityName = "articles", AllowedOperation = OperationTypes.Get | OperationTypes.GetList | OperationTypes.Put | OperationTypes.Post | OperationTypes.Delete)]
    public class Article
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public int? mainDetailId { get; set; }
        [DataMember]
        public int? supplierId { get; set; }
        [DataMember]
        public int? taxId { get; set; }
        [DataMember]
        public int? priceGroupId { get; set; }
        [DataMember]
        public int? filterGroupId { get; set; }
        [DataMember]
        public int? configuratorSetId { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public string descriptionLong { get; set; }
        [DataMember(Name = "changed")]
        internal string changedString { get; set; }
        [IgnoreDataMember]
        public DateTime changed
        {
            get
            {
                try
                {
                    return DateTime.Parse(changedString);
                }
                catch (Exception e)
                {
                    return DateTime.MinValue;
                }

            }
            set
            {
                changedString = value.ToString("o");
            }

        }
        [DataMember(Name = "added")]
        internal string addedString { get; set; }
        [IgnoreDataMember]
        public DateTime added
        {
            get
            {
                try
                {
                    return DateTime.Parse(addedString);
                }
                catch (Exception e)
                {
                    return DateTime.MinValue;
                }

            }
            set
            {
                addedString = value.ToString("o");
            }

        }
        [DataMember]
        public bool active { get; set; }
        [DataMember]
        public int? pseudoSales { get; set; }
        [DataMember]
        public bool? highlight { get; set; }
        [DataMember]
        public string keywords { get; set; }
        [DataMember]
        public string metaTitle { get; set; }
        [DataMember]
        public bool? priceGroupActive { get; set; }
        [DataMember]
        public bool? lastStock { get; set; }
        [DataMember]
        public int? crossBundleLook { get; set; }
        [DataMember]
        public bool? notification { get; set; }
        [DataMember]
        public string template { get; set; }
        [DataMember]
        public int? mode { get; set; }
        [DataMember(Name = "availableFrom")]
        internal string availableFromString { get; set; }
        [IgnoreDataMember]
        public DateTime availableFrom
        {
            get
            {
                try
                {
                    return DateTime.Parse(availableFromString);
                }
                catch (Exception e)
                {
                    return DateTime.MinValue;
                }

            }
            set
            {
                availableFromString = value.ToString("o");
            }

        }
        [DataMember(Name = "availableTo")]
        internal string availableToString { get; set; }
        [IgnoreDataMember]
        public DateTime availableTo
        {
            get
            {
                try
                {
                    return DateTime.Parse(availableToString);
                }
                catch (Exception e)
                {
                    return DateTime.MinValue;
                }

            }
            set
            {
                availableToString = value.ToString("o");
            }

        }
        [DataMember]
        public ArticleDetail mainDetail { get; set; }
        [DataMember]
        public Tax tax { get; set; }
        [DataMember]
        public PropertyValue[] propertyValues { get; set; }
        [DataMember]
        public Supplier supplier { get; set; }
        [DataMember]
        public PropertyGroup propertyGroup { get; set; }
        [DataMember]
        public CustomerGroup[] customerGroups { get; set; }
        [DataMember]
        public Image[] images { get; set; }
        [DataMember]
        public ConfiguratorSet configuratorSet { get; set; }
        [DataMember]
        public Link[] links { get; set; }
        [DataMember]
        public Download[] downloads { get; set; }
        [DataMember]
        public Category[] categories { get; set; }
        [DataMember]
        public Similar similar { get; set; }
        [DataMember]
        public Related[] related { get; set; }
        [DataMember]
        public Category[] seoCategories { get; set; }
        [DataMember]
        public ArticleDetail[] details { get; set; }
    }
}
