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
    [ShopwareEntity(EntityName = "categories", AllowedOperation = OperationTypes.Get | OperationTypes.GetList | OperationTypes.Put | OperationTypes.Post | OperationTypes.Delete)]    
    public class Category
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public int? parentId { get; set; }
        [DataMember]
        public int? mediaId { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public int? position { get; set; }
        [DataMember]
        public string metaTitle { get; set; }
        [DataMember]
        public string metaKeywords { get; set; }
        [DataMember]
        public string metaDescription { get; set; }
        [DataMember]
        public string cmsHeadline { get; set; }
        [DataMember]
        public string cmsText { get; set; }
        [DataMember]
        public bool active { get; set; }
        [DataMember]
        public string template { get; set; }
        [DataMember]
        public string productBoxLayout { get; set; }
        [DataMember]
        public bool? blog { get; set; }
        [DataMember]
        public string path { get; set; }
        [DataMember]
        public bool? showFilterGroups { get; set; }
        [DataMember]
        public bool? external { get; set; }
        [DataMember]
        public bool? hideFilter { get; set; }
        [DataMember]
        public bool? hideTop { get; set; }
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
                catch(Exception e)
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
        public Dictionary<string, string> attribute { get; set; }
        //TODO: emotions    array Media
        //TODO: customerGroups array
        [DataMember]
        public int? childrenCount { get; set; }
        [DataMember]
        public int? articleCount { get; set; }
        [DataMember]
        public int? streamId { get; set; }

    }
}
