using Microsoft.Extensions.DependencyInjection;

namespace DoAnThucTap.Web.WebConfig
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServiceRepositories(this IServiceCollection services)
        {
            return services;
        }
    }
}
