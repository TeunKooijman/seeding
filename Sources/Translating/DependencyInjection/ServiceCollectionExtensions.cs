using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translating.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddTranslatingServices(this IServiceCollection services)
        {
            services.AddTransient<IActionTypeTranslator, ActionTypeTranslator>();
            services.AddTransient<INameTranslator, NameTranslator>();
            services.AddTransient<ISourceTranslator, SourceTranslator>();
            return services;
        }
    }
}
