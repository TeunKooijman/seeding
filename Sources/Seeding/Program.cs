using McMaster.Extensions.CommandLineUtils;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Seeding.Commands;
using Seeding.Commands.Seed.Feats;
using Seeding.Feats.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace Seeding
{
    public class Program
    {
		public static async Task Main(string[] args)
		{
			await Host
				.CreateDefaultBuilder(args)
				.ConfigureServices((context, services) =>
				{
					services.AddFeatSeeding();
					services.AddTransient<ICommandExecutor<SeedFeatsCommand>, SeedFeatsCommandExecutor>();
				})
				.RunCommandLineApplicationAsync<RootCommand>(args);
		}
    }
}
