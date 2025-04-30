using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace POS.Infrastructure
{
    public static  class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddDbContext<POSDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            //services.AddScoped<IUnitOfWork, UnitOfWork>();
            //services.AddScoped<IRepository<Product>, ProductRepository>();
            //services.AddScoped<IRepository<Category>, CategoryRepository>();
            //services.AddScoped<IRepository<Supplier>, SupplierRepository>();
            //services.AddScoped<IRepository<Customer>, CustomerRepository>();
            //services.AddScoped<IRepository<Order>, OrderRepository>();
            //services.AddScoped<IRepository<OrderItem>, OrderItemRepository>();
            return services;
        }
    }
}
