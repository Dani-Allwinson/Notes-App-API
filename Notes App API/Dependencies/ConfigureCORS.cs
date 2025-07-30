namespace Notes_App_API.Dependencies
{
    public static partial class ConfigureCORS
    {
        public static IServiceCollection AddCORS(this IServiceCollection services)
        {

            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                builder.SetIsOriginAllowedToAllowWildcardSubdomains()
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
                .WithExposedHeaders("x-filename"));
            });

            return services;
        }
    }
}
