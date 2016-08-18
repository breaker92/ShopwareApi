using System;

namespace Shopware.Api.Entities.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false, AllowMultiple = false)]
    public  class ShopwareEntityAttribute : Attribute
    {
        public ShopwareEntityAttribute()
        {
        }
        
        public string EntityName { get; set; }
        public OperationTypes AllowedOperation { get; set; }

    }
}