// ProductGRPC.Server/Services/ProductServiceImpl.cs
using Grpc.Core;
using ProductGRPC.Server.Models; // Entity Product
using ProductGRPC.Server.Repositories;
using ProductGRPC.Shared.Protos; // Sinh ra từ product.proto
using System.Linq;
using System.Threading.Tasks;

namespace ProductGRPC.Server.Services
{
    // Kế thừa từ ProductService.ProductServiceBase được sinh ra bởi Grpc.Tools
    public class ProductServiceImpl : ProductService.ProductServiceBase
    {
        private readonly IProductRepository _productRepository;
        private readonly ILogger<ProductServiceImpl> _logger;

        public ProductServiceImpl(IProductRepository productRepository, ILogger<ProductServiceImpl> logger)
        {
            _productRepository = productRepository;
            _logger = logger;
        }

        // Helper để map từ Entity sang Proto Model
        private ProductModel ToProductModel(Product product)
        {
            if (product == null) return null!; // Hoặc throw, tùy logic
            return new ProductModel
            {
                Id = product.Id,
                Name = product.Name ?? string.Empty,
                Price = (double)product.Price, // Chuyển từ decimal sang double
                Stock = product.Stock
            };
        }

        public override async Task<ProductModel> GetProductById(GetProductRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"Getting product by ID: {request.Id}");
            var product = await _productRepository.GetByIdAsync(request.Id);
            if (product == null)
            {
                throw new RpcException(new Status(StatusCode.NotFound, $"Product with ID {request.Id} not found."));
            }
            return ToProductModel(product);
        }

        public override async Task<ProductListResponse> GetAllProducts(GetAllProductsRequest request, ServerCallContext context)
        {
            _logger.LogInformation("Getting all products.");
            var products = await _productRepository.GetAllAsync();
            var response = new ProductListResponse();
            response.Products.AddRange(products.Select(ToProductModel));
            return response;
        }

        public override async Task<ProductModel> CreateProduct(CreateProductRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"Creating product with name: {request.Name}");
            var product = new Product
            {
                Name = request.Name,
                Price = (decimal)request.Price, // Chuyển từ double sang decimal
                Stock = request.Stock
            };
            await _productRepository.AddAsync(product);
            return ToProductModel(product); // product sẽ có Id sau khi SaveAsync
        }

        public override async Task<ProductModel> UpdateProduct(UpdateProductRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"Updating product with ID: {request.Id}");
            var product = await _productRepository.GetByIdAsync(request.Id);
            if (product == null)
            {
                throw new RpcException(new Status(StatusCode.NotFound, $"Product with ID {request.Id} not found for update."));
            }

            product.Name = request.Name;
            product.Price = (decimal)request.Price;
            product.Stock = request.Stock;

            await _productRepository.UpdateAsync(product);
            return ToProductModel(product);
        }

        public override async Task<DeleteProductResponse> DeleteProduct(DeleteProductRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"Deleting product with ID: {request.Id}");
            var product = await _productRepository.GetByIdAsync(request.Id);
            if (product == null)
            {
                _logger.LogWarning($"Product with ID {request.Id} not found for deletion.");
                return new DeleteProductResponse { Success = false, Message = $"Product with ID {request.Id} not found." };
            }

            await _productRepository.DeleteAsync(request.Id);
            return new DeleteProductResponse { Success = true, Message = "Product deleted successfully." };
        }
    }
}