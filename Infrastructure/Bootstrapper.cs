using Application.Interfaces.Repositories;
using Infrastructure.Common;
using Infrastructure.Data.Context;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Infrastructure.Repositories;

namespace Infrastructure
{
    public static class Bootstrapper
    {
        public static void AddInfrastructure(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddSingleton<IMongoDbContext, MongoDbContext>();
            service.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));
            service.AddScoped<IRepositoryExecutor, RepositoryExecutor>();
        }
    }
}
