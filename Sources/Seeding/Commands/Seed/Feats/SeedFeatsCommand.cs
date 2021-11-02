using McMaster.Extensions.CommandLineUtils;
using Seeding.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seeding.Commands.Seed.Feats
{
    [Command(Name = "feats")]
    public class SeedFeatsCommand : CommandBase<SeedFeatsCommand>
    {
        public SeedFeatsCommand(ICommandExecutor<SeedFeatsCommand> executor)
            : base(executor)
        {

        }

        [Option("-i|--input-path", "The input path to the Wanderer's Guide feats.csv input file.", CommandOptionType.SingleValue)]
        public string InputPath { get; set; } = default!;
    }

    public class SeedFeatsCommandExecutor : CommandExecutorBase<SeedFeatsCommand>
    {
        protected override Task OnExecuteAsync(CommandLineApplication app, SeedFeatsCommand command)
        {
            Console.WriteLine("Hello world!!");
            return Task.CompletedTask;
        }
    }
}
