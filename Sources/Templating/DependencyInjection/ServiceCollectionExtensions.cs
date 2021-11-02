using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Templating.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMustache(this IServiceCollection services)
        {
            services.AddTransient<IMustacheTemplater, MustacheTemplater>();
            return services;
        }
    }
}
