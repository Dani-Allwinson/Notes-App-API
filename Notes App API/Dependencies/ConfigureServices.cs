using Notes.Repository.Interface;
using Notes.Repository.ProcedureValidation;

namespace Notes_App_API.Dependencies
{
    public static partial class Dependencies
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<INotesTagsService, NotesTagsService>();
            return services;
        }
    }
}
