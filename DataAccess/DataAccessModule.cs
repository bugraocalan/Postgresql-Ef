using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess
{
    public static class DataAccessModule
    {
        public static void AddDbContextModule(this IServiceCollection services,IConfiguration configuration)
        {
            var usrStr = configuration.GetConnectionString("Users");
            services.AddEntityFrameworkNpgsql().AddDbContext<PostgresDbContext>(options =>
            {
                options.UseNpgsql();

            });
        }
    }
}
