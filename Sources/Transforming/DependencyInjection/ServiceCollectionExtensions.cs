using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transforming.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddTransformingServices(this IServiceCollection services)
        {
            services.AddTransient<ITextBlockTransformer, TextBlockTransformer>();
            services.AddTransient<IRollableEffectTransformer, RollableEffectTransformer>();
            return services;
        }
    }
}
