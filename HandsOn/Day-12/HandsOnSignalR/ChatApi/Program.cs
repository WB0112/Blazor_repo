
using ChatApi.Hubs;

namespace ChatApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddControllers();
            builder.Services.AddSignalR();//real-time communication

            //CORS configuration
            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(policy =>
                {
                    policy
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowCredentials()
                        .SetIsOriginAllowed(_ => true);
                });
            });


            var app = builder.Build();


            app.UseCors();//enable CORS


            app.MapControllers();
            app.MapHub<ChatHub>("/chathub"); //endpoint for SignalR hub


            app.Run();
        }
    }
}
