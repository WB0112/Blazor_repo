using Grpc.Core;
namespace ProductGrpcService.Services;
// Inherit from the generated base class for the gRPC service
public class ProductServiceImpl : ProductService.ProductServiceBase // When inheriting from a base class, use the 'Base' suffix
{
    public override Task<ProductReply> GetProduct(
        ProductRequest request,
        ServerCallContext context)
    {
        return Task.FromResult(new ProductReply
        {
            Id = request.Id,
            Name = "Laptop",
            Price = 75000
        });
    }
}