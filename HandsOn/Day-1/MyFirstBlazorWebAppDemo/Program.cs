using MyFirstBlazorWebAppDemo.Components;

var builder = WebApplication.CreateBuilder(args); //web application builder created

// Add services to the container.
builder.Services.AddRazorComponents() //services are being added to the container
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseAntiforgery();

app.MapStaticAssets(); //enable static assets(wwwroot)
app.MapRazorComponents<App>() //root component mapping
    .AddInteractiveServerRenderMode();

app.Run();
