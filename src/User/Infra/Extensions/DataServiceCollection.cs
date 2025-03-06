using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PayFlow.User.Infra.Database;

namespace PayFlow.User.Infra.Extensions;

public static class DataServiceCollection
{
    public static IServiceCollection AddDataServiceCollection(
        this IServiceCollection services, 
        Action<DbContextOptionsBuilder> action
    )
    {
        return services.AddDbContext<AppDbContext>(action);
    }
}
