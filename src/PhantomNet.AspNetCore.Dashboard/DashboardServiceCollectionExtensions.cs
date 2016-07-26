using Microsoft.Extensions.DependencyInjection;

namespace PhantomNet.AspNetCore.Dashboard
{
    public static class DashboardServiceCollectionExtensions
    {
        public static DashboardBuilder AddDashboard(this IServiceCollection services)
        {
            return new DashboardBuilder(services);
        }
    }
}
