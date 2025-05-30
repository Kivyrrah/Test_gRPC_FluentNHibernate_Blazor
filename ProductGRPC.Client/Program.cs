// ProductGRPC.Client/Program.cs
using Grpc.Net.Client;
using ProductGRPC.Shared.Protos; // Namespace từ file .proto
using System;
using System.Threading.Tasks;

namespace ProductGRPC.Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Địa chỉ của gRPC server.
            // Đảm bảo server đang chạy và địa chỉ này chính xác (kiểm tra launchSettings.json của Server project)
            // Nếu server dùng HTTPS và có chứng chỉ tự ký (dev cert), client có thể cần cấu hình thêm để tin cậy.
            // Với dev cert của .NET, thường là không cần.
            var channel = GrpcChannel.ForAddress("https://localhost:5001"); // Sử dụng cổng HTTPS mà server đang listen
            var client = new ProductService.ProductServiceClient(channel);

            Console.WriteLine("gRPC Product Client");
            Console.WriteLine("-------------------");

            try
            {
                // 1. Tạo Product mới
                Console.WriteLine("\nCreating new product...");
                var newProductRequest = new CreateProductRequest
                {
                    Name = "Awesome Gadget Pro",
                    Price = 199.99,
                    Stock = 75
                };
                var createdProduct = await client.CreateProductAsync(newProductRequest);
                Console.WriteLine($"Created Product: Id={createdProduct.Id}, Name={createdProduct.Name}, Price={createdProduct.Price}, Stock={createdProduct.Stock}");
                int newProductId = createdProduct.Id;

                // 2. Lấy tất cả Product
                Console.WriteLine("\nGetting all products...");
                var allProducts = await client.GetAllProductsAsync(new GetAllProductsRequest());
                foreach (var p in allProducts.Products)
                {
                    Console.WriteLine($" - Id={p.Id}, Name={p.Name}, Price={p.Price}, Stock={p.Stock}");
                }

                // 3. Lấy Product theo Id
                Console.WriteLine($"\nGetting product with Id: {newProductId}...");
                var productById = await client.GetProductByIdAsync(new GetProductRequest { Id = newProductId });
                Console.WriteLine($"Found: Id={productById.Id}, Name={productById.Name}, Price={productById.Price}");

                // 4. Cập nhật Product
                Console.WriteLine($"\nUpdating product with Id: {newProductId}...");
                var updateRequest = new UpdateProductRequest
                {
                    Id = newProductId,
                    Name = "Awesome Gadget Pro MAX",
                    Price = 249.99,
                    Stock = 70
                };
                var updatedProduct = await client.UpdateProductAsync(updateRequest);
                Console.WriteLine($"Updated: Id={updatedProduct.Id}, Name={updatedProduct.Name}, Price={updatedProduct.Price}, Stock={updatedProduct.Stock}");
                
                // 5. Xóa Product
                Console.WriteLine($"\nDeleting product with Id: {newProductId}...");
                var deleteResponse = await client.DeleteProductAsync(new DeleteProductRequest { Id = newProductId });
                Console.WriteLine($"Delete status: {deleteResponse.Success} - Message: {deleteResponse.Message}");
                
                // Thử lấy lại sản phẩm đã xóa để xác nhận
                Console.WriteLine($"\nAttempting to get deleted product Id: {newProductId}...");
                try
                {
                    await client.GetProductByIdAsync(new GetProductRequest { Id = newProductId });
                }
                catch (Grpc.Core.RpcException ex) when (ex.StatusCode == Grpc.Core.StatusCode.NotFound)
                {
                    Console.WriteLine("Product not found, as expected after deletion.");
                }
                
            }
            catch (Grpc.Core.RpcException e)
            {
                Console.WriteLine($"gRPC Error: {e.Status.StatusCode} - {e.Status.Detail}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}