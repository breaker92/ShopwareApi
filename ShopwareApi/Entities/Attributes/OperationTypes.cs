namespace Shopware.Api.Entities.Attributes
{
    public enum OperationTypes
    {
        Get = 1,
        GetList = 2,
        Put = 4,
        PutBatch = 8,
        Post = 16,
        Delete = 32,
        DeleteBatch = 64
    }
}