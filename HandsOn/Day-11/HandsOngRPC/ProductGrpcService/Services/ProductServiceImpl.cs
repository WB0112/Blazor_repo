using Grpc.Core;
namespace ProductGrpcService.Services;

public class ProductServiceImpl : ProductService.ProductServiceBase
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