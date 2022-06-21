using AspNetCore6WebApi.DataAccess.DataAccess.Implementations;
using AspNetCore6WebApi.DataAccess.DataAccess.Interfaces;
using AspNetCore6WebApi.DataAccess.DatabaseContexts;
using AspNetCore6WebApi.DataAccess.Repositories.Implementations;
using AspNetCore6WebApi.DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCore6WebApi.DataAccess
{
    public static class Binder
    {
        public static void Setup(IServiceCollection services, IConfiguration config)
        {
            services.AddTransient<ICustomerDataAccess, CustomerDataAccess>();
            services.AddTransient<ICustomerRopository, CustomerRepository>();

            var connectionString = config.GetConnectionString("Dbdotcom");
            services.AddDbContextPool<DbCustomerContext>(options => options.UseSqlServer(connectionString));
        }
    }
}