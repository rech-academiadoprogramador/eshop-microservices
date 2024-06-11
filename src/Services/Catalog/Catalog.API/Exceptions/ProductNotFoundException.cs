namespace Catalog.API.Exceptions;

[Serializable]
internal class ProductNotFoundException : Exception
{
    public ProductNotFoundException(Guid id) : base($"Product with id {id} not found")
    {
    }    
}