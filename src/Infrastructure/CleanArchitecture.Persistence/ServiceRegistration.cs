using CleanArchitecture.Application.Interfaces.Repositories;
using CleanArchitecture.Persistence.Database;
using CleanArchitecture.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<ApplicationDbContext>(opt => opt.UseInMemoryDatabase("productDatabase"));
            serviceCollection.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
