using EAIAnalizer.BLL.Services;
using EAIAnalizer.DAL.Repositories;
using EAIAnalizer.Domain.Entities;


namespace EAIAnalizer_Backend.Helpers
{
    /// <summary>
    /// Provides possible to resolve dependencies.
    /// </summary>
    public static class DependencyInjector
    {
        /// <summary>
        /// Registers dependencies(for services and repositories).
        /// </summary>
        /// <param name="builder">WebApplicationBuilder.</param>
        /// <returns>WebApplicationBuilder with resolved dependencies.</returns>
        public static WebApplicationBuilder ResolveDependencies(WebApplicationBuilder builder)
        {
            // Services.
            builder.Services.AddTransient<ISberbankService, SberbankService>();
            builder.Services.AddTransient<IOperationService, OperationService>();

            // Repositories.
            builder.Services.AddTransient<OperationRepository<Operation>>();

            return builder;
        }
    }
}
