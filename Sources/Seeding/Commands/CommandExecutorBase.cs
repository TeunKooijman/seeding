using McMaster.Extensions.CommandLineUtils;
using Microsoft.Extensions.Logging;
using Seeding.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seeding.Commands
{
    public interface ICommandExecutor<TCommand>
    {
        public Task<int> ExecuteAsync(CommandLineApplication app, TCommand command);
    }

    public abstract class CommandExecutorBase<TCommand> : ICommandExecutor<TCommand>
        where TCommand : CommandBase<TCommand>
    {
        public async Task<int> ExecuteAsync(CommandLineApplication app, TCommand command)
        {
            try
            {
                await OnExecuteAsync(app, command);
                return 0;
            }
            catch (ExitCodeException exception)
            {
                return exception.ExitCode;
            }
            catch (Exception)
            {
                return 1;
            }
        }

        protected abstract Task OnExecuteAsync(CommandLineApplication app, TCommand command);
    }

}
