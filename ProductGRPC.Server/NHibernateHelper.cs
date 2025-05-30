// ProductGRPC.Server/Data/NHibernateHelper.cs
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using ProductGRPC.Server.Mappings; // Để AddFromAssemblyOf<ProductMap>()

namespace ProductGRPC.Server.Data
{
    public class NHibernateHelper
    {
        private static ISessionFactory? _sessionFactory;
        private static readonly object LockObject = new object();

        public static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    lock (LockObject) // Đảm bảo thread-safe khi khởi tạo
                    {
                        _sessionFactory ??= InitializeSessionFactory();
                    }
                }
                return _sessionFactory!;
            }
        }

        private static ISessionFactory InitializeSessionFactory()
        {
            // Lấy connection string từ appsettings.json (ví dụ)
            // Bạn cần tự thêm IConfiguration vào đây nếu muốn lấy động
            // Ví dụ đơn giản: hardcode connection string
            string connectionString = "Server=NAGAYAMA_PC;Database=DemoDB;User ID=kivyrrah;Password=1234;Trusted_Connection=False;Encrypt=False;";
            // Hoặc nếu dùng Windows Authentication:
            // string connectionString = "Server=YOUR_SERVER_NAME;Database=DemoDB;Trusted_Connection=True;Encrypt=False;";


            return Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012 // Hoặc dialect phù hợp
                    .ConnectionString(connectionString)
                    .ShowSql() // Hiển thị SQL ra console, hữu ích khi debug
                    .FormatSql())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<ProductMap>()) // Tự động tìm các map trong assembly chứa ProductMap
                                                                                 //.ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(false, true)) // Tùy chọn: Tự động cập nhật schema DB khi khởi động (cẩn thận khi dùng ở production)
                .BuildSessionFactory();
        }

        public static NHibernate.ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}