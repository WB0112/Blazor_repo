using ProductGrpcService.Services;

namespace ProductGrpcService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddGrpc();

            var app = builder.Build();

            app.MapGrpcService<ProductServiceImpl>();
            app.MapGet("/", () => "gRPC Server Running");

            app.Run();
        }
    }
}
