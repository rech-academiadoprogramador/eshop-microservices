using BuildingBlocks.Exceptions;

namespace Catalog.API.Exceptions;

[Serializable]
internal class ProductNotFoundException : NotFoundException
{
    public ProductNotFoundException(Guid id) : base($"Product with id {id} not found")
    {
    }    
}