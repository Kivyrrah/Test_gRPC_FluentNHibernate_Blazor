// ProductGRPC.BlazorUI/Program.cs
using ProductGRPC.BlazorUI.Components;
using ProductGRPC.Shared.Protos; // <-- Thêm using này
using Grpc.Net.ClientFactory; // <-- Thêm using này

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents(); // Hoặc AddServerSideBlazor() cho .NET cũ hơn

// Lấy URL của gRPC Server từ appsettings.json
var grpcServerUrl = builder.Configuration["GrpcServerUrl"] ?? "https://localhost:5001"; // Mặc định nếu không có trong config

// Đăng ký gRPC client
builder.Services.AddGrpcClient<ProductService.ProductServiceClient>(options =>
{
    options.Address = new Uri(grpcServerUrl);
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();