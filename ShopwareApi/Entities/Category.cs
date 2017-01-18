using Shopware.Api.Entities.Attributes;
using Shopware.Api.Utili;
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
        [DataMember(EmitDefaultValue = false)]
        public int id { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int? parentId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int? mediaId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int? position { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string metaTitle { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string metaKeywords { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string metaDescription { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string cmsHeadline { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string cmsText { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public bool active { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string template { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string productBoxLayout { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public bool? blog { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string path { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public bool? showFilterGroups { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public bool? external { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public bool? hideFilter { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public bool? hideTop { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string changed { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string added { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public Dictionary<string, string> attribute { get; set; }
        //TODO: emotions    array Media
        [DataMember(EmitDefaultValue = false)]
        public CustomerGroup[] customerGroups { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int? childrenCount { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int? articleCount { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int? streamId { get; set; }

    }
}
