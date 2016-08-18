using System;
using System.Runtime.Serialization;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class ArticleDetail
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public int articleId { get; set; }
        [DataMember]
        public int unitId { get; set; }
        [DataMember]
        public string number { get; set; }
        [DataMember]
        public string supplierNumber { get; set; }
        [DataMember]
        public int kind { get; set; }
        [DataMember]
        public string additionalText { get; set; }
        [DataMember]
        public bool active { get; set; }
        [DataMember]
        public int inStock { get; set; }
        [DataMember]
        public int stockMin { get; set; }
        [DataMember]
        public string weight { get; set; }
        [DataMember]
        public int? width { get; set; }
        [DataMember]
        public int? len { get; set; }
        [DataMember]
        public int? height { get; set; }
        [DataMember]
        public string ean { get; set; }
        [DataMember]
        public string purchasePrice { get; set; }
        [DataMember]
        public int position { get; set; }
        [DataMember]
        public int minPurchase { get; set; }
        [DataMember]
        public int? purchaseSteps { get; set; }
        [DataMember]
        public int? maxPurchase { get; set; }
        [DataMember]
        public int? purchaseUnit { get; set; }
        [DataMember]
        public int? referenceUnit { get; set; }
        [DataMember]
        public string packUnit { get; set; }
        [DataMember]
        public bool shippingFree { get; set; }
        [DataMember(Name = "releaseDate")]
        internal string releaseDateString { get; set; }
        [IgnoreDataMember]
        public DateTime releaseDate
        {
            get
            {
                try
                {
                    return DateTime.Parse(releaseDateString);
                }
                catch (Exception e)
                {
                    return DateTime.MinValue;
                }

            }
            set
            {
                releaseDateString = value.ToString("o");
            }
        }
        [DataMember]
        public string shippingTime { get; set; }
        [DataMember]
        public Price[] prices { get; set; }
        [DataMember]
        public ConfiguratorOption[] configuratorOptions { get; set; }
        [DataMember]
        public ArticleAttribute attribute { get; set; }
    }
}