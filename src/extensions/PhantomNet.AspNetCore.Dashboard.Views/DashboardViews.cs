using System.Reflection;

namespace PhantomNet.AspNetCore.Dashboard
{
    public static class DashboardViews
    {
        public static Assembly Assembly => typeof(DashboardViews).GetTypeInfo().Assembly;

        public static string Namespace => typeof(DashboardViews).GetTypeInfo().Namespace;
    }
}
