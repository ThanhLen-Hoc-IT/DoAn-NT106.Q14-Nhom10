
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi;

namespace UniGate.Api.Configurations
{
    public static class SwaggerConfig
    {
        public static IServiceCollection AddSwaggerConfig(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "UniGate API",
                    Version = "v1"
                });
            });

            return services;
        }
    }
}
