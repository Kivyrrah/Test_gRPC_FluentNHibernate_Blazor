// ProductGRPC.Server/Program.cs
using ProductGRPC.Server.Data; // Cho NHibernateHelper
using ProductGRPC.Server.Repositories;
using ProductGRPC.Server.Services;

var builder = WebApplication.CreateBuilder(args);

// Cấu hình Connection String (nên đặt trong appsettings.json)
// Ví dụ, nếu bạn đã sửa NHibernateHelper để đọc từ IConfiguration:
// var connectionString = builder.Configuration.GetConnectionString("DemoDBConnection");
// Và truyền connectionString này vào NHibernateHelper.InitializeSessionFactory(connectionString);

// Add services to the container.
builder.Services.AddGrpc();

// Đăng ký NHibernate ISessionFactory (singleton)
// Cách đơn giản là truy cập trực tiếp NHibernateHelper.SessionFactory khi cần ISession.
// Nếu muốn inject ISessionFactory:
builder.Services.AddSingleton(sp => NHibernateHelper.SessionFactory); // ISessionFactory là thread-safe
// Hoặc nếu bạn muốn inject ISession (thường là scoped):
// builder.Services.AddScoped(sp => NHibernateHelper.OpenSession()); // ISession không thread-safe

// Đăng ký Repository
builder.Services.AddScoped<IProductRepository, ProductRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<ProductServiceImpl>(); // Map gRPC service của bạn

app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();