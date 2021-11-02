using McMaster.Extensions.CommandLineUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seeding.Commands
{
    [HelpOption("--help")]
    public abstract class CommandBase<TCommand>
        where TCommand : CommandBase<TCommand>
    {
        private ICommandExecutor<TCommand> Executor { get; }

        protected CommandBase(ICommandExecutor<TCommand> executor)
        {
            Executor = executor;
        }

        protected virtual async Task<int> OnExecuteAsync(CommandLineApplication app)
        {
            return await Executor.ExecuteAsync(app, (TCommand)this);
        }
    }
}
