namespace Notes_App_API.Dependencies
{
    public static partial class Dependencies
    {
        public static IServiceCollection ConfigureSwagger(this IServiceCollection services)
        {

            services.AddSwaggerGen();
            return services;
        }
        public static IApplicationBuilder ConfigureSwaggerUI(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.DocumentTitle = "Notes API";
            });
            return app;
        }
    }
}
