using Microsoft.Extensions.DependencyInjection;
using PhantomNet.AspNetCore.Dashboard;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DashboardServiceCollectionExtensions
    {
        public static DashboardBuilder AddDashboard(this IServiceCollection services)
        {
            return new DashboardBuilder(services);
        }
    }
}
