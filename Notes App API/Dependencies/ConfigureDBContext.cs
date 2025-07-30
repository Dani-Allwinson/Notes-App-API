using Microsoft.EntityFrameworkCore;
using Notes.Repository;

namespace Notes_App_API.Dependencies
{
    public static partial class Dependencies
    {
        public static IServiceCollection ConfigureDBContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<NotesDBContext>((options) =>
            {
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnectionString"),
                    sqlOptions =>
                    {
                        sqlOptions.CommandTimeout(18000); // Set the command timeout to 180 seconds (adjust as needed)
                    });
            });

            return services;
        }
    }
}
