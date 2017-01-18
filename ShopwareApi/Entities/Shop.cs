using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Shopware.Api.Entities
{
    [DataContract]
    public class Shop
    {

        [DataMember(EmitDefaultValue = false)]
        int id { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int mainId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int categoryId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        Category category { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string name { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string title { get; set; }

        [DataMember(EmitDefaultValue = false)]
        int position { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string host { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string basePath { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string baseUrl { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string hosts { get; set; }

        [DataMember(EmitDefaultValue = false)]
        bool secure { get; set; }

        [DataMember(EmitDefaultValue = false)]
        bool alwaysSecure { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string secureHost { get; set; }

        [DataMember(EmitDefaultValue = false)]
        string secureBasePath { get; set; }

        //[DataMember(EmitDefaultValue = false)]
        //bool default { get; set; }

        [DataMember(EmitDefaultValue = false)]
        bool active { get; set; }

        [DataMember(EmitDefaultValue = false)]
        bool customerScope { get; set; }

        [DataMember(EmitDefaultValue = false)]
        Locale locale { get; set; }
    }

}

