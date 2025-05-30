// ProductGRPC.Server/Mappings/ProductMap.cs
using FluentNHibernate.Mapping;
using ProductGRPC.Server.Models;

namespace ProductGRPC.Server.Mappings
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Table("Product"); // Tên bảng trong DB
            Id(x => x.Id).GeneratedBy.Identity(); // Khóa chính, tự tăng
            Map(x => x.Name).Not.Nullable();
            Map(x => x.Price).Not.Nullable();
            Map(x => x.Stock).Not.Nullable();
        }
    }
}