// ProductGRPC.Server/Models/Product.cs
namespace ProductGRPC.Server.Models
{
    public class Product
    {
        public virtual int Id { get; set; }
        public virtual string? Name { get; set; }
        public virtual decimal Price { get; set; }
        public virtual int Stock { get; set; }
    }
}