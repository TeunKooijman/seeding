using Microsoft.Extensions.DependencyInjection;
using Seeding.Feats.Parsers;
using Seeding.Feats.Transformers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Templating.DependencyInjection;

namespace Seeding.Feats.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddFeatSeeding(this IServiceCollection services)
        {
            services.AddTransient<IFeatTransformer, FeatTransformer>();
            services.AddTransient<IFeatParser, FeatParser>();
            services.AddMustache();

            return services;
        }
    }
}
