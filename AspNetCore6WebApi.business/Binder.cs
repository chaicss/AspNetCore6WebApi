using AspNetCore6WebApi.business.Managers.Implementations;
using AspNetCore6WebApi.business.Managers.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCore6WebApi.business
{
    public static class Binder
    {
        public static void Setup(IServiceCollection services)
        {
            services.AddTransient<ICustomerManager, CustomerManager>();
        }
    }
}