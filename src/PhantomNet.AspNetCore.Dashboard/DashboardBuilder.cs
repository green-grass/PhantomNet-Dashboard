using Microsoft.Extensions.DependencyInjection;

namespace PhantomNet.AspNetCore.Dashboard
{
    public class DashboardBuilder
    {
        public DashboardBuilder(IServiceCollection services)
        {
            Services = services;
        }

        public IServiceCollection Services { get; }
    }
}
