﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.FileProviders;
using PhantomNet.AspNetCore.Dashboard;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DashboardViewsServiceCollectionExtensions
    {
        public static DashboardBuilder AddDashboardIdentityAccountViews(this DashboardBuilder builder)
        {
            builder.Services.Configure<RazorViewEngineOptions>(options => {
                options.FileProviders.Add(new EmbeddedFileProvider(DashboardViews.Assembly, DashboardViews.Namespace));
            });

            return builder;
        }
    }
}
