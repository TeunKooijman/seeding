using McMaster.Extensions.CommandLineUtils;
using Seeding.Commands.Seed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seeding
{
    [Subcommand(typeof(SeedCommand))]
    public abstract class RootCommand
    {

    }
}
