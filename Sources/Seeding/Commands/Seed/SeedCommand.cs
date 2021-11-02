using McMaster.Extensions.CommandLineUtils;
using Seeding.Commands.Seed.Feats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seeding.Commands.Seed
{
    [Command("seed")]
    [HelpOption("--help")]
    [Subcommand(typeof(SeedFeatsCommand))]
    public class SeedCommand
    {

    }
}
